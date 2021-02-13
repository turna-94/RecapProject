using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InEntityFramework
{
    public class EfCarDal:EfEntityRepositoryBase<Car,RentCarInfoContext>,ICarDal
    {
        public void Add(Car entity)
        {
            using (RentCarInfoContext context=new RentCarInfoContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (RentCarInfoContext context=new RentCarInfoContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (RentCarInfoContext context=new RentCarInfoContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RentCarInfoContext context=new RentCarInfoContext())
            {
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
            }
        }

        public List<CarDetailDTO> GetCarDetails()
        {
            using (RentCarInfoContext context=new RentCarInfoContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId
                             select new CarDetailDTO
                             {
                                 CarId = c.CarId,
                                 BrandName = b.BrandName,
                                 ModelYear = c.ModelYear,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice,
                                 Descriptions = c.Descriptions
                             };

                return result.ToList();
            }
        }

        public void Update(Car entity)
        {
            using (RentCarInfoContext context=new RentCarInfoContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
