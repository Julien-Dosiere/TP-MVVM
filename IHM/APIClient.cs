using IHM.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IHM
{

    class APIClient
    {
        private string URL = ConfigurationManager.AppSettings["url_api"];
        private const string urlParameters = "";

        public List<Demande> GetDemandes()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            client.Dispose();
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var dataObjects = response.Content.ReadAsAsync<IEnumerable<Demande>>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                //var dataObject = response.Content.ReadAsAsync<DataObject>().Result;  //Make sure to add a reference to System.Net.Http.Formatting.dll
                //foreach (var d in dataObjects)
                //{
                //    Console.WriteLine("{0}", d.Name);
                //}
                return dataObjects.ToList();

            }
            else
            {

                return null;
            }

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.

        }
        public bool PostDemande(Demande demande)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            var content = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("Motif", demande.Motif),
                new KeyValuePair<string, string>("Info", "ok"),
                new KeyValuePair<string, string>("Email", demande.Email),
                new KeyValuePair<string, string>("IdSalarie", "1"),
            });

            HttpResponseMessage response = client.PostAsync(urlParameters,content).Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            
            client.Dispose();
            if (response.StatusCode == System.Net.HttpStatusCode.Created)
                return true;
            else
                return false;
            //if (response.StatusCode == "201")
            //    return true;

            // Make any other calls using HttpClient here.

            // Dispose once all HttpClient calls are complete. This is not necessary if the containing object will be disposed of; for example in this case the HttpClient instance will be disposed automatically when the application terminates so the following call is superfluous.
            
        }
    }
}
