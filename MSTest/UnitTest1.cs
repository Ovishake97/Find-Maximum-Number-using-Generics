using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximum;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        /// Unit test cases to test
        /// the defined method for
        /// int,float and string type parameters. 
        [TestMethod]
        public void TestForGenericType_Int() {
            //Arrange
            int[] arr = { 10, 20, 30, 40, 50 };
            FindMaximum.GenericMethod<int> generic = new GenericMethod<int>(arr);
            int expected = 50;
            //Act
            int actual =generic.TestMaximum();
            //Assert
            expected.Equals(actual);
        }
        [TestMethod]
        public void TestForGenericType_Float()
        {
            //Arrange
            float[] arr = { 10, 20, 30, 40, 50 };
            FindMaximum.GenericMethod<float> generic = new GenericMethod<float>(arr);
            float expected = 50;
            //Act
            float actual = generic.TestMaximum();
            //Assert
            expected.Equals(actual);
        }
        [TestMethod]
        public void TestForGenericType_String()
        {
            //Arrange
            string[] arr = { "10", "20", "30", "40", "50" };
            FindMaximum.GenericMethod<string> generic = new GenericMethod<string>(arr);
            string expected = "50";
            //Act
            string actual = generic.TestMaximum();
            //Assert
            expected.Equals(actual);
        }
    }
}
