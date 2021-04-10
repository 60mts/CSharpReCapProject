using reCapProjectt.Bussines.Concrete;
using reCapProjectt.DataAcces.Abstract;
using System;

namespace reCapProjectt
    {
   public  class Program
        {
        public static void Main(string[] args)
            {
            CarManager cm = new CarManager(new ICarDal());
            foreach(var cars in cm.GetAll())
            Console.WriteLine(cars.Id);
            }
        }
    }
