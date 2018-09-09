using Newtonsoft.Json;
using ShopifyApiData.Models.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.ViewModel
{
  public class Products
  {
    [JsonProperty("products")]
    public List<Product> Product { get; set; }
  }
}
