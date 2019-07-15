using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Models
{
    public class City
    {
        public int IDCity { get; private set; }
        public string CityName { get; private set; }
        public string CountyName { get; private set; }

        public City(int id, string nameCity, string nameCounty)
        {
            this.IDCity = id;
            this.CityName = nameCity;
            this.CountyName = nameCounty;
        }
    }
}
