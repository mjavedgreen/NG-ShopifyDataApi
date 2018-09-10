using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopifyApiData.Models.Orders
{
  public class ClientDetails
  {
    [JsonProperty("browser_ip")]
    public string BrowserIp { get; set; }
    [JsonProperty("accept_language")]
    public string AcceptLanguage { get; set; }
    [JsonProperty("user_agent")]
    public string UserAgent { get; set; }
    [JsonProperty("session_hash")]
    public string SessionHash { get; set; }
    [JsonProperty("browser_width")]
    public string BrowserWidth { get; set; }
    [JsonProperty("browser_height")]
    public string BrowserHeight { get; set; }
  }
}
