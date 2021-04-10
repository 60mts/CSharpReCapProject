using reCapProjectt.Bussines.Abstract;
using reCapProjectt.DataAcces.Abstract;
using reCapProjectt.DataAcces.Concrete.InMemory;
using reCapProjectt.Entities.Conncrete;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace reCapProjectt.Bussines.Concrete
    {
    public class CarManager : ICarService
        {
        InMemoryCarDal _carDal;
        private CarManager(ICarDal _carDal)
            {
           
            }

        public void Add(Car car)
            {
            _carDal.Add(car);
            }

        public void Delete(Car car)
            {
            _carDal.Delete(car);
            }

        public List<Car> GetAll()
            {
            return _carDal.GetAll();
            }

        public List<Car> GetByCarBrandId(int brandId)
            {
            return _carDal.GetByCarBrandId(c=>brandId == brandId);
            }

        public List<Car> GetByColorId(int colorId)
            {
            return _carDal.GetByColorId(c => colorId == colorId);
            }

        public List<Car> GetByUnitPrice(int dailyPrice)
            {
            return _carDal.GetByUnitPrice(c => dailyPrice == dailyPrice);
            }

        public void Update(Car car)
            {
            _carDal.Update(car);
            }
        }

   
    }
