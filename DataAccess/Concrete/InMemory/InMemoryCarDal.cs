﻿
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _Cars;

        public InMemoryCarDal()
        {
            _Cars = new List<Car>
            {
                new Car { BrandId = 1, CarId = 1, ColorId = 1, ModelYear = "1999", DailyPrice = 100, Description = "Bu Araç Özel Yapım GTR dır." },
                new Car { BrandId = 2, CarId = 2, ColorId = 2, ModelYear = "2005", DailyPrice = 150, Description = "Bu Araç Audi A3 tür." }
            };
        }

        public void Add(Car car)
        {
            _Cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car result = _Cars.SingleOrDefault(c => c.CarId == car.CarId);
            _Cars.Remove(result);
        }

        public List<Car> GetAll()
        {
            return _Cars;
        }

        public List<Car> GetById(int carId)
        {
            return _Cars.Where(c => c.CarId == carId).ToList();
        }

        public void Update(Car car)
        {
            Car result = _Cars.SingleOrDefault(c => c.CarId == car.CarId);
            result.BrandId = car.BrandId;
            result.ColorId = car.ColorId;
            result.DailyPrice = car.DailyPrice;
            result.Description = car.Description;
            result.ModelYear = car.ModelYear;
        }
    }
}
