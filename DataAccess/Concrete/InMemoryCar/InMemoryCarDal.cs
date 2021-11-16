using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemoryCar
{
    public class InMemoryCarDal :ICarDal
    {

        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> { new Car {Id=1, BrandId=1,ColorId=5,ModelYear=2021,DailyPrice=100,Description="Test"} };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = null;
            carDelete = _car.SingleOrDefault(x => x.Id == car.Id);
             _car.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public void Update(Car car)
        {
            Car carUpdate = _car.FirstOrDefault(x => x.Id == car.Id);
            carUpdate.ModelYear = 2019;
            carUpdate.Description = "Bmw";
        }
    }
}
