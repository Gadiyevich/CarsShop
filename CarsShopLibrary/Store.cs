﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsShopLibrary
{
   public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Car>  Cars { get; set; }

        public Store()
        {
            Vendors = new List<Vendor>();
            Cars = new List<Car>();
        }
    }
}
