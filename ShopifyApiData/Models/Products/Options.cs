using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Products
{
  public class Options
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("product_id")]
    public string ProductId { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("position")]
    public int Position { get; set; }
    [JsonProperty("values")]
    public string[] Values  { get; set; }
  }
}
