using System;
using System.Collections.Generic;
using System.Text;

namespace Best_By
{
    class Product : Computer
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string SerialNumber { get; set; }

        public double GetDiscountedPrice(double discount)
        {
            return Price * (1.0 - discount);
        }
    }
}
