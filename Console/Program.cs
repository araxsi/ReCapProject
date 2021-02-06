using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryUse;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{

    class Program
    {
        static void Main(string[] args)
        {

            CarsManager carsManager = new CarsManager(new EfCarDal());

            foreach (var cars in carsManager.GetCarsByBrandId())
            {
                Console.WriteLine(cars.DailyPrice);
            }
        }


    }
}

