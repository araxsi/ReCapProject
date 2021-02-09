using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarsManager : ICarService

    {
        ICarsDal _carDal;

        public CarsManager(ICarsDal carsDal)
        {
            _carDal = carsDal;
        }

        public List<Cars> GetAll()
        {
            return _carDal.GetAll();
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