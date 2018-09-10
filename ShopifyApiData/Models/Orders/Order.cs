using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Orders
{
  public class Order
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("email")]
    public string Email { get; set; }
    [JsonProperty("closed_at")]
    public DateTime? ClosedAt { get; set; }
    [JsonProperty("created_at")]
    public DateTime? CreatedAt { get; set; }
    [JsonProperty("updated_at")]
    public DateTime? UpdatedAt { get; set; }
    [JsonProperty("number")]
    public string Number { get; set; }
    [JsonProperty("note")]
    public string Note { get; set; }
    [JsonProperty("token")]
    public string Token { get; set; }
    [JsonProperty("gateway")]
    public string Gateway { get; set; }
    [JsonProperty("test")]
    public bool Test { get; set; }
    [JsonProperty("total_price")]
    public string TotalPrice { get; set; }
    [JsonProperty("subtotal_price")]
    public string SubtotalPrice { get; set; }
    [JsonProperty("total_weight")]
    public string TotalWeight { get; set; }
    [JsonProperty("total_tax")]
    public string TotalTax { get; set; }
    [JsonProperty("taxes_included")]
    public bool TaxesIncluded { get; set; }
    [JsonProperty("currency")]
    public string Currency { get; set; }
    [JsonProperty("financial_status")]
    public string FinancialStatus { get; set; }
    [JsonProperty("confirmed")]
    public bool Confirmed { get; set; }
    [JsonProperty("total_discounts")]
    public string TotalDiscount { get; set; }
    [JsonProperty("total_line_items_price")]
    public string TotalLineItemPrice { get; set; }
    [JsonProperty("cart_token")]
    public string CartToken { get; set; }
    [JsonProperty("buyer_accepts_marketing")]
    public bool BuyerAcceptsMarketing { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("referring_site")]
    public string ReferringSite { get; set; }
    [JsonProperty("landing_site")]
    public string LandingSite { get; set; }
    [JsonProperty("cancelled_at")]
    public string CancelledAt { get; set; }
    [JsonProperty("cancel_reason")]
    public string CancelReason { get; set; }
    [JsonProperty("total_price_usd")]
    public string TotalPriceUSD { get; set; }
    [JsonProperty("checkout_token")]
    public string CheckOutToken { get; set; }
    [JsonProperty("reference")]
    public string Reference { get; set; }
    [JsonProperty("user_id")]
    public string UserId { get; set; }
    [JsonProperty("location_id")]
    public string LocationId { get; set; }
    [JsonProperty("source_identifier")]
    public string SourceIdentifier { get; set; }
    [JsonProperty("source_url")]
    public string SourceUrl { get; set; }
    [JsonProperty("processed_at")]
    public DateTime ProcessedAt { get; set; }
    [JsonProperty("device_id")]
    public string DeviceId { get; set; }
    [JsonProperty("phone")]
    public string Phone { get; set; }
    [JsonProperty("customer_locale")]
    public string CustomerLocale { get; set; }
    [JsonProperty("app_id")]
    public string AppId { get; set; }
    [JsonProperty("browser_ip")]
    public string BrowserIp { get; set; }
    [JsonProperty("landing_site_ref")]
    public string LandingSiteRef { get; set; }
    [JsonProperty("order_number")]
    public string OrderNumber { get; set; }
    [JsonProperty("discount_applications")]
    public string[] DiscountApplications { get; set; }
    [JsonProperty("discount_codes")]
    public string[] DiscountCodes { get; set; }
    [JsonProperty("note_attributes")]
    public Properties[] NoteAttributes { get; set; }
    [JsonProperty("payment_gateway_names")]
    public string[] PaymentGatewayNames { get; set; }
    [JsonProperty("processing_method")]
    public string ProcessingMethod { get; set; }
    [JsonProperty("checkout_id")]
    public string CheckoutId { get; set; }
    [JsonProperty("source_name")]
    public string SourceName { get; set; }
    [JsonProperty("fulfillment_status")]
    public string FulfillmentStatus { get; set; }
    [JsonProperty("tax_lines")]
    public string[] TaxLines { get; set; }
    [JsonProperty("tags")]
    public string Tags { get; set; }
    [JsonProperty("contact_email")]
    public string ContactEmail { get; set; }
    [JsonProperty("order_status_url")]
    public string OrderStatusUrl { get; set; }
    [JsonProperty("total_tip_received")]
    public string TotalTipReceived { get; set; }
    [JsonProperty("line_items")]
    public LineItem[] LineItems { get; set; }
    [JsonProperty("shipping_lines")]
    public ShippingLine[] ShippingLines { get; set; }
    [JsonProperty("billing_address")]
    public OrdersAddress BillingAddress { get; set; }
    [JsonProperty("shipping_address")]
    public OrdersAddress ShippingAddress { get; set; }
    [JsonProperty("fulfillments")]
    public string[] Fulfillments { get; set; }
    [JsonProperty("client_details")]
    public ClientDetails ClientDetails { get; set; }
    [JsonProperty("refunds")]
    public string[] Refunds { get; set; }
    [JsonProperty("payment_details")]
    public PaymentDetails PaymentDetails { get; set; }
    [JsonProperty("customer")]
    public Customer Customer { get; set; }




  }
}
