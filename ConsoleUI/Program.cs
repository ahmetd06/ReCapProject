using System;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
          
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Car car = new Car { Id= 100, BrandId = 100, ColorId = 100, DailyPrice = 100, ModelYear = 2021, Description = "son eklenen" };

            carManager.Add(car);

            var result = carManager.GetAll();

            foreach (var item in result)
            {
                Console.WriteLine("{0} {1} {2} {3} {4}", item.Id, item.BrandId, item.ModelYear, item.DailyPrice, item.Description);
            }
        }
    }
}
