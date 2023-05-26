using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatBu.Interfaces
{
    internal class IResponseData
    {
        public bool status { get; set; }
        public string desc { get; set; }
        public List<Products> Product { get; set; }
    }
}
