﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _brandDal.Add(brand);
                return new SuccessResult(Message.AddedBrand);
            }
            return new ErrorResult(Message.ErrorBrandMessage);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Message.DeletedBrand);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());
        }

        public IDataResult<Brand> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(b => b.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            if (brand.BrandName.Length>2)
            {
                _brandDal.Update(brand);
                return new SuccessResult(Message.UpdatedBrand);
            }
            return new ErrorResult(Message.ErrorBrandMessage);
        }
    }
}
