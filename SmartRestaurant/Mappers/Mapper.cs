﻿using AutoMapper;
using SmartRestaurant.Model;
using SmartRestaurant.Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartRestaurant.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Korisnici, KorisniciVM>().ReverseMap();
            CreateMap<Korisnici, InsertNovogKorisnikaVM>().ReverseMap();
            CreateMap<Narudzba, IspisNarudzbi>().ReverseMap();
        }
    }
}
