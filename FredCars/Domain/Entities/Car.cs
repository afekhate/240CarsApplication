using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FredCars.Domain.Entities
{
    public class Car
    {
        public int CarID { get; set; }

        [Display(Name =" Car Model")]
        public string Name { get; set; }

        public Decimal Price { get; set; }
        public string ImagePath { get; set; }

        public int Rating { get; set; }

        [Display(Name ="Year of Production")]
        public string Carmodel { get; set; }

        public int ManufacturerID { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}