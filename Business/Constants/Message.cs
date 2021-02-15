using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Message
    {
        public static string AddedBrand = "The brand has been added successfully";
        public static string UpdatedBrand ="The brand has been updated successfully";
        public static string DeletedBrand = "The brand has been deleted successfully";
        public static string ErrorBrandMessage = "The brand name must be greater than 2 characters";

        public static string AddedCar = "The car has been added successfully";
        public static string UpdatedCar = "The car has been updated successfully";
        public static string DeletedCar = "The car has been deleted successfully";
        public static string ErrorCarMessage = "The car unit price must be greater than 0";

        public static string AddedColor = "The color has been added successfully";
        public static string UpdatedColor = "The color has been updated successfully";
        public static string DeletedColor = "The color has been deleted successfully";

        public static string AddedCustomer = "The customer has been added successfully";
        public static string UpdatedCustomer = "The customer has been updated successfully";
        public static string DeletedCustomer = "The customer has been deleted successfully";


        public static string AddedUser = "The user has been added successfully";
        public static string UpdatedUser = "The user has been updated successfully";
        public static string DeletedUser = "The user has been deleted successfully";


        public static string AddedRental = "Car rental has been successfully completed";
        public static string UpdatedRental = "Car rental process has been updated";
        public static string DeletedRental = "Car rental process has been deleted";
        public static string ErrorRentalMessage = "You can not rent the car as it is not delivered";
        public static string ReturnedRental = "The rented car has been delivered";
    }
}
