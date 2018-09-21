using ShopifyApiData.AddOn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopifyApiData.Controllers
{
    public class ShopifyTwoController : Controller
    {
        // GET: ShopifyTwo
        public string Index()
        {
            ShopifyApi shopifyApi = new ShopifyApi("8f1814591b650441af166fff21eedd2e", "8ed8d6d70fe5c6c5e705a4454d3f79c0", "skfdev.myshopify.com");
            var a = shopifyApi.Get("products.json");
      string content = "{"+"\"id\":910958329899,"+"\"email\":\"itsSchwarzeneggeronly@gmail.com\","+"\"accepts_marketing\":false" +" }";
      shopifyApi.Post("customers.json", content);
        //"\"created_at\":\"2018 - 08 - 16T10: 27:41 - 04:00\",\"updated_at\":\"2018 - 08 - 16T10: 27:41 - 04:00\",\"first_name\":\"Arnold\",\"last_name\":\"Schwarzenegger\",\"orders_count\":0,\"state\":\"disabled\",\"total_spent\":\"0.00\",\"last_order_id\":null,\"note\":null,\"verified_email\":true,\"multipass_identifier\":null,\"tax_exempt\":false,\"phone\":null,\"tags\":\"[]\",\"last_order_name\":null,\"addresses\":[{\"id\":950116188203,\"customer_id\":910958329899,\"first_name\":\"Arnold\",\"last_name\":\"Schwarzenegger\",\"company\":null,\"address1\":\"1211 - 100 graydonm hall drive\",\"address2\":"",\"city\":\"toronto\",\"province\":\"Ontario\",\"country\":\"Canada\",\"zip\":\"M3A3A8\",\"phone\":null,\"name\":\"Arnold Schwarzenegger\",\"province_code\":\"ON\",\"country_code\":\"CA\",\"country_name\":\"Canada\",\"default\":false},{\"id\":950116220971,\"customer_id\":910958329899,\"first_name\":\"Arnold\",\"last_name\":\"Schwarzenegger\",\"company\":null,\"address1\":\"1211 - 100 graydon hall drive\",\"address2\":"",\"city\":\"toronto\",\"province\":\"Ontario\",\"country\":\"Canada\",\"zip\":\"M3A3A8\",\"phone\":null,\"name\":\"Arnold Schwarzenegger\",\"province_code\":\"ON\",\"country_code\":\"CA\",\"country_name\":\"Canada\",\"default\":true}],\"default_address\":{\"id\":950116220971,\"customer_id\":910958329899,\"first_name\":\"Arnold\",\"last_name\":\"Schwarzenegger\",\"company\":null,\"address1\":\"1211 - 100 graydon hall drive\",\"address2\":"",\"city\":\"toronto\",\"province\":\"Ontario\",\"country\":\"Canada\",\"zip\":\"M3A3A8\",\"phone\":null,\"name\":\"Arnold Schwarzenegger\",\"province_code\":\"ON\",\"country_code\":\"CA\",\"country_name\":\"Canada\",\"default\":true}}";
            return a.ToString();
        }
    }
}
