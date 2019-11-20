using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FredCars.Dtos
{
    public class CarsDTO
    {
        public int CarID { get; set; }

        public string Name { get; set; }

        public Decimal Price { get; set; }
        public string ImagePath { get; set; }

        public int Rating { get; set; }

        public string Carmodel { get; set; }

    }
}