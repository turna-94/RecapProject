using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class CarDal : ICarDal
    {
        List<Car> _cars;

        public CarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=new DateTime(2016,6,18),DailyPrice=400,Description="Audi A4"},
                new Car{Id=2,BrandId=1,ColorId=1,ModelYear=new DateTime(2015,4,17),DailyPrice=200,Description="Fiat"},
                new Car{Id=3,BrandId=1,ColorId=2,ModelYear=new DateTime(2019,12,2),DailyPrice=250,Description="Hyundai"},
                new Car{Id=4,BrandId=2,ColorId=2,ModelYear=new DateTime(2018,7,5),DailyPrice=300,Description="Honda"},
                new Car{Id=5,BrandId=2,ColorId=2,ModelYear=new DateTime(2020,4,28),DailyPrice=170,Description="Renault"}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}

       
