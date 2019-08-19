using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShopLibrary
{
  public  class Car
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public Vendor Owner { get; set; }

     
        public string Display {
            get
            {
                return string.Format("{0} - ${1}", Name, Price);
            }
        }

    }
}
