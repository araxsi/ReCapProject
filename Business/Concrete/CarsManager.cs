using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstrack;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarsManager : ICarService
    {
        ICarsDal _carDal;

        public CarsManager(ICarsDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Cars car)
        {
            if (car.Description.Length < 2 || car.DailyPrice <= 0)
            {
                return new ErrorResult("Aracın açıklaması 2 karakterden küçük " +
                    "olamaz veya günlük fiyatı 0 dan küçük olamaz");
            }
            else
            {
                _carDal.Add(car);
                return new SuccessResult("Aracınız başarıyla eklendi");
            }

        }

        public IResult Delete(Cars car)
        {
            _carDal.Delete(car);
            return new SuccessResult("Aracınız başarıyla silindi");
        }

        public IDataResult<List<Cars>> GetAll()
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(), "Araçlarınız başarı ile listelenmiştir");
        }

        public IDataResult<List<Cars>> GetByBrandId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(c => c.BrandId == id));
        }

        public IDataResult<List<Cars>> GetByColorId(int id)
        {
            return new SuccessDataResult<List<Cars>>(_carDal.GetAll(c => c.ColorId == id));
        }

        public IDataResult<List<RentCarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<RentCarDetailDto>>(_carDal.GetCarDetails());
        }

        public IResult Update(Cars car)
        {
            _carDal.Update(car);
            return new SuccessResult("Aracınız güncellendi");
        }
    }
}