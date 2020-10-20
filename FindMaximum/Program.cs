using System;

namespace FindMaximum
{
    class Program
    {
        ///Invoking the generic method defined  
        /// to calculate the maximun number
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70 };
            GenericMethod<int> genericMethod = new GenericMethod<int>(arr);
            genericMethod.PrintMax();
            Console.ReadKey();
        }
        public interface IComparable {
            void PrintMax();
        }
    }
}
