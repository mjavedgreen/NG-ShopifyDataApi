using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace ShopifyData.Core
{
  public static   class ShopifyResponse
  {
    public static T gethttpResponse<T>(Uri url,string input) where T : class
    {
      HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url+input);
      req.Method = "GET";
      req.ContentType = "application/json";
      //req.Headers.Add("X-Shopify-Access-Token", APISecrateKey);
      req.Credentials = new NetworkCredential("8f1814591b650441af166fff21eedd2e", "8ed8d6d70fe5c6c5e705a4454d3f79c0");
      string text = string.Empty;
      var response = (HttpWebResponse)req.GetResponse();
      var stringResponse = new StreamReader(response.GetResponseStream());
      text = stringResponse.ReadToEnd();
      var abc = JsonConvert.DeserializeObject(text);
      return (T)abc;

    }
  }
}
