using SimpleFactory.Product;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.ConcreteProduct
{
    public class OnePlus : IMobile
    {
        public void GetMobile()
        {
            Console.WriteLine("OnePlus mobile is created..");
        }
    }
}
