using FiyatBu.Interfaces;
using FiyatBu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiyatBu.Utilities
{
    internal class QueryInput
    {
        private SearchQueryData searchQueryData;
        private BarcodeQueryData barcodeQueryData;
        Encryption encryption = new Encryption();
        HttpRequestSender requestSender = new HttpRequestSender();

        public QueryInput(SearchQueryData searchQueryData, BarcodeQueryData barcodeQueryData)
        {
            this.searchQueryData = searchQueryData;
            this.barcodeQueryData = barcodeQueryData;
        }

        internal async Task<IResponseData> CreateQuery(string barcode = null, string search = null)
        {
            if (barcode == null)
            {
                QuerySearchInput(search);
                return await requestSender.HttpRequestAsync(searchQueryData: searchQueryData, barcodeQueryData: null);
            }
            else
            {
                QueryBarcodeInput(barcode);
                return await requestSender.HttpRequestAsync(searchQueryData: null, barcodeQueryData: barcodeQueryData);
            }
        }
        private void QueryBarcodeInput(string barcode)
        {
            barcodeQueryData.barcode = barcode;
            barcodeQueryData.type = "card";
        }
        private void QuerySearchInput(string search)
        {
            searchQueryData.search = search;
            searchQueryData.type = "search";
            searchQueryData.version = "v.1.2.4";
            searchQueryData.appPlatform = "AND";
        }
    }
}
