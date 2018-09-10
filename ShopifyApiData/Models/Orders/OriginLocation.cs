using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Orders
{
  public class OriginLocation
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("country_code")]
    public string CountryCode { get; set; }
    [JsonProperty("province_code")]
    public string ProvinceCode { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("address1")]
    public string Address1 { get; set; }
    [JsonProperty("address2")]
    public string Address2 { get; set; }
    [JsonProperty("city")]
    public string City { get; set; }
    [JsonProperty("zip")]
    public string Zip { get; set; }

  }
}
