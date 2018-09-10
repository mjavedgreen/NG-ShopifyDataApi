using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Orders
{
  public class LineItem
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("variant_id")]
    public string VariantId { get; set; }
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("quantity")]
    public string Quantity { get; set; }
    [JsonProperty("price")]
    public string Price { get; set; }
    [JsonProperty("sku")]
    public string SKU { get; set; }
    [JsonProperty("variant_title")]
    public string VariantTitle { get; set; }
    [JsonProperty("vendor")]
    public string Vendor { get; set; }
    [JsonProperty("fulfillment_service")]
    public string FulfillmentService { get; set; }
    [JsonProperty("product_id")]
    public string ProductId { get; set; }
    [JsonProperty("requires_shipping")]
    public bool RequiresShipping { get; set; }
    [JsonProperty("taxable")]
    public bool Taxable { get; set; }
    [JsonProperty("gift_card")]
    public bool GiftCard { get; set; }
    [JsonProperty("pre_tax_price")]
    public string PreTaxPrice { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("variant_inventory_management")]
    public string VariantInventoryManagement { get; set; }
    [JsonProperty("properties")]
    public Properties[] Properties { get; set; }
    [JsonProperty("product_exists")]
    public bool ProductExists { get; set; }
    [JsonProperty("fulfillable_quantity")]
    public string FulfillableQuantity { get; set; }
    [JsonProperty("grams")]
    public string Grams { get; set; }
    [JsonProperty("total_discount")]
    public string TotalDiscount { get; set; }
    [JsonProperty("fulfillment_status")]
    public string FulfillmentStatus { get; set; }
    [JsonProperty("discount_allocations")]
    public string[] DiscountAllocations { get; set; }
    [JsonProperty("tax_lines")]
    public string[] TaxLines { get; set; }
    [JsonProperty("origin_location")]
    public OriginLocation OriginLocations { get; set; }




  }
}
