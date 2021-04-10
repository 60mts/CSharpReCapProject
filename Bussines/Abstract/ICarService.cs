using reCapProjectt.DataAcces.Abstract;
using reCapProjectt.Entities.Conncrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace reCapProjectt.Bussines.Abstract
    {
    public interface ICarService
        {
        List<Car> GetAll();
        List<Car> GetByCarBrandId(int brandId);
        List<Car> GetByColorId(int colorId);
        List<Car> GetByUnitPrice(int dailyPrice);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    
        }
    }
