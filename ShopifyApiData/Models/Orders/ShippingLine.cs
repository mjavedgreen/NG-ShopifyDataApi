using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Orders
{
  public class ShippingLine
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("title")]
    public string Title { get; set; }
    [JsonProperty("price")]
    public string Price { get; set; }
    [JsonProperty("code")]
    public string Code { get; set; }
    [JsonProperty("source")]
    public string Source { get; set; }
    [JsonProperty("phone")]
    public string Phone { get; set; }
    [JsonProperty("requested_fulfillment_service_id")]
    public string RequestedFulfillmentServiceId { get; set; }
    [JsonProperty("delivery_category")]
    public string DeliveryCategory { get; set; }
    [JsonProperty("carrier_identifier")]
    public string CarrierIdentifier { get; set; }
    [JsonProperty("discounted_price")]
    public string DiscountedPrice { get; set; }
    [JsonProperty("discount_allocations")]
    public string[] DiscountAllocations { get; set; }
    [JsonProperty("tax_lines")]
    public string[] TaxLines { get; set; }



  }
}
