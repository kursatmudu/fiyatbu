using FiyatBu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatBu.Models
{
    internal class SearchQueryData
    {
        public string sessionID { get; set; }
        public string search { get; set; }
        public string type { get; set; }
        public string version { get; set; }
        public string appPlatform { get; set; }
        internal Dictionary<string, string> ToDictionary()
        {
            return new Dictionary<string, string>()
            {
                { nameof(sessionID), sessionID },
                { nameof(type), type },
                { nameof(search), search },
                { nameof(version), version },
                { nameof(appPlatform), appPlatform }
            };
        }
        internal string ToQueryString()
        {
            StringBuilder queryStringBuilder = new StringBuilder();

            AppendQueryStringParameter(queryStringBuilder, nameof(sessionID), sessionID);
            AppendQueryStringParameter(queryStringBuilder, nameof(search), search);
            AppendQueryStringParameter(queryStringBuilder, nameof(type), type);
            AppendQueryStringParameter(queryStringBuilder, nameof(version), version);
            AppendQueryStringParameter(queryStringBuilder, nameof(appPlatform), appPlatform);

            return queryStringBuilder.ToString().TrimEnd('&');
        }
        private void AppendQueryStringParameter(StringBuilder queryStringBuilder, string parameterName, string parameterValue)
        {
            if (parameterName != "sifre")
            {
                queryStringBuilder.Append(Uri.EscapeDataString(parameterName));
                queryStringBuilder.Append("=");
                if (!String.IsNullOrEmpty(parameterValue)) queryStringBuilder.Append(Uri.EscapeDataString(parameterValue));
                queryStringBuilder.Append("&");
            }
        }
    }
}
