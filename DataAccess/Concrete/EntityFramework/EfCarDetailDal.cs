using Core.DataAccess.EntityFramework;
using DataAccess.Abstrack;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDetailDal : EfEntityRepositoryBase<Cars, CarDbContext>, ICarDetail
    {
        public List<RentCarDetailDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<RentCarDetailDto> GetCarDetailDtos(Expression<Func<Cars, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {

              var result = from ca in filter is null ? context.Cars : context.Cars.Where(filter)
                           join br in context.Brands
                           on ca.BrandId equals br.BrandId
                           join co in context.Colors
                           on ca.ColorId equals co.ColorId

                           select new RentCarDetailDto
                           {
                                 CarsId=ca.Id,
                                 BrandName = br.BrandName,
                                 ColorName = co.ColorName,
                                 CarDescription = ca.Description,
                                 DailyPrice = ca.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
