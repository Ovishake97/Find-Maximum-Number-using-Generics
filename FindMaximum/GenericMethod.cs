using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
   public class GenericMethod<T> where T : IComparable
    {
        /// We will accept an array of values 
        /// and with the help of the parameterised constructor
        /// it is initialised
        public T[] values;
        public GenericMethod(T[] values)
        {
            this.values = values;
        }
        /// Sorting the array of the values
        /// and returning it
        public static T[] SortedValues(T[] values) {
            Array.Sort(values);
            return values;
        }
        /// Implementing a generic method to
        /// check for any data type
        /// and give the maximum out of them
        /// by returning the first value out of the sorted array
        public static T TestMaximum(T[] values) {
            Console.WriteLine("Maximum number is:");
            var sorted = SortedValues(values);
            return sorted[^1];
        }
        /// Defining the TestMaximum method
        /// to internally call the static TestMaximum method
        public T TestMaximum()
        {
            T max = GenericMethod<T>.TestMaximum(this.values);
            return max;
        }
    }
}
