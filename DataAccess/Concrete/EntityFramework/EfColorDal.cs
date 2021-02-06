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
    public class EfColorDal : IColorDal
    {
        public void Add(Colors entity)
        {
            using (CarDbContext context = new CarDbContext())
            {

                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }
        public void Delete(Colors entity)
        {
            using (CarDbContext context = new CarDbContext())
            {

                var DeletedEntity = context.Entry(entity);
                DeletedEntity.State = EntityState.Deleted;
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

                var UpdatedEntity = context.Entry(entity);
                UpdatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
