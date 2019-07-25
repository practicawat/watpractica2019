using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Models
{
    public class SearchedCar
    {
        [Key]
        public string IdSearchedCar { get; set; }
        public string selectedCity { get; set; }
        public string selectedPickupHour { get; set; }
        public string selectedReturnHour { get; set; }
        public string selectedPickupPeriod { get; set; }
        public string selectedReturnPeriod { get; set; }
        public string concatenatePickup { get; set; }
        public string concatenateReturn { get; set; }
        public bool IsChecked { get; set; }
    }
}
