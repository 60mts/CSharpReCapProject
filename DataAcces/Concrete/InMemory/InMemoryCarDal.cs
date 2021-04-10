using reCapProjectt.DataAcces.Abstract;
using reCapProjectt.Entities.Conncrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace reCapProjectt.DataAcces.Concrete.InMemory
    {
    public class InMemoryCarDal
        {
        List<Car> _cars;
        public InMemoryCarDal()
            {

            _cars = new List<Car> { 
                new Car{Id=1,brandId=2,colorId=1,dailyPrice=50000,modelYear=2021,description="Son model araç"},
                new Car{Id=1,brandId=2,colorId=1,dailyPrice=50000,modelYear=2020,description="Temiz ve yeni model araç"},
                new Car{Id=1,brandId=2,colorId=1,dailyPrice=50000,modelYear=2012,description="kilometresi az doktordan :D "}
                };
            }

        public List<Car> GetByCarBrandId(Func<object, bool> p)
            {
            throw new NotImplementedException();
            }

        public List<Car> GetAll()
            {
            return _cars;
            }

        public List<Car> GetByColorId(Func<object, bool> p)
            {
            throw new NotImplementedException();
            }

        public List<Car> GetByUnitPrice(Func<object, bool> p)
            {
            throw new NotImplementedException();
            }

        internal void Update(Car car)
            {
            throw new NotImplementedException();
            }

        public void Add(Car car)
            {
            _cars.Add(car);
            }
       public  void Delete(Car car)
            {
            Car DeleteCar = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(DeleteCar);

            }

     private InMemoryCarDal(ICarDal v)
            {
            throw new NotImplementedException();
            }

        public InMemoryCarDal(List<Car> cars)
            {
            _cars = cars;
            }
        }
    }
