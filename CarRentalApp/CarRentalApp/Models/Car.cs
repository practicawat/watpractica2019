using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarRentalApp.Models
{
    public class Car 
    {
            [Key]
            public  string LicensePlate { get; set; }
            public  string Brand { get; set; }
            public  string Model { get; set; }
            public  short NrOfDoors { get; set; }
            public  short NrOfSeats { get; set; }
            public  bool HasAutomaticGearbox { get; set; }
            public  float PricePerDay { get; set; }

            public Car(string brand, string model, short nrOfDoors, string licensePlate, short nrOfSeats, bool hasAutomaticGearbox, float pricePerDay)
            {
                this.Brand = brand;
                this.Model = model;
                this.NrOfDoors = nrOfDoors;
                this.LicensePlate = licensePlate;
                this.NrOfSeats = nrOfSeats;
                this.HasAutomaticGearbox = hasAutomaticGearbox;
                this.PricePerDay = pricePerDay;
            }

        
    }
}
