using FredCars.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FredCars.ViewModel
{
    public class CarsFormViewModel
    {
        public IEnumerable<Manufacturer> Manufacturer { get; set; }
        public Car Car { get; set; }

    }
}