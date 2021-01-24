using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.ConcreteProduct
{
    public class Apple : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("Apple mobile created..");
        }
    }
}
