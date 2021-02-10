using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarsManager : ICarService

    {
        ICarDetail _carDal;

        public CarsManager(ICarDetail carsDal)
        {
            _carDal = carsDal;
        }

        //public List<RentCarDetailDto> GetAll()
        //{
        //    return _carDal.GetAll();
        //}

        public List<RentCarDetailDto> GetCartDetails()
        {
            return _carDal.GetCarDetailDtos();
        }
    }
}






//public List<Cars> GetAll()
//{
    
//}

//public List<Cars> GetCarsByBrandId(int Id)
//{
//    return _carsdal.GetCarsByBrandId(p => p.BrandId == Id);
//}

//public List<Cars> GetCarsByColorId(int Id)
//{
//    return _carsdal.GetCarsByColorId(p => p.ColorId == Id);
//}