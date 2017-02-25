using RestfulCountries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulCountries.Services
{
    public class CountryService : PlainRestClient
    {
        protected const string FLAG_SERVICE = "http://www.geognos.com/api/en/countries/flag";

        public CountryService() : base("https://restcountries.eu/rest/v1/all") { }

        public Task<IEnumerable<Country>> GetCountries()
        {
            return GetAsJson<Country>();
        }

        public Uri GetFlagSource(string alpha2Code)
        {
            var uri = new Uri(FromUrl(FLAG_SERVICE, alpha2Code + ".png"));
            return uri;
        }
    }
}
