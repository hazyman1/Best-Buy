using System;

namespace Best_By
{
    class Program
    {
        static void Main(string[] args)
        {
            House house = new House();

            

            Laptop laptop = new Laptop();
            laptop.Name = "XPS";
            laptop.GetDiscountedPrice(0.2);

            laptop.LaptopModel = "Dell";
            Print(laptop);

        }
        static void Print(Product product)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
        }
    }
}
