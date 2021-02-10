using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface ICarDetail: IEntityRepostory<Cars>
    {
        List<RentCarDetailDto> GetAll();
        List<RentCarDetailDto> GetCarDetailDtos(Expression<Func<Cars, bool>> filter = null);
    }
}
