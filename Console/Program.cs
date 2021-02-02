using Business.Concrete;
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

            CarsManager carsManager = new CarsManager(new InMemoryUseDal());

            foreach (var cars in carsManager.GetAll())
            {
                Console.WriteLine(cars.Description);
            }
        }


    }
}

