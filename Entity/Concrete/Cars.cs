using System;
using System.Collections.Generic;
using System.Text;
using Entity.Abstract;

namespace Entity.Concrete
{
    public class Cars : IEntity
    {
        public int CarId { get; set; }
        public int BrandId{ get; set; }
        public int ColorId { get; set; }
        public int ModelYear{ get; set; }
        public int DailyPrice { get; set; }
        public string Decription { get; set; }
    }
}
