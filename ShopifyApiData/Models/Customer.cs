using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models
{

  public enum CustomerState
  {
    enabled,
    disabled
  }
  
  public class Customer
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("email")]
    public string Email { get; set; }
    [JsonProperty("accepts_marketing")]
    public bool AcceptsMarketing { get; set; }
    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }
    [JsonProperty("updated_at")]
    public DateTime UpdateAt { get; set; }
    [JsonProperty("first_name")]
    public string FirstName { get; set; }
    [JsonProperty("last_name")]
    public string LastName { get; set; }
    [JsonProperty("orders_count")]
    public int OrderCount { get; set; }
    [JsonProperty("state")]
    public CustomerState state { get; set; }
    [JsonProperty("total_spent")]
    public decimal TotalSpent { get; set; }
    [JsonProperty("last_order_id")]
    public string LastOrderId { get; set; }
    [JsonProperty("note")]
    public string Note { get; set; }
    [JsonProperty("verified_email")]
    public bool VerifiedEmail { get; set; }
    [JsonProperty("multipass_identifier")]
    public string MultipassIdentifier { get; set; }
    [JsonProperty("tax_exempt")]
    public bool TaxExempt { get; set; }
    [JsonProperty("phone")]
    public string Phone { get; set; }
    [JsonProperty("tags")]
    public string Tags { get; set; }
    [JsonProperty("last_order_name")]
    public string LastOrderName { get; set; }
    [JsonProperty("addresses")]
    public List<Address> Addresses { get; set; }
    [JsonProperty("default_address")]
    public Address DefaultAddress { get; set; }


  }
}
