using FiyatBu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatBu.Models
{
    internal class Session : IResponseData
    {
        public string sessionID { get; set; }
    }
}
