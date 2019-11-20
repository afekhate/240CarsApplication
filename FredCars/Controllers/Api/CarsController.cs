using AutoMapper;
using FredCars.Domain.Entities;
using FredCars.Dtos;
using FredCars.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FredCars.Controllers.Api
{
    public class CarsController : ApiController
    {
        private ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public IEnumerable<CarsDTO> GetCars()
        {
            return _context.Car.ToList().Select(Mapper.Map<Car, CarsDTO>);
        }

        [HttpGet]
        public CarsDTO GetCars(int id)
        {
            var car = _context.Car.SingleOrDefault(m => m.CarID == id);
            if (car == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            return Mapper.Map<Car, CarsDTO>(car);
        }

        [HttpDelete]
        public void DeleteCar(int id)
        {
            var carInDb = _context.Car.SingleOrDefault(m => m.CarID == id);
            if (carInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.Car.Remove(carInDb);
            _context.SaveChanges();
        }

        [HttpPut]
        public void UpdateCar(int id, CarsDTO carDTO)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var carInDb = _context.Car.SingleOrDefault(m => m.CarID == id);

            if(carInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(carDTO, carInDb);
            _context.SaveChanges();
        }


        [HttpPost]
        public IHttpActionResult CreateCar(CarsDTO carDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var car = Mapper.Map<CarsDTO, Car>(carDTO);
            _context.Car.Add(car);
            _context.SaveChanges();

            carDTO.CarID = car.CarID;
            return Created(new Uri(Request.RequestUri + "/" + car.CarID), carDTO);
        }
    }
}
