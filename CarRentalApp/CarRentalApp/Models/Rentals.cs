using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Models
{
    public class Rentals
    {
        public int RentalsId { get; set; }
        public string RegistrationNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int InfoUserId { get; set; }
        public int CityStartId { get; set; }
        public int CityEndId { get; set; }

        public Rentals(int rentalsId, string registrationNumber, DateTime startDate, DateTime endDate, int infoUserId, int cityStartId, int cityEndId)
        {
            this.RentalsId = rentalsId;
            this.RegistrationNumber = registrationNumber;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.InfoUserId = infoUserId;
            this.CityStartId = cityStartId;
            this.CityEndId = cityEndId;
        }
    }
}
