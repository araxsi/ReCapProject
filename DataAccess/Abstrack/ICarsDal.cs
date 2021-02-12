﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface ICarsDal:IEntityRepostory<Cars>
    {
        List<RentCarDetailDto> GetCarDetails();
    }
}
