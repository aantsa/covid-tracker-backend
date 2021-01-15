using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace covid_tracker_backend.Models
{
    public class Country
    {
        public int Confirmed { get; set; }
        public int Recovered { get; set; }
        public int Deaths { get; set; }
        public string CountryName { get; set; }
        public int Population { get; set; }
        public int SqKmArea { get; set; }
        public string LifeExpectancy { get; set; }
        public string Continent { get; set; }
        public string Location { get; set; }
        public string Capital { get; set; }
    }
}
