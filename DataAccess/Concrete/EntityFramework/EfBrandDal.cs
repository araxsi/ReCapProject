using DataAccess.Abstrack;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                if (entity.BrandName.Length > 0)
                {
                    var addedEntity = context.Entry(entity);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
                else
                {
                    Console.WriteLine("Araba adı 2 karakterden bük olmalıdır");
                }

            }
        }

        public void Add(Colors entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Colors entity)
        {
            using (CarDbContext context = new CarDbContext())
            {
                var DeleteEntity = context.Entry(entity);
                DeleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Colors Get(Expression<Func<Colors, bool>> filter)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return context.Set<Colors>().SingleOrDefault(filter);
            }
        }

        public List<Colors> GetAll(Expression<Func<Colors, bool>> filter = null)
        {
            using (CarDbContext context = new CarDbContext())
            {
                return filter == null
                    ? context.Set<Colors>().ToList()
                    : context.Set<Colors>().Where(filter).ToList();
            }
        }

        public void Update(Colors entity)
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
