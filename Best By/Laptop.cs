using System;
using System.Collections.Generic;
using System.Text;

namespace Best_By
{
    class Laptop : IPriceable, IDiscountable
    {
        public double Price { get; set; }
        public string LaptopModel { get; set; }

        public double GetDiscountedPrice(double discount)
        {
            return 0.0
        }

    }

}
