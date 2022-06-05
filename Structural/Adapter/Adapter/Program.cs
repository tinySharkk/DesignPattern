﻿using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine(target.Request());
        }
    }
}
