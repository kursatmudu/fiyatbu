using FiyatBu.Interfaces;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatBu
{
    internal class BarcodeQueryData
    {
        public string sessionID { get; set; }
        public string barcode { get; set; }
        public string type { get; set; }
        internal Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string>()
            {
                { nameof(sessionID), sessionID },
                { nameof(barcode), barcode },
                { nameof(type), type }
            };
        }
        internal string ToQueryString()
        {
            StringBuilder queryStringBuilder = new StringBuilder();

            AppendQueryStringParameter(queryStringBuilder, nameof(sessionID), sessionID);
            AppendQueryStringParameter(queryStringBuilder, nameof(barcode), barcode);
            AppendQueryStringParameter(queryStringBuilder, nameof(type), type);

            return queryStringBuilder.ToString().TrimEnd('&');
        }
        private void AppendQueryStringParameter(StringBuilder queryStringBuilder, string parameterName, string parameterValue)
        {
            queryStringBuilder.Append(Uri.EscapeDataString(parameterName));
            queryStringBuilder.Append("=");
            queryStringBuilder.Append(Uri.EscapeDataString(parameterValue));
            queryStringBuilder.Append("&");
        }
    }
}

