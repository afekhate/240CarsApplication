using AutoMapper;
using FredCars.Domain.Entities;
using FredCars.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FredCars.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Car, CarsDTO>();
            Mapper.CreateMap<CarsDTO, Car>();

        }
    }
}