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

        public List<Cars> GetAll()
        {
            return _carsdal.GetAll();
        }
    }
}
