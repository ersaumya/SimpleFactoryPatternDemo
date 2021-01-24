using SimpleFactory.ConcreteProduct;
using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.ConcreteFactory
{
    public class MobileFactory
    {
        public static IMobile CreateMobile(BrandType brandType)
        {
            switch (brandType)
            {
                case BrandType.Apple:
                    return new Apple();
                case BrandType.OnePlus:
                    return new OnePlus();
                default:
                    throw new Exception("Invalid Brand Type...");
            }
        }
    }
}
