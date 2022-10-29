using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=18.65, Dascription="OPEL", ModelYear=2018},
                new Car{Id=2, BrandId=1, ColorId=2, DailyPrice=23.75, Dascription="TOYOTA", ModelYear=2019},
                new Car{Id=3, BrandId=2, ColorId=2, DailyPrice=28.85, Dascription="VW", ModelYear=2020},
                new Car{Id=4, BrandId=2, ColorId=3, DailyPrice=32.95, Dascription="AUDI", ModelYear=2021},
                new Car{Id=5, BrandId=3, ColorId=3, DailyPrice=37.05, Dascription="TOGG", ModelYear=2022}
            };
        }



        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.SingleOrDefault(c=>c.Id==id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Dascription=car.Dascription;
            
        }
    }
}
