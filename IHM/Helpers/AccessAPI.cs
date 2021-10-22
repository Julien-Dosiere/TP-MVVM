using IHM.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IHM.Helpers
{
    class AccessAPI
    {
        async static public Task<List<Adresse>> GetAdresses(string query)
        {
            HttpClient client = new HttpClient();

            string URL = ConfigurationManager.AppSettings["url_gouv"];

            string contenuFormatJson = await client.GetStringAsync(URL + query);

            AdresseGouv result = JsonConvert.DeserializeObject<AdresseGouv>(contenuFormatJson);

            List<Adresse> adresses = new List<Adresse>();

            foreach(var item in result.features)
            {
                Adresse adresse = new Adresse();
                adresse.Numero = item.properties.housenumber;
                adresse.Rue = item.properties.name;
                adresse.CodePostal = item.properties.postcode;
                adresse.Ville = item.properties.city;

                adresses.Add(adresse);
            }

            client.Dispose();

            return adresses;
        }
    }
}
