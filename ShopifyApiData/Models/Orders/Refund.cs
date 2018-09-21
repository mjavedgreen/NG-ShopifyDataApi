using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Orders
{
  public class Refund
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("order_id")]
    public string OrderId { get; set; }
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonProperty("note")]
    public string Note { get; set; }
    [JsonProperty("user_id")]
    public string UserId { get; set; }
    [JsonProperty("processed_at")]
    public DateTime ProcessedAt { get; set; }
    
    [JsonProperty("restock")]
    public bool Restock { get; set; }
    [JsonProperty("refund_line_items")]
    public RefundLineItem[] RefundLineItems { get; set; }


  }

  public class RefundLineItem
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("quantity")]
    public string Quantity { get; set; }
    [JsonProperty("line_item_id")]
    public string LineItemId { get; set; }
    [JsonProperty("location_id")]
    public string LocationId { get; set; }
    [JsonProperty("restock_type")]
    public string RestockType { get; set; }
    [JsonProperty("subtotal")]
    public string Subtotal { get; set; }
    [JsonProperty("total_tax")]
    public string TotalTax { get; set; }
    [JsonProperty("line_item")]
    public LineItem[] LineItems { get; set; }
    [JsonProperty("transactions")]
    public Transaction[] Transactions { get; set; }
    [JsonProperty("order_adjustments")]
    public string[] OrderAdjustments { get; set; }


  }

  public class Transaction {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("order_id")]
    public string OrderId { get; set; }
    [JsonProperty("amount")]
    public string Amount { get; set; }
    [JsonProperty("kind")]
    public string Kind { get; set; }
    [JsonProperty("gateway")]
    public string Gateway { get; set; }
    [JsonProperty("status")]
    public string Status { get; set; }
    [JsonProperty("message")]
    public string Message { get; set; }
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonProperty("test")]
    public bool Test { get; set; }
    [JsonProperty("authorization")]
    public string Authorization { get; set; }
    [JsonProperty("currency")]
    public string Currency { get; set; }
    [JsonProperty("location_id")]
    public string LocationId { get; set; }
    [JsonProperty("user_id")]
    public string UserId { get; set; }
    [JsonProperty("parent_id")]
    public string ParentId { get; set; }
    [JsonProperty("device_id")]
    public string DeviceId { get; set; }
    [JsonProperty("receipt")]
    public Receipt Receipt { get; set; }
    [JsonProperty("id")]
    public string ErrorCode { get; set; }
    [JsonProperty("id")]
    public string SourceName { get; set; }
  }

  public class Receipt
  {
    [JsonProperty("status")]
    public string Status { get; set; }
    [JsonProperty("errors")]
    public string Errors { get; set; }
    [JsonProperty("authorization_result")]
    public string AuthorizationResult { get; set; }
    [JsonProperty("test")]
    public string Test { get; set; }
    [JsonProperty("customercode")]
    public string CustomerCode { get; set; }
    [JsonProperty("settlement_batch_date")]
    public DateTime SettlementBatchDate { get; set; }
    [JsonProperty("settlement_date")]
    public DateTime SettlementDate { get; set; }
    [JsonProperty("transaction_id")]
    public string TransactionId { get; set; }
  }
}

