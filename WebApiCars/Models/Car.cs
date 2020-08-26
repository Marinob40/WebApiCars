using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCars.Models
{
    public class Car
    {
        /// <summary>
        /// ID of car object
        /// </summary>
        public int ID { get; set; } = 0;
        /// <summary>
        /// Make of car
        /// </summary>
        public string Make { get; set; } = "";
        /// <summary>
        /// model of car
        /// </summary>
        public string Model { get; set; } = "";

    }
}