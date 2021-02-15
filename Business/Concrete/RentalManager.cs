﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate == null && _rentalDal.GetRentalDetails(r => r.CarId == rental.CarId).Count > 0)
            {
                return new ErrorResult(Message.ErrorRentalMessage);
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Message.AddedRental);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Message.DeletedRental);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());   
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(r=>r.Id==id));
        }

        public IDataResult<List<RentalDetailDTO>> GetRentalDetails(int carId)
        {
            return new SuccessDataResult<List<RentalDetailDTO>>(_rentalDal.GetRentalDetails(r => r.CarId == carId), Message.ReturnedRental);
        }

       
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Message.UpdatedRental);
        }

    }
}