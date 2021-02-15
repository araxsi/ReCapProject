using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI2
{
    class Program
    {
        static void Main(string[] args)
        {
            //GetAllTest();
            //BrandAddTest();
            //ColorAddTest();
            //GetCarDetailTest();

        }

        private static void GetCarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var item in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(item.BrandName + " " + item.ColorName + " " + item.Description);
            }
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Dark Blue" });
            foreach (var item in colorManager.GetAll().Data)
            {
                Console.WriteLine(item.ColorName);
            }
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "BMW" });
            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine(item.BrandName);
            }
        }

        private static void GetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Cars { ColorId = 2, BrandId = 2, DailyPrice = 550, ModelYear = 2010, Description = "Woswogen Jetta Üst segment" });
            carManager.Add(new Cars { ColorId = 1, BrandId = 1, DailyPrice = 450, ModelYear = 2015, Description = "Mercedes E Serisi" });
            carManager.Add(new Cars { ColorId = 3, BrandId = 3, DailyPrice = 330, ModelYear = 2017, Description = "Fiat Tuston" });
            carManager.Add(new Cars { ColorId = 4, BrandId = 1, DailyPrice = 210, ModelYear = 2018, Description = "Mercedes CLK Serisi Araç" });
            carManager.Add(new Cars { ColorId = 1, BrandId = 3, DailyPrice = 150, ModelYear = 2019, Description = "Fiat Albea Arabası" });

            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Description);
            }
        }


    }
}