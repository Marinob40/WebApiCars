using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiCars.Models;

namespace WebApiCars.Controllers
{
    public class CarController : ApiController
    {
        List<Car> cars = new List<Car>();

        /// <summary>
        /// Adds the car values to a list
        /// </summary>
        public CarController()
        {
            cars.Add(new Car { ID = 1, Make = "Nissan", Model = "Maxima" });
            cars.Add(new Car { ID = 2, Make = "Ford", Model = "Focus" });
            cars.Add(new Car { ID = 3, Make = "Honda", Model = "Civic" });
        }

        // GET: api/Car
        /// <summary>
        /// Gets the list of cars
        /// </summary>
        /// <returns></returns>
        public List<Car> Get()
        {
            return cars;
        }

        /// <summary>
        /// This will return a list of car makes
        /// </summary>
        /// <returns></returns>  
        [Route("api/cars/GetMakes")]
        [HttpGet]
        public List<string> GetMakes()
        {
            List<string> output = new List<string>();

            foreach (var car in cars)
            {
                output.Add(car.Make);
            }
            return output;
        }

        // GET: api/Car/5
        /// <summary>
        /// Gets a car by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Car Get(int id)
        {
            return cars.Where(x => x.ID == id).FirstOrDefault();
        }

        // POST: api/Car
        /// <summary>
        /// Adds a car to the list
        /// </summary>
        /// <param name="val"></param>
        public void Post(Car val)
        {
            cars.Add(val);
        }

        // PUT: api/Car/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Car/5
        public void Delete(int id)
        {
        }
    }
}
