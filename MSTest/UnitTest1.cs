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
            FindMaximum.GenericMethod<int> generic = new GenericMethod<int>(20, 30, 50);
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
            FindMaximum.GenericMethod<float> generic = new GenericMethod<float>(20, 30, 50);
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
            FindMaximum.GenericMethod<string> generic = new GenericMethod<string>("20", "30", "50");
            string expected = "50";
            //Act
            string actual = generic.TestMaximum();
            //Assert
            expected.Equals(actual);
        }
    }
}
