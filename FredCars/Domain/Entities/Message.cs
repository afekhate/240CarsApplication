using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FredCars.Domain.Entities
{
    public class Message
    {
        public int MessageID { get; set; }
        public string Manufacturer { get; set; }
        public string Carmodel { get; set; }

        [Display(Name = "Email")]
        public string MessageBody { get; set; }

    }
}