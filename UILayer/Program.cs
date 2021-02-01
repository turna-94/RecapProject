using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id+ " "+car.BrandId+" "+car.ColorId+" "+car.ModelYear.Year+" "+car.DailyPrice+" "+car.Description);
            }

        }
    }
}
