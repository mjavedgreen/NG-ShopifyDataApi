using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Products
{
  public class Product
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("body_html")]
    public string BodyHtml { get; set; }
    [JsonProperty("vendor")]
    public string Vendor { get; set; }
    [JsonProperty("product_type")]
    public string ProductType { get; set; }
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonProperty("handle")]
    public string Handle { get; set; }
    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }
    [JsonProperty("published_at")]
    public DateTime PublishedAt { get; set; }
    [JsonProperty("template_suffix")]
    public string TemplateSuffix { get; set; }
    [JsonProperty("tags")]
    public string Tags { get; set; }
    [JsonProperty("published_scope")]
    public string PublishedScope { get; set; }
    [JsonProperty("variants")]
    public Variant[] Variants { get; set; }
    [JsonProperty("options")]
    public List<Options> Options { get; set; }
    [JsonProperty("images")]
    public List<Images> Images { get; set; }

  }
}
