using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InEntityFramework;
using Entities.Concrete;
using System;

namespace UIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandTest();
            //CarTest();
            //CustomerTest();

            //UserTest();
            //ColorTest();
            RentalTest();
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName = "Blue" });
            //colorManager.Delete(new Color { ColorId = 2 });
            //colorManager.Update(new Color { ColorId = 2, ColorName = "Green" });
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            //rentalManager.Add(new Rental { Id = 3, CarId = 3, CustomerId = 2, RentDate = DateTime.Now, ReturnDate = DateTime.Now.AddDays(+4) });
            //rentalManager.Delete(new Rental { RentalId = 2 });
            //rentalManager.Update(new Rental { RentalId=2, Id=2, CustomerId=1});
            foreach (var rental in result.Data)
            {
                Console.WriteLine(rental.Id + " " + rental.CustomerId + " " + rental.RentDate + " " + rental.ReturnDate);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            //userManager.Add(new User { Id = 3, FirstName = "Akif", LastName = "Demirel", Email = "akifdemirel@gmail.com", Password = "85314" });
            //userManager.Delete(new User { Id = 2 });
            //userManager.Update(new User { Id = 2, Password = "25698" });
            foreach (var user in result.Data)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + " " + user.Email + " " + user.Password);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();
           // customerManager.Add(new Customer {Id=2, UserId = 2, CompanyName = "Telekom" });
            //colorManager.Delete(new Customer { CustomerId = 2 });
            //customerManager.Update(new Customer { CustomerId = 1, CompanyName="Beko"});
            foreach (var customer in result.Data)
            {
                Console.WriteLine(customer.Id+" "+customer.UserId + " " + customer.CompanyName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
           // carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = 250, Descriptions = "Automatic dizel" });
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarId + " " + car.DailyPrice + " " + car.Descriptions);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
          //  brandManager.Add(new Brand { BrandName = "Honda" });
           // brandManager.Delete(new Brand { BrandId = 2 });
            //brandManager.Update(new Brand { BrandId = 3 });
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }
    }
}

            