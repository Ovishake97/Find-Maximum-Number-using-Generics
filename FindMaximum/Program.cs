﻿using System;

namespace FindMaximum
{
    class Program
    {
    ///Invoking the methods defined  
    /// to calculate the maximun number
        static void Main(string[] args)
        {
            Console.WriteLine(GenericMethod.GetMaximumInt(20, 30, 50));
            Console.WriteLine(GenericMethod.GetMaximumFloat(20,30,50));
            Console.WriteLine(GenericMethod.GetMaximumString("20","30","50"));
            Console.ReadKey();
        }
    }
}
