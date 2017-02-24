using Licao05.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Licao05.Services
{
    public class RestClient
    {
        public string Serialize()
        {
            var countries = new[]
            {
                new Country { Name= "México"},
                new Country { Name="Costa Rica" }
            };

            string json = JsonConvert.SerializeObject(countries);

            Debug.WriteLine(json);

            return json;
        }

        public void Deserialize()
        {

            var json = Serialize();

            var parsedJson = JsonConvert.DeserializeObject<IEnumerable<Country>>(json);

            foreach (var item in parsedJson)
            {
                Debug.WriteLine(item.Name);
            }
        }


        public async Task<IEnumerable<Country>> GetCountries()
        {
            var countries = await GetAsJson().ConfigureAwait(false);

            return countries;
        }

        protected string BaseUrl { get; set; } = "http://restcountries.eu/rest/v1";

        protected async Task<IEnumerable<Country>> GetAsJson()
        {
            var result = Enumerable.Empty<Country>();

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await httpClient.GetAsync(BaseUrl).ConfigureAwait(false);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        result = await Task.Run(() =>
                        {
                            return JsonConvert.DeserializeObject<IEnumerable<Country>>(json);
                        }).ConfigureAwait(false);
                    }
                }
            }

            return result;
        }

    }
}
