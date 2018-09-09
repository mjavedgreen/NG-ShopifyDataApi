using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.ViewModel
{
  public class Customers
  {
    [JsonProperty("customers")]
    public List<Customer> Customer { get; set; }
  }
}
