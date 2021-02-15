using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InEntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentCarInfoContext>, IRentalDal
    {
        public List<RentalDetailDTO> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using (RentCarInfoContext context=new RentCarInfoContext())
            {
                var result1 = from r in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cus in context.Customers
                             on r.CustomerId equals cus.Id
                             join u in context.Users
                             on cus.UserId equals u.Id
                             select new RentalDetailDTO
                             {
                                 Id = r.Id,
                                 CustomerName = cus.CompanyName,
                                 CarId = c.CarId,
                                 RentDate = r.RentDate,
                                 ReturnDate =r.ReturnDate,
                                 UserName = u.FirstName + " " + u.LastName
                             };

                return result1.ToList();

            }
        }
    }
}
