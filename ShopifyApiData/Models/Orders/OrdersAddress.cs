using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Orders
{
  public class OrdersAddress : Address
  {
    [JsonProperty("latitude")]
    public string Latitude { get; set; }
    [JsonProperty("longitude")]
    public string Longitude { get; set; }
  }
}
