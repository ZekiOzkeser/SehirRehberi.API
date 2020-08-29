﻿using System;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SehirRehberi.API.Models;

namespace SehirRehberi.API.Data
{
   public interface IAppRepository
   {
       void Add<T>(T entity) where T:class;
       void Delete<T>(T entity) where T: class;
       bool SaveAll();

       List<City> GetCities();
       List<Photo> GetPhotosCity(int id);
       City GetCityById(int cityId);

       Photo GetPhoto(int id);

   }
}
