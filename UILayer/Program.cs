using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InEntityFramework;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine(car.Descriptions+" "+car.DailyPrice+" "+car.ModelYear);
            }

        }
    }
}
