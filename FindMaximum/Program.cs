using System;

namespace FindMaximum
{
    class Program
    {
    ///Invoking the generic method defined  
    /// to calculate the maximun number
        static void Main(string[] args)
        {
            GenericMethod<int> genericMethod = new GenericMethod<int>(20,30,50);
            Console.WriteLine(genericMethod.TestMaximum());
            Console.ReadKey();
        }
    }
}
