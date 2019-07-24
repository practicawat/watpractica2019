using CarRentalApp.Context;
using CarRentalApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchedCarController : ControllerBase
    {
        private readonly CarRentalDbContext _context;

        public SearchedCarController(CarRentalDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> PostCar([FromBody] SearchedCar searchedCar)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CultureInfo culture = new CultureInfo("en-US");
            DateTime pickupDate = Convert.ToDateTime(searchedCar.concatenatePickup, culture);
            DateTime returnDate = Convert.ToDateTime(searchedCar.concatenateReturn, culture);

            List<Car> availableCars = new List<Car>();

            Car[] allCars = _context.Cars.ToArray();
            Rentals[] allRentals = _context.Rentals.ToArray();

            bool isAvailable;
            for(int indexCar = 0; indexCar < allCars.Length; ++indexCar)
            {
                isAvailable = true;
                for(int indexRentals = 0; indexRentals < allRentals.Length; ++indexRentals)
                    if(allRentals[indexRentals].RegistrationNumber == allCars[indexCar].LicensePlate)
                       if((pickupDate <= allRentals[indexRentals].StartDate && returnDate >= allRentals[indexRentals].StartDate && returnDate <= allRentals[indexRentals].EndDate) ||
                            (pickupDate == allRentals[indexRentals].StartDate && returnDate == allRentals[indexRentals].StartDate) ||
                            (pickupDate >= allRentals[indexRentals].StartDate && pickupDate <= allRentals[indexRentals].EndDate && returnDate >= allRentals[indexRentals].EndDate) ||
                            (pickupDate <= allRentals[indexRentals].StartDate && returnDate >= allRentals[indexRentals].EndDate) ||
                            (pickupDate >= allRentals[indexRentals].StartDate && returnDate <= allRentals[indexRentals].EndDate))
                    {
                            isAvailable = false;
                    }
                if (isAvailable == true)
                    availableCars.Add(allCars[indexCar]);
            }

            return Ok(availableCars);
        }
    }
}
