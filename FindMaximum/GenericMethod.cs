using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximum
{
   public class GenericMethod
    {
        /// With the help of CompareTo method
        /// the entered numbers are checked for
        /// condition and the maximum number out of them is returned.
        /// In case two or more numbers are equal it throws exception
        public static int GetMaximumInt(int num1, int num2, int num3) {
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
        /// Implementating the same method as asked
        /// in UC2 in order to accommodate
        /// float parameters in lieu of integers
        public static float GetMaximumFloat(float num1, float num2, float num3)
        {
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
            else
            {
                throw new Exception("Two or more of the entered numbers are same");
            }
        }
        /// Rewriting the same method as above 
        /// in order to check for
        /// string parameters
        public static string GetMaximumString(string num1, string num2, string num3)
        {
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
            else
            {
                throw new Exception("Two or more of the entered numbers are same");
            }
        }
    }
}
