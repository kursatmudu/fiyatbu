using FiyatBu.Interfaces;
using FiyatBu.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace FiyatBu
{
    public class HttpRequestSender
    {
        private static readonly HttpClient client = new HttpClient();
        internal async Task<IResponseData> HttpRequestAsync(SearchQueryData searchQueryData = null, BarcodeQueryData barcodeQueryData = null)
        {
            if (searchQueryData != null)
            {
                FormUrlEncodedContent content = new FormUrlEncodedContent(searchQueryData.ToDictionary());
                HttpResponseMessage response = await client.PostAsync("https://fiyatbu.benimpos.com/fiyatbuApp/searchProduct.php", content);
                string responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Products>(responseString);
            }
            else if (barcodeQueryData != null)
            {
                FormUrlEncodedContent content = new FormUrlEncodedContent(barcodeQueryData.ToDictionary());
                HttpResponseMessage response = await client.PostAsync("https://fiyatbu.benimpos.com/fiyatbuApp/getProduct.php", content);
                string responseString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<Products>(responseString);
            }
            else
            {
                string response = await client.GetStringAsync("https://fiyatbu.benimpos.com/bsAndroid/getSessionID.php");
                return JsonConvert.DeserializeObject<Session>(response);
            }
        }
    }
}
