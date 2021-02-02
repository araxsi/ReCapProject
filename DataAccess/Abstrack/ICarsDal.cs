using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrack
{
    public interface ICarsDal
    {
        List<Cars> GetAll();
        void Add(Cars car);
        void Update(Cars car);
        void Delete(Cars car);
        List<Cars> GetAllByCategory(int Id);
    }
}
