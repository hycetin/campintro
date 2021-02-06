using System;
using System.Collections.Generic;
using System.Text;
using Entity.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Cars> GetAll();
        
    }
}
