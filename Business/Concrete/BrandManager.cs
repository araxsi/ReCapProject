using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstrack;
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
            if (brand.BrandName.Length < 1)
            {
                return new ErrorResult("Model adı hatalı oluşturulmuştur. En az 2 Karakter olmalıdır");
            }
            else
            {
                _brandDal.Add(brand);
                return new SuccessResult("Yeni araç modeliniz eklenmiştir");
            }

        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult("Modeliniz başarıyla silindi");
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), "Araç modelleriniz listelenmiştir");

        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult("Mevcut araç modeliniz başarıyla update edildi");
        }
    }
}