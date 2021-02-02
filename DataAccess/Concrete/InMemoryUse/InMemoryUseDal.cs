using DataAccess.Abstrack;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemoryUse
{
    public class InMemoryUseDal : ICarsDal
    {
        List<Cars> _cars;
        List<Colors> _color;
        List<Brand> _brand;
        public InMemoryUseDal()
        {
            _cars = new List<Cars> {

                new Cars{ Id=1,BrandId=1,ColorId=4,ModelYear=2008,DailyPrice=150000,Description="Mercedes CLK4"},
                new Cars{ Id=2,BrandId=2,ColorId=2,ModelYear=2008,DailyPrice=83000,Description="Woswogan Jetta"},
                new Cars{ Id=3,BrandId=1,ColorId=7,ModelYear=2008,DailyPrice=110000,Description="Mercedes E200"},
                new Cars{ Id=4,BrandId=2,ColorId=3,ModelYear=2008,DailyPrice=60000,Description="Woswogan Passat"},
                new Cars{ Id=5,BrandId=1,ColorId=5,ModelYear=2008,DailyPrice=80000,Description="Mercedes A1"},
                new Cars{ Id=6,BrandId=3,ColorId=6,ModelYear=2008,DailyPrice=2000,Description="Fiat"}

        };
            _color = new List<Colors>

            {
                new Colors{ ColorId=1,ColorName="Red"},
                new Colors{ ColorId=2,ColorName="White"},
                new Colors{ ColorId=3,ColorName="Black"},
                new Colors{ ColorId=4,ColorName="Orange"},
                new Colors{ ColorId=5,ColorName="Blue"},
                new Colors{ ColorId=6,ColorName="Purple"},
                new Colors{ ColorId=7,ColorName="Yellow"},
                new Colors{ ColorId=8,ColorName="Green"},

            };

            _brand = new List<Brand>

            {
                new Brand{ BrandId=1,BrandName="Mercedes"},
                new Brand{ BrandId=2,BrandName="Woswogen"},
                new Brand{ BrandId=1,BrandName="Fiat"},
            };




        }
        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            Cars carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public List<Cars> GetAll()
        {
            return _cars;
           //return _color;
           // return _brand
        }

        public List<Cars> GetAllByCategory(int Id)
        {
            return _cars.Where(p => p.Id == Id).ToList();
        }

        public void Update(Cars car)
        {
            Cars carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);

            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
