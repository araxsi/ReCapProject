using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{

    class Program
    {
        static void Main(string[] args)
        {
            CarsManager carsManager = new CarsManager(new EfCarDal());

            foreach (var car in carsManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            

        }


    }
}

