using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximum;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        //TC 1.1
        [TestMethod]
        public void GivenAtFirstPositionReturnsFirst_INT()
        {   //Arrange
            int expected = 50;
            //Act
            int actual = FindMaximum.GenericMethod.GetMaximumInt(50,20,30);
            //Assert
            expected.Equals(actual);
        }
        //TC 1.2
        [TestMethod]
        public void GivenAtSecondPositionReturnsSecond_INT()
        {   //Arrange
            int expected = 50;
            //Act
            int actual = FindMaximum.GenericMethod.GetMaximumInt(20, 50,30);
            //Assert
            expected.Equals(actual);
        }
        //TC 1.3
        [TestMethod]
        public void GivenAtThirdPositionReturnsThird_INT()
        {   //Arrange
            int expected = 50;
            //Act
            int actual = FindMaximum.GenericMethod.GetMaximumInt(20, 30, 50);
            //Assert
            expected.Equals(actual);
        }
        /// Writing the same test cases
        /// in case of float parameters
        //TC 2.1
        [TestMethod]
        public void GivenAtFirstPositionReturnsFirst_Float()
        {   //Arrange
            float expected = 50;
            //Act
            float actual = FindMaximum.GenericMethod.GetMaximumFloat(50, 20, 30);
            //Assert
            expected.Equals(actual);
        }
        //TC 2.2
        [TestMethod]
        public void GivenAtSecondPositionReturnsSecond_Float()
        {   //Arrange
            float expected = 50;
            //Act
            float actual = FindMaximum.GenericMethod.GetMaximumFloat(20, 50, 30);
            //Assert
            expected.Equals(actual);
        }
        //TC 2.3
        [TestMethod]
        public void GivenAtThirdPositionReturnsThird_Float()
        {   //Arrange
            float expected = 50;
            //Act
            float actual = FindMaximum.GenericMethod.GetMaximumFloat(20, 30, 50);
            //Assert
            expected.Equals(actual);
        }
        /// Doing the same use cases
        /// as above in case of string parameters
        //TC 3.1
        [TestMethod]
        public void GivenAtFirstPositionReturnsFirst_String()
        {   //Arrange
            string expected = "50";
            //Act
            float actual = FindMaximum.GenericMethod.GetMaximumFloat(50, 20, 30);
            //Assert
            expected.Equals(actual);
        }
        //TC 3.2
        [TestMethod]
        public void GivenAtSecondPositionReturnsSecond_String()
        {   //Arrange
            string expected = "50";
            //Act
            string actual = FindMaximum.GenericMethod.GetMaximumString("20", "50", "30");
            //Assert
            expected.Equals(actual);
        }
        //TC 3.3
        [TestMethod]
        public void GivenAtThirdPositionReturnsThird_String()
        {   //Arrange
            string expected = "50";
            //Act
            string actual = FindMaximum.GenericMethod.GetMaximumString("20", "30", "50");
            //Assert
            expected.Equals(actual);
        }
    }
}
