using SimpleFactory;
using SimpleFactory.ConcreteFactory;
using SimpleFactory.Product;
using System;

namespace SimpleFactoryPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IMobile mobile = MobileFactory.CreateMobile(BrandType.Apple);
            mobile.GetMobile();
            Console.ReadKey();
        }
    }
}
