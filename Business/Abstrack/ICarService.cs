using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstrack
{
    public interface ICarService
    {
        //List<RentCarDetailDto> GetAll();
        List<RentCarDetailDto> GetCartDetails();


    }
}
