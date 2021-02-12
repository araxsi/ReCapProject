﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentCarDetailDto: IDto
    {
        public int CarsId { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public string CarDescription { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
