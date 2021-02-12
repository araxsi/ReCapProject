using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Cars>> GetByBrandId(int id);
        IDataResult<List<Cars>> GetAll();
        IDataResult<List<Cars>> GetByColorId(int id);
        IResult Add(Cars car);
        IResult Update(Cars car);
        IResult Delete(Cars car);
        IDataResult<List<RentCarDetailDto>> GetCarDetails();

    }
}