namespace FiyatBu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextboxSearch = new DarkUI.Controls.DarkTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LabelBarcode = new DarkUI.Controls.DarkLabel();
            this.LabelProductName = new DarkUI.Controls.DarkLabel();
            this.LabelProductPrice = new DarkUI.Controls.DarkLabel();
            this.LabelProductAvg = new DarkUI.Controls.DarkLabel();
            this.LabelFirmName = new DarkUI.Controls.DarkLabel();
            this.LabelFirmAddress = new DarkUI.Controls.DarkLabel();
            this.LabelFirmPhone = new DarkUI.Controls.DarkLabel();
            this.LabelSession = new DarkUI.Controls.DarkLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonExit = new DarkUI.Controls.DarkButton();
            this.ButtonMinimize = new DarkUI.Controls.DarkButton();
            this.PictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.PictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(0, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 326);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TextboxSearch);
            this.panel2.Location = new System.Drawing.Point(3, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 371);
            this.panel2.TabIndex = 5;
            // 
            // TextboxSearch
            // 
            this.TextboxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.TextboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextboxSearch.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextboxSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.TextboxSearch.Location = new System.Drawing.Point(0, -1);
            this.TextboxSearch.Name = "TextboxSearch";
            this.TextboxSearch.Size = new System.Drawing.Size(138, 20);
            this.TextboxSearch.TabIndex = 0;
            this.TextboxSearch.Text = "Barkod / Ürün adı";
            this.TextboxSearch.TextChanged += new System.EventHandler(this.TextboxSearch_TextChanged);
            this.TextboxSearch.Enter += new System.EventHandler(this.TextboxSearch_Enter);
            this.TextboxSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextboxSearch_KeyUp);
            this.TextboxSearch.Leave += new System.EventHandler(this.TextboxSearch_Leave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseMove);
            this.splitContainer1.Panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel1_MouseUp);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseDown);
            this.splitContainer1.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseMove);
            this.splitContainer1.Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.splitContainer1_Panel2_MouseUp);
            this.splitContainer1.Size = new System.Drawing.Size(351, 450);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Location = new System.Drawing.Point(-1, 55);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(209, 371);
            this.panel6.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(204, 111);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 259);
            this.panel3.TabIndex = 17;
            // 
            // LabelBarcode
            // 
            this.LabelBarcode.AutoSize = true;
            this.LabelBarcode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelBarcode.Location = new System.Drawing.Point(532, 66);
            this.LabelBarcode.Name = "LabelBarcode";
            this.LabelBarcode.Size = new System.Drawing.Size(73, 13);
            this.LabelBarcode.TabIndex = 9;
            this.LabelBarcode.Text = "Ürün Barkod: ";
            // 
            // LabelProductName
            // 
            this.LabelProductName.AutoSize = true;
            this.LabelProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelProductName.Location = new System.Drawing.Point(532, 93);
            this.LabelProductName.Name = "LabelProductName";
            this.LabelProductName.Size = new System.Drawing.Size(54, 13);
            this.LabelProductName.TabIndex = 10;
            this.LabelProductName.Text = "Ürün Adı: ";
            // 
            // LabelProductPrice
            // 
            this.LabelProductPrice.AutoSize = true;
            this.LabelProductPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelProductPrice.Location = new System.Drawing.Point(532, 119);
            this.LabelProductPrice.Name = "LabelProductPrice";
            this.LabelProductPrice.Size = new System.Drawing.Size(68, 13);
            this.LabelProductPrice.TabIndex = 11;
            this.LabelProductPrice.Text = "Ürün Bedeli: ";
            // 
            // LabelProductAvg
            // 
            this.LabelProductAvg.AutoSize = true;
            this.LabelProductAvg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelProductAvg.Location = new System.Drawing.Point(532, 144);
            this.LabelProductAvg.Name = "LabelProductAvg";
            this.LabelProductAvg.Size = new System.Drawing.Size(80, 13);
            this.LabelProductAvg.TabIndex = 12;
            this.LabelProductAvg.Text = "Ortalama Fiyat: ";
            // 
            // LabelFirmName
            // 
            this.LabelFirmName.AutoSize = true;
            this.LabelFirmName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFirmName.Location = new System.Drawing.Point(365, 194);
            this.LabelFirmName.Name = "LabelFirmName";
            this.LabelFirmName.Size = new System.Drawing.Size(56, 13);
            this.LabelFirmName.TabIndex = 13;
            this.LabelFirmName.Text = "Firma Adı: ";
            // 
            // LabelFirmAddress
            // 
            this.LabelFirmAddress.AutoSize = true;
            this.LabelFirmAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFirmAddress.Location = new System.Drawing.Point(365, 222);
            this.LabelFirmAddress.Name = "LabelFirmAddress";
            this.LabelFirmAddress.Size = new System.Drawing.Size(70, 13);
            this.LabelFirmAddress.TabIndex = 14;
            this.LabelFirmAddress.Text = "Firma Adresi: ";
            // 
            // LabelFirmPhone
            // 
            this.LabelFirmPhone.AutoSize = true;
            this.LabelFirmPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelFirmPhone.Location = new System.Drawing.Point(365, 250);
            this.LabelFirmPhone.Name = "LabelFirmPhone";
            this.LabelFirmPhone.Size = new System.Drawing.Size(77, 13);
            this.LabelFirmPhone.TabIndex = 15;
            this.LabelFirmPhone.Text = "Firma Telefon: ";
            // 
            // LabelSession
            // 
            this.LabelSession.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.LabelSession.Location = new System.Drawing.Point(4, 345);
            this.LabelSession.Name = "LabelSession";
            this.LabelSession.Size = new System.Drawing.Size(438, 13);
            this.LabelSession.TabIndex = 16;
            this.LabelSession.Text = "Session:";
            this.LabelSession.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.PictureBoxLogo);
            this.panel4.Controls.Add(this.LabelSession);
            this.panel4.Location = new System.Drawing.Point(350, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(451, 371);
            this.panel4.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(469, 427);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 18;
            this.ButtonExit.Text = "Çıkış";
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Location = new System.Drawing.Point(604, 427);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Padding = new System.Windows.Forms.Padding(5);
            this.ButtonMinimize.Size = new System.Drawing.Size(75, 23);
            this.ButtonMinimize.TabIndex = 19;
            this.ButtonMinimize.Text = "Küçült";
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // PictureBoxProduct
            // 
            this.PictureBoxProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PictureBoxProduct.Image = global::FiyatBu.Properties.Resources.box;
            this.PictureBoxProduct.Location = new System.Drawing.Point(351, 55);
            this.PictureBoxProduct.Name = "PictureBoxProduct";
            this.PictureBoxProduct.Size = new System.Drawing.Size(157, 110);
            this.PictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProduct.TabIndex = 8;
            this.PictureBoxProduct.TabStop = false;
            // 
            // PictureBoxLogo
            // 
            this.PictureBoxLogo.Image = global::FiyatBu.Properties.Resources.logo;
            this.PictureBoxLogo.Location = new System.Drawing.Point(345, 256);
            this.PictureBoxLogo.Name = "PictureBoxLogo";
            this.PictureBoxLogo.Size = new System.Drawing.Size(92, 88);
            this.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxLogo.TabIndex = 17;
            this.PictureBoxLogo.TabStop = false;
            this.PictureBoxLogo.Click += new System.EventHandler(this.PictureBoxLogo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonMinimize);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.LabelFirmPhone);
            this.Controls.Add(this.LabelFirmAddress);
            this.Controls.Add(this.LabelFirmName);
            this.Controls.Add(this.LabelProductAvg);
            this.Controls.Add(this.LabelProductPrice);
            this.Controls.Add(this.LabelProductName);
            this.Controls.Add(this.LabelBarcode);
            this.Controls.Add(this.PictureBoxProduct);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_LoadAsync);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DarkUI.Controls.DarkTextBox TextboxSearch;
        private System.Windows.Forms.PictureBox PictureBoxProduct;
        private DarkUI.Controls.DarkLabel LabelBarcode;
        private DarkUI.Controls.DarkLabel LabelProductName;
        private DarkUI.Controls.DarkLabel LabelProductPrice;
        private DarkUI.Controls.DarkLabel LabelProductAvg;
        private DarkUI.Controls.DarkLabel LabelFirmName;
        private DarkUI.Controls.DarkLabel LabelFirmAddress;
        private DarkUI.Controls.DarkLabel LabelFirmPhone;
        private DarkUI.Controls.DarkLabel LabelSession;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private DarkUI.Controls.DarkButton ButtonExit;
        private DarkUI.Controls.DarkButton ButtonMinimize;
        private System.Windows.Forms.PictureBox PictureBoxLogo;
    }
}

