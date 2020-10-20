using System;

namespace FindMaximum
{
    class Program
    {
    ///Invoking the methods defined  
    /// to calculate the maximun number
        static void Main(string[] args)
        {
            int result=GenericMethod.GetMaximumInt(20, 30, 50);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
