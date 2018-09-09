using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Products
{
  public class Variant
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("product_id")]
    public string ProductId { get; set; }
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("price")]
    public string Price { get; set; }
    [JsonProperty("sku")]
    public string SKU { get; set; }
    [JsonProperty("position")]
    public string Position { get; set; }
    [JsonProperty("inventory_policy")]
    public string InventoryPolicy { get; set; }
    [JsonProperty("compare_at_price")]
    public string CompareAtPrice { get; set; }
    [JsonProperty("fulfillment_service")]
    public string FulfillmentService { get; set; }
    [JsonProperty("inventory_management")]
    public string InventoryManagement { get; set; }
    [JsonProperty("option1")]
    public string Option1 { get; set; }
    [JsonProperty("option2")]
    public string Option2 { get; set; }
    [JsonProperty("option3")]
    public string Option3 { get; set; }
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }
    [JsonProperty("taxable")]
    public string Taxable { get; set; }
    [JsonProperty("barcode")]
    public string Barcode { get; set; }
    [JsonProperty("grams")]
    public string Grams { get; set; }
    [JsonProperty("image_id")]
    public string ImageId { get; set; }
    [JsonProperty("inventory_quantity")]
    public string InventoryQuantity { get; set; }
    [JsonProperty("weight")]
    public string Weight { get; set; }
    [JsonProperty("weight_id")]
    public string WeightId { get; set; }
    [JsonProperty("inventory_item_id")]
    public string InventoryItemId { get; set; }
    [JsonProperty("tax_code")]
    public string TaxCode { get; set; }
    [JsonProperty("old_inventory_quantity")]
    public string OldInventoryQuantity { get; set; }
    [JsonProperty("requires_shipping")]
    public bool RequiresShipping { get; set; }


  }
}
