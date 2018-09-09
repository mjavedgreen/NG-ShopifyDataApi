using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Net.Http.Headers;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using ShopifyApiData.Models;

namespace ShopifyApiData.Controllers
{
  public class HomeController : Controller
  {
    private string BaseUrl = "https://8f1814591b650441af166fff21eedd2e:8ed8d6d70fe5c6c5e705a4454d3f79c0@skfdev.myshopify.com/";
    Uri BaseUri = new Uri("https://8f1814591b650441af166fff21eedd2e:8ed8d6d70fe5c6c5e705a4454d3f79c0@skfdev.myshopify.com/admin/customers.json");
    public  ActionResult IndexAsync()
    {

      var a = gethttpResponse(BaseUri);
      List<Customer> customers = a.Customer.ToList();

      return View(customers);
    }
    public static Customers gethttpResponse(Uri url)
    {
      HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
      req.Method = "GET";
      req.ContentType = "application/json";
      //req.Headers.Add("X-Shopify-Access-Token", APISecrateKey);
      req.Credentials = new NetworkCredential("8f1814591b650441af166fff21eedd2e", "8ed8d6d70fe5c6c5e705a4454d3f79c0");
      string text = string.Empty;
      
      
        var response = (HttpWebResponse)req.GetResponse();
        var stringResponse = new StreamReader(response.GetResponseStream());
        text = stringResponse.ReadToEnd();
        var abc = JsonConvert.DeserializeObject<Customers>(text);
      return abc;
      //using (var sr = new StreamReader(response.GetResponseStream()))
      //{
      //  text = sr.ReadToEnd();
      //  var def = JsonConvert.DeserializeObject(text);
      // var abc = JsonConvert.DeserializeObject<Customers>(text);

      //}
   // }
      //catch (Exception a)
      //{
      //  //Utility.LogMessage(a.ToString());
      //}
      
      // return text;
    }
    public ActionResult About()
    {
      ViewBag.Message = "Your application description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}
