using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalApp.Context;
using CarRentalApp.Models;
using Microsoft.AspNetCore.Cors;
using System.Collections;
using System.IO;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http.Headers;

namespace CarRentalApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarRentalDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;


        public CarsController(CarRentalDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: api/Cars
        [EnableCors("MyPolicy")]
        [HttpGet]
        public IEnumerable<Car> GetCars()
        {
            return _context.Cars.ToArray();
        }

        [HttpGet("{GetRandomCars}")]
        public IEnumerable<Car> GetRandomCars()
        {
            List<Car> randomList = new List<Car>();
            Car[] availableCars = _context.Cars.ToArray();
            int[] indexes = new int[3];

            for (int index = 0; index < 3; ++index)
            {
                Random random = new Random();
                int randIndex;

                // verify if index already exists in index list (indexes)
                bool duplicateIndex = true;
                while (duplicateIndex == true)
                {
                    bool foundIndex = false;
                    randIndex = random.Next(availableCars.Length);
                    for (int ind = 0; ind < indexes.Length; ++ind)
                        if (indexes[ind] == randIndex)
                        {
                            foundIndex = true;
                        }
                    if (foundIndex == false)
                    {
                        indexes[index] = randIndex;
                        randomList.Add(availableCars[randIndex]);
                        duplicateIndex = false;
                    }
                }
            }
            return randomList;
        }

        // GET: api/Cars/5
        [HttpGet("{licensePlate}")]
        public async Task<IActionResult> GetCar([FromRoute] string licensePlate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = await _context.Cars.FindAsync(licensePlate);

            if (car == null)
            {
                return NotFound();
            }

            return Ok(car);
        }

        // PUT: api/Cars/5
        [HttpPut("{licensePlate}")]
        public async Task<IActionResult> PutCar([FromRoute] string licensePlate, [FromBody] Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (licensePlate != car.LicensePlate)
            {
                return BadRequest();
            }

            _context.Entry(car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(licensePlate))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [Route("Uploads")]
        [HttpPost]
        public ActionResult UploadFile(string filee)
        {

            try
            { 
                foreach (var file in Request.Form.Files)
                {
                    string folderName = "C:/temp_Practica_3.1/watpractica2019/CarRentalApp/CarRentalApp/ClientApp/src/assets/Img";
                    string webRootPath = _hostingEnvironment.WebRootPath;
                    string newPath = Path.Combine(webRootPath, folderName);
                    if (!Directory.Exists(newPath))
                    {
                        Directory.CreateDirectory(newPath);
                    }
                    if (file.Length > 0)
                    {
                        string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                        string fullPath = Path.Combine(newPath, fileName);
                        using (var stream = new FileStream(fullPath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                            _context.Images.Add(new Images());
                        }
                    }
                }                
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Cars
        [HttpPost]
        public async Task<IActionResult> PostCar([FromBody] Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            
           
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCar", new { licensePlate = car.LicensePlate }, car);
        }

        // DELETE: api/Cars/5
        [HttpDelete("{licensePlate}")]
        public async Task<IActionResult> DeleteCar([FromRoute] string licensePlate)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var car = await _context.Cars.FindAsync(licensePlate);
            if (car == null)
            {   
                return NotFound();
            }

            _context.Cars.Remove(car);
            await _context.SaveChangesAsync();

            return Ok(car);
        }

        private bool CarExists(string licensePlate)
        {
            return _context.Cars.Any(e => e.LicensePlate == licensePlate);
        }
    }
}