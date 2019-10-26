using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using RestSharp;

namespace TaskManagementAPITestAutomation.Hooks
{
    public class Context
    {
        string baseUrl = ConfigurationManager.AppSettings["baseUrl"];
        public string content = string.Empty;
        public string statusCode = string.Empty;
        public string responseDescription = string.Empty;

        public void GetHttpMethod(string resource)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.GET);
            var result = client.Execute(request);

            content = result.Content;
            statusCode = result.StatusCode.ToString();
            responseDescription = result.StatusDescription;
        }

        public void PostHttpMethod(string resource, Dictionary<string, string> dataToPost)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(dataToPost);
            request.AddHeader("Content-Type", "application/json");
            var result = client.Execute(request);

            statusCode = result.StatusCode.ToString();
            responseDescription = result.StatusDescription;
        }

        public void PutHttpMethod(string resource, Dictionary<string, string> dataToPut)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.PUT);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(dataToPut);
            request.AddHeader("Content-Type", "application/json");
            var result = client.Execute(request);

            statusCode = result.StatusCode.ToString();
            responseDescription = result.StatusDescription;
        }

        public void DeleteHttpMethod(string resource)
        {
            var client = new RestClient(baseUrl);
            var request = new RestRequest(resource, Method.DELETE);
            var result = client.Execute(request);

            statusCode = result.StatusCode.ToString();
            responseDescription = result.StatusDescription;
        }
    }
}
