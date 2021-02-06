using Business.Abstrack;
using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarsManager : ICarService
        
    {
        ICarsDal  _carsdal;
        public CarsManager (ICarsDal carsDal)
        {
            _carsdal = carsDal;
        }

        public List<Cars> GetCarsByBrandId()
        {
            return _carsdal.GetAll();
        }

        public List<Cars> GetCarsByBrandId(int Id)
        {
            return _carsdal.GetAll(p => p.BrandId == Id);
        }

        public List<Cars> GetCarsByColorId(int Id)
        {
            return _carsdal.GetAll(p => p.ColorId == Id);
        }
    }
}
