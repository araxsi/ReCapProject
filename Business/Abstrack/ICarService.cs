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
        IResult Add(Cars car);
        IResult Delete(Cars car);
        IResult Update(Cars car);
        IDataResult<List<Cars>> GetAll();
        IDataResult<List<Cars>> GetById(int id);
        IDataResult<List<Cars>> GetCarsByBrandId(int id);
        IDataResult<List<Cars>> GetCarsByColorId(int id);
        IDataResult<List<RentCarDetailDto>> GetCarDetails();

    }
}