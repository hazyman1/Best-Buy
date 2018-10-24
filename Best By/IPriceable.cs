using System;
using System.Collections.Generic;
using System.Text;

namespace Best_By
{
    interface IPriceable
    {
        double Price { get; set; }

    }
    interface IDiscountable
    {
        double GetDiscountedPrice(double discount);
    }

}
