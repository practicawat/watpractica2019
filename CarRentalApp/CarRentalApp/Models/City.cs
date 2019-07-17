using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Models
{
    public class City
    {
        [Key]
        public int IDCity { get; set; }
        public string CityName { get;  set; }
        public string CountyName { get;  set; }

        public City(int id, string nameCity, string nameCounty)
        {
            this.IDCity = id;
            this.CityName = nameCity;
            this.CountyName = nameCounty;
        }

        public City() { }

    }
}
