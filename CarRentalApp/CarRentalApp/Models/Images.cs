using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Models
{
    public class Images
    {
        public int Id { get; set; }
        public Car RelatedCar { get; set; }
        public string Img { get; set; }

       

    }

}
