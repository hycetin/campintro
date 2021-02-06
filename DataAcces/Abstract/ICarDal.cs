using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Cars> GetAll();
        void Add(Cars car);
        void Delete(Cars car);
        void Update(Cars car);
        List<Cars> GetById(int Id);
        
    }
}
