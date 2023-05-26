using DarkUI.Controls;
using FiyatBu.Interfaces;
using FiyatBu.Models;
using FiyatBu.Utilities;
using FiyatBu.Views;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiyatBu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int scrollStartPosition;
        private int scrollOffset;
        private int timerCount = 0;
        private bool isDragging;
        private Point dragStartPoint;
        HttpRequestSender client = new HttpRequestSender();
        SearchQueryData searchQueryData = new SearchQueryData();
        BarcodeQueryData barcodeQueryData = new BarcodeQueryData();
        List<Products> sortedProducts;
        QueryInput queryInput;
        IResponseData result;
        private async void Form1_LoadAsync(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.sessionID))
            {
                result = new IResponseData();
                result = await client.HttpRequestAsync();
                if (result is Session session)
                {
                    Properties.Settings.Default.sessionID = session.sessionID;
                }
            }
            barcodeQueryData.sessionID = Properties.Settings.Default.sessionID;
            searchQueryData.sessionID = Properties.Settings.Default.sessionID;
            LabelSession.Text = $"Session: {Properties.Settings.Default.sessionID}";
        }
        private async Task CreateButtonsAsync(Products products)
        {
            sortedProducts = new List<Products>();
            panel1.Controls.Clear();
            if (products.Product != null) sortedProducts = products.Product.OrderByDescending(p => float.Parse(p.price.Replace("₺", ""))).ToList();
            else sortedProducts.Add(products);
            int buttonCount = 0;
            foreach (Products product in sortedProducts)
            {
                Button button = new Button();
                PictureBox pictureBox = new PictureBox();
                DarkLabel darkLabel = new DarkLabel();
                button.Text = product.name;
                button.Click += Button_Click;
                button.MouseMove += Button_Move;
                button.MouseDown += Button_MouseDown;
                button.MouseUp += Button_MouseUp;
                button.BackColor = Color.FromArgb(35, 32, 39);
                button.Size = new Size(142, 66);
                button.FlatStyle = FlatStyle.Flat;
                button.ForeColor = Color.Gainsboro;
                button.FlatAppearance.BorderSize = 0;
                button.Dock = DockStyle.Top;
                button.Padding = new Padding(50, 0, 10, 10);
                button.TextAlign = ContentAlignment.MiddleLeft;
                button.Font = new Font("Mongolian Baiti", 10);
                button.Tag = buttonCount;
                pictureBox.Image = !String.IsNullOrEmpty(product.imagePath) ? await SetImage(product.imagePath) : Properties.Resources.box;
                pictureBox.Size = new Size(54, 66);
                pictureBox.BackColor = Color.FromArgb(35, 32, 39);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Location = new Point(0, 0);
                pictureBox.MouseMove += Button_Move;
                pictureBox.MouseUp += Button_MouseUp;
                darkLabel.Text = product.price;
                darkLabel.BackColor = Color.Transparent;
                darkLabel.TextAlign = ContentAlignment.BottomRight;
                darkLabel.AutoSize = false;
                darkLabel.Location = new Point(56, 45);
                button.Controls.Add(darkLabel);
                panel1.Controls.Add(button);
                button.Controls.Add(pictureBox);
                buttonCount++;
            }
            if (sortedProducts[0].desc != null) panel1.Controls.Clear();
        }
        private async Task<Image> SetImage(string imagePath)
        {
            WebClient webClient = new WebClient();
            byte[] imageData = await webClient.DownloadDataTaskAsync(imagePath);
            MemoryStream stream = new MemoryStream(imageData);
            Image image = Image.FromStream(stream);
            stream.Dispose();
            webClient.Dispose();
            return image;
        }
        private void SetNewPanelSize()
        {
            int totalHeight = 0;
            int simpleHeight = 0;
            foreach (Control control in panel1.Controls)
            {
                totalHeight += control.Height;
                simpleHeight = control.Height;
            }
            int visibleHeight = panel1.ClientSize.Height;
            int maxScrollValue = Math.Max(0, totalHeight - visibleHeight);
            panel1.VerticalScroll.Maximum = maxScrollValue;
        }
        public static string GetDisplayValue(string value)
        {
            return string.IsNullOrEmpty(value) ? "Bilinmiyor" : value;
        }
        private async void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Products product = sortedProducts[int.Parse(button.Tag.ToString())];
            LabelBarcode.Text = $"Ürün Barkod: {GetDisplayValue(product.barcode)}"; //TODO: label'ları isimlendir veriyi gönder.
            LabelProductName.Text = $"Ürün Adı: {GetDisplayValue(product.name)}";
            LabelProductPrice.Text = $"Ürün Bedeli: {GetDisplayValue(product.price)}";
            LabelProductAvg.Text = $"Ortalama Fiyat: {GetDisplayValue(product.average)}";
            LabelFirmName.Text = $"Firma Adı: {GetDisplayValue(product.firm_name)}";
            LabelFirmAddress.Text = $"Firma Adresi: {GetDisplayValue(product.firm_address)}";
            LabelFirmPhone.Text = $"Firma Telefon: {GetDisplayValue(product.firm_tel)}";
            PictureBoxProduct.Image = String.IsNullOrEmpty(product.imagePath) ? Properties.Resources.box : await SetImage(product.imagePath);
        }
        public async Task CreateTask()
        {
            bool isBarcode = Regex.IsMatch(TextboxSearch.Text, @"^\d+$");
            if (isBarcode)
            {
                IResponseData response = await queryInput.CreateQuery(barcode: TextboxSearch.Text, search: null);
                if (response is Products products) _ = CreateButtonsAsync(products);
            }
            else
            {
                IResponseData response = await queryInput.CreateQuery(barcode: null, search: TextboxSearch.Text);
                if (response is Products products) _ = CreateButtonsAsync(products);
            }
        }

        private void Button_MouseDown(object sender, MouseEventArgs e)
        {
            scrollStartPosition = e.Button == MouseButtons.Left ? e.Y : scrollStartPosition;
        }

        private void Button_MouseUp(object sender, MouseEventArgs e)
        {
            scrollStartPosition = 0;
        }
        private void Button_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int scrollAmount = e.Y - scrollStartPosition;
                int newScrollOffset = scrollOffset - scrollAmount;
                newScrollOffset = Math.Max(0, newScrollOffset);
                newScrollOffset = Math.Min(panel1.VerticalScroll.Maximum, newScrollOffset);
                panel1.VerticalScroll.Value = newScrollOffset;
                scrollOffset = newScrollOffset;
            }
        }

        private void TextboxSearch_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void TextboxSearch_Enter(object sender, EventArgs e)
        {
            if (TextboxSearch.Text == "Barkod / Ürün adı")
            {
                TextboxSearch.Text = string.Empty;
                TextboxSearch.ForeColor = Color.Gainsboro;
            }
        }

        private void TextboxSearch_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextboxSearch.Text))
            {
                TextboxSearch.Text = "Barkod / Ürün adı";
                TextboxSearch.ForeColor = Color.DimGray;
            }
        }

        private void TextboxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            timerCount = 0;
            if (String.IsNullOrEmpty(TextboxSearch.Text))
            {
                panel1.Controls.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timerCount >= 1)
            {
                if (TextboxSearch.Text != "Barkod / Ürün adı" && !String.IsNullOrEmpty(TextboxSearch.Text))
                {
                    queryInput = new QueryInput(searchQueryData, barcodeQueryData);
                    _ = CreateTask();
                    SetNewPanelSize();
                }
                timer1.Enabled = false;
            }
            timerCount++;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(currentPoint.X - dragStartPoint.X, currentPoint.Y - dragStartPoint.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void splitContainer1_Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPoint = new Point(e.X, e.Y);
        }

        private void splitContainer1_Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(currentPoint.X - dragStartPoint.X, currentPoint.Y - dragStartPoint.Y);
            }
        }

        private void splitContainer1_Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void splitContainer1_Panel2_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            dragStartPoint = new Point(e.X, e.Y);
        }

        private void splitContainer1_Panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPoint = PointToScreen(new Point(e.X, e.Y));
                Location = new Point(currentPoint.X - dragStartPoint.X, currentPoint.Y - dragStartPoint.Y);
            }
        }

        private void splitContainer1_Panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://play.google.com/store/apps/details?id=com.barkodsorgulama",
                UseShellExecute = true
            });
        }
    }
}
