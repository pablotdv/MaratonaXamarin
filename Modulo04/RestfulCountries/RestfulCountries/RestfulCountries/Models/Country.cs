using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulCountries.Models
{
    public class Country
    {
        public string Name { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public int Population { get; set; }
        public string NativeName { get; set; }
        public string Alpha2Code { get; set; }
        public string Demonym { get; set; }
    }
}
