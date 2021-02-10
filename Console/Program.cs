using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{

    class Program
    {
        static void Main(string[] args)
        {
            CarsManager carsManager = new CarsManager(new EfCarDetailDal());

            foreach (var car in carsManager.GetCartDetails())
            {
                Console.WriteLine("Arac Numarası : " +car.CarsId + Environment.NewLine+ "Araç Modeli : " + car.BrandName + Environment.NewLine + "Aracın Rengi:"+ car.ColorName + Environment.NewLine + "Aracın Açıklaması : "+car.CarDescription+ 
                    Environment.NewLine + "---------------Diğer Alternatif Araçlar--------------------");
            }
            

        }


    }
}

