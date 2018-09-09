using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Products
{
  public class Images
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("product_id")]
    public string ProductId { get; set; }
    [JsonProperty("position")]
    public int Position { get; set; }
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }
    [JsonProperty("alt")]
    public string Alt { get; set; }
    [JsonProperty("width")]
    public string Width { get; set; }
    [JsonProperty("height")]
    public string Height { get; set; }
    [JsonProperty("src")]
    public string Source { get; set; }
    [JsonProperty("variant_ids")]
    public string[] VariantId { get; set; }
  }
}
