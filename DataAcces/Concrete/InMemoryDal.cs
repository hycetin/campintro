using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entity.Concrete;

namespace DataAccess.Concrete
{
    public class InMemoryDal : ICarDal
    {
        List<Cars> _cars;
        

        public InMemoryDal()
        {
            _cars = new List<Cars>
            {


                new Cars { BrandId = 1, CarId = 1, ColorId = 1, DailyPrice = 3000, ModelYear = 2020, Decription = "Audi A3" },
                new Cars { BrandId = 2, CarId = 2, ColorId = 2, DailyPrice = 100, ModelYear = 1913, Decription = "Tofaşk" },
                new Cars { BrandId = 3, CarId = 3, ColorId = 3, DailyPrice = 500, ModelYear = 2012, Decription = "Opel Astra" },
                new Cars { BrandId = 4, CarId = 4, ColorId = 4, DailyPrice = 20000, ModelYear = 2021, Decription = "Aston Martın" }

            };
            
            
        }

        public void Add(Cars car)
        {
            _cars.Add(car);
        }

        public void Delete(Cars car)
        {
            var DeleteToCars = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            _cars.Remove(DeleteToCars);
        }

        public List<Cars> GetAll()
        {
            return _cars;
        }

        public List<Cars> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public void Update(Cars car)
        {
            var UptadeToCars = _cars.SingleOrDefault(c => c.BrandId == car.BrandId);
            UptadeToCars.BrandId = car.BrandId;
            UptadeToCars.CarId = car.CarId;
            UptadeToCars.ColorId= car.ColorId;
            UptadeToCars.DailyPrice = car.DailyPrice;
            UptadeToCars.Decription = car.Decription;
        }
    }
}
