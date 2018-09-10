using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Orders
{
  public class Properties
  {
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("value")]
    public string Value { get; set; }
  }
}
