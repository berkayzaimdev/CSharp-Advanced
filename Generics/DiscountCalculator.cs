﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product) 
        {
            return product.Price;
        }
    }

    public class Product 
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }
}
