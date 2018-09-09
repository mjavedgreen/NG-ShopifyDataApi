using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopifyApiData.Controllers
{
    public class ShopifyController : ApiController
    {

    private string BaseUrl = "https://8f1814591b650441af166fff21eedd2e:8ed8d6d70fe5c6c5e705a4454d3f79c0@skfdev.myshopify.com/admin/orders.json";
        // GET: api/Shopify
        public IEnumerable<string> Get()
        {

      
      return new string[] { "value1", "value2" };
        }

        // GET: api/Shopify/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Shopify
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Shopify/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Shopify/5
        public void Delete(int id)
        {
        }
    }
}
