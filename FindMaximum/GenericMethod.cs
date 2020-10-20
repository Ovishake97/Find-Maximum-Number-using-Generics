using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
   public class GenericMethod<T> where T : IComparable
    {
        /// With the help of CompareTo method
        /// the entered numbers are checked for
        /// condition and the maximum number out of them is returned.
        /// In case two or more numbers are equal it throws exception
        public T num1, num2, num3;
        public GenericMethod(T num1, T num2, T num3)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.num3 = num3;
        }
        /// Implementing a generic method to
        /// check for any data type
        /// and give the maximum out of them
        public static T TestMaximum(T num1, T num2, T num3) {
            Console.WriteLine("Maximum number is:");
            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0)
            {
                return num1;
            }
            else if (num2.CompareTo(num3) > 0 && num2.CompareTo(num1) > 0)
            {
                return num2;
            }
            else if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0)
            {
                return num3;
            }
            else {
                throw new Exception("Two or more of the entered numbers are same");
            }
        }
        /// Defining the TestMaximum method
        /// to internally call the static TestMaximum method
        /// as asked in the refactored code
        public T TestMaximum()
        {
            T max = GenericMethod<T>.TestMaximum(num1, num2, num3);
            return max;
        }
    }
}
