using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EFCarDal()); //InMemoryCarDal()
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Dascription);
            }
            
        }
    }
}
