namespace CarRentalApp.Models
{
    public class Car
    {
        
            private string brand { get; set; }
            private string model { get; set; }
            private short nrOfDoors { get; set; }
            private string licensePlate { get; set; }
            private short nrOfSeats { get; set; }
            private bool hasAutomaticGearbox { get; set; }
            private float pricePerDay { get; set; }

            public Car(string brand, string model, short nrOfDoors, string licensePlaye, short nrOfSeats, bool hasAutomaticGearbox, float pricePerDay)
            {
                this.brand = brand;
                this.model = model;
                this.nrOfDoors = nrOfDoors;
                this.licensePlate = licensePlate;
                this.nrOfSeats = nrOfSeats;
                this.hasAutomaticGearbox = hasAutomaticGearbox;
                this.pricePerDay = pricePerDay;
            }

        
    }
}
