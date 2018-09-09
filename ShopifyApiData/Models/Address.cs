using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models
{
  public class Address
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("customer_id")]
    public string CustomerId { get; set; }
    [JsonProperty("first_name")]
    public string FirstName { get; set; }
    [JsonProperty("last_name")]
    public string LastName { get; set; }
    [JsonProperty("company")]
    public string Company { get; set; }
    [JsonProperty("address1")]
    public string AddressOne { get; set; }
    [JsonProperty("address2")]
    public string AddressTwo { get; set; }
    [JsonProperty("city")]
    public string City { get; set; }
    [JsonProperty("province")]
    public string Province { get; set; }
    [JsonProperty("country")]
    public string Country { get; set; }
    [JsonProperty("zip")]
    public string ZipCode { get; set; }
    [JsonProperty("phone")]
    public string Phone { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("province_code")]
    public string ProvinceCode { get; set; }
    [JsonProperty("country_code")]
    public string CountryCode { get; set; }
    [JsonProperty("country_name")]
    public string CountryName { get; set; }
    [JsonProperty("default")]
    public bool Default { get; set; }

  }
}
