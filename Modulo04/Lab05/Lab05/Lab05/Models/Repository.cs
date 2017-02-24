using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lab05.Models
{
    public class Repository
    {
        public async Task<List<Cat>> GetCats()
        {
            List<Cat> cats;

            var URLWebAPI = "http://demos.ticapacitacion.com/cats";
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(URLWebAPI);

                cats = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Cat>>(json);
            }

            return cats;
        }
    }
}
