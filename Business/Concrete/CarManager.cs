using Core.Utilities.Results;
using Business.Abstract;
using Business.Constans;
using DataAccess.Abstrack;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;



namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarsDal _carDal;
        public CarManager(ICarsDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Cars car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.CarAdded);
            }
            else if (car.Description.Length < 2)
            {
                return new ErrorResult(Messages.DescriptionInvalid);

            }
            return new ErrorResult(Messages.DailyPriceInvalid);

        }

        public IResult Delete(Cars car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDelete);
        }

        public IDataResult<List<Cars>> GetAll()
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<List<Cars>> GetById(int id)
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(c => c.Id == id), Messages.CarGetById);
        }

        public IDataResult<List<RentCarDetailDto>> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Cars>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Cars>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IResult Update(Cars car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdate);
        }
    }
}