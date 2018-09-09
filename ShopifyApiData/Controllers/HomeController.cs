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

using ShopifyApiData.Core;
using ShopifyApiData.Models.ViewModel;

namespace ShopifyApiData.Controllers
{
  public class HomeController : Controller
  {
    private string BaseUrl = "https://8f1814591b650441af166fff21eedd2e:8ed8d6d70fe5c6c5e705a4454d3f79c0@skfdev.myshopify.com/";
    Uri BaseUri = new Uri("https://8f1814591b650441af166fff21eedd2e:8ed8d6d70fe5c6c5e705a4454d3f79c0@skfdev.myshopify.com/admin/");
    //private T resultData;
    public  ActionResult IndexAsync()
    {

      var abc = CustomerResponse.gethttpResponse<Customers>(BaseUri,"customers.json");
      //var a =typeof(HomeController).gethttpResponse(BaseUri);
      ////List<Customer> customers = a.Customer.ToList();
      var customers = abc.Customer.ToList();//a.Customer.ToList();
      //return View(customers);
      return View(customers);
    }


    public ActionResult Products()
    {
      var products = CustomerResponse.gethttpResponse<Products>(BaseUri,"products.json");
      var listofProducts = products.Product.ToList();
      return View(listofProducts);
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
