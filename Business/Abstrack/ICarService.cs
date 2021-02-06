using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface ICarService
    {

        List<Cars> GetCarsByBrandId();
        List<Cars> GetCarsByBrandId(int Id);
        List<Cars> GetCarsByColorId(int Id);

    }
}
