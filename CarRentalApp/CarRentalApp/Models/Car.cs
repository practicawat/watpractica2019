using System.Web;
namespace CarRentalApp.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Name { get; set; }        
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public float Price { get; set; }
    }
}
