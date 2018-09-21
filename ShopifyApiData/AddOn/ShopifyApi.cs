using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace ShopifyApiData.AddOn
{
  public class ShopifyApi : IDisposable
  {

    private readonly string _apiKey;
    private readonly string _apiPassword;
    private readonly string _hostName;

    public ShopifyApi(string apiKey, string apiPassword, string hostName)
    {
      _apiKey = apiKey;
      _apiPassword = apiPassword;
      _hostName = hostName;
    }


    /// <summary>
    /// Downloads a Shopify resource using the Get verb
    /// </summary>
    public string Get(string resource)
    {
      string url = BuildResourceUrl(resource);

      try
      {
        WebRequest req = WebRequest.Create(url);
        req.Method = "GET";
        req.ContentType = "application/json";
        req.Headers.Add("X-Shopify-Access-Token", _apiPassword);

        WebResponse response = req.GetResponse();

        Stream dataStream = response.GetResponseStream();

        StreamReader reader = new StreamReader(dataStream);

        string responseFromServer = reader.ReadToEnd();

        reader.Close();
        dataStream.Close();
        response.Close();

        return responseFromServer;
      }
      catch (WebException ex)
      {
        string response;

        using (var reader = new System.IO.StreamReader(ex.Response.GetResponseStream()))
        {
          response = reader.ReadToEnd();
        }
        throw ex;
      }


    }

    /// <summary>
    /// Uploads json to a resource using the PUT verb. Used for updating.
    /// </summary>
    public string Put(string resource, string json)
    {
      string url = BuildResourceUrl(resource);

      try
      {
        WebRequest req = WebRequest.Create(url);
        req.Method = "PUT";
        req.ContentType = "application/json";
        req.Headers.Add("X-Shopify-Access-Token", _apiPassword);

        string postData = json;
        byte[] byteArray = Encoding.UTF8.GetBytes(postData);

        req.ContentLength = byteArray.Length;

        Stream dataStream = req.GetRequestStream();

        dataStream.Write(byteArray, 0, byteArray.Length);

        dataStream.Close();

        WebResponse response = req.GetResponse();

        dataStream = response.GetResponseStream();

        StreamReader reader = new StreamReader(dataStream);

        string responseFromServer = reader.ReadToEnd();

        reader.Close();
        dataStream.Close();
        response.Close();

        return responseFromServer;
      }
      catch (WebException ex)
      {
        string response;

        using (var reader = new System.IO.StreamReader(ex.Response.GetResponseStream()))
        {
          response = reader.ReadToEnd();
        }
        throw ex;
      }
    }

    /// <summary>
    /// Uploads json to a resource using the POST verb. Used for create.
    /// </summary>
    public string Post(string resource, string json)
    {
      string url = BuildResourceUrl(resource);

      try
      {
        WebRequest req = WebRequest.Create(url);
        req.Method = "POST";
        req.ContentType = "application/json";
        req.Headers.Add("X-Shopify-Access-Token", _apiPassword);

        string postData = json;
        byte[] byteArray = Encoding.UTF8.GetBytes(postData);

        req.ContentLength = byteArray.Length;

        Stream dataStream = req.GetRequestStream();

        dataStream.Write(byteArray, 0, byteArray.Length);

        dataStream.Close();

        WebResponse response = req.GetResponse();

        dataStream = response.GetResponseStream();

        StreamReader reader = new StreamReader(dataStream);

        string responseFromServer = reader.ReadToEnd();

        reader.Close();
        dataStream.Close();
        response.Close();

        return responseFromServer;
      }
      catch (WebException ex)
      {
        string response;

        using (var reader = new System.IO.StreamReader(ex.Response.GetResponseStream()))
        {
          response = reader.ReadToEnd();
        }
        throw ex;
      }
    }


    /// <summary>
    /// Private method to build the full URL
    /// </summary>
    private string BuildResourceUrl(string query)
    {
      const string urlFormat = "https://{0}:{1}@{2}/admin/{3}";
      return string.Format(urlFormat, _apiKey, _apiPassword, _hostName, query);
    }

    public void Dispose()
    {
      throw new NotImplementedException();
    }
  }
}
