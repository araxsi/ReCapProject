using DataAccess.Abstrack;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarsDal
    {
        public void Add(Cars entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                if (entity.DailyPrice > 0)
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Araba Kiralama fiyatı 0 dan büyük olmalıdır");
                }

            }
        }

        public void Delete(Cars entity)

        {
            using (CarDbContext context = new CarDbContext())
            {
                var DeleteEntity = context.Entry(entity);
                DeleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Cars Get(Expression<Func<Cars, bool>> filter)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return context.Set<Cars>().SingleOrDefault(filter);
            }
        }

        public List<Cars> GetAll(Expression<Func<Cars, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return filter == null
                    ? context.Set<Cars>().ToList()
                    : context.Set<Cars>().Where(filter).ToList();
            }
        }

        public void Update(Cars entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var UpdadedEntity = context.Entry(entity);
                UpdadedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

