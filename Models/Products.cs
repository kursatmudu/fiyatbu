using FiyatBu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatBu
{
    internal class Products : IResponseData
    {
        public string barcode { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string average { get; set; }
        public string firm_name { get; set; }
        public string firm_address { get; set; }
        public string firm_tel { get; set; }
        public string imagePath { get; set; }

        public static explicit operator Products(List<Products> v)
        {
            throw new NotImplementedException();
        }
    }
}
