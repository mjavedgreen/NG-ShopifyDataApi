using Newtonsoft.Json;
using ShopifyApiData.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.ViewModel
{
  public class Orders
  {
    [JsonProperty("orders")]
    public List<Order> Order { get; set; }
  }
}
