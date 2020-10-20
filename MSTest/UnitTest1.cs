using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindMaximum;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenAtFirstPositionReturnsFirst()
        {   //Arrange
            int expected = 50;
            //Act
            int actual = FindMaximum.GenericMethod.GetMaximumInt(50,20,30);
            //Assert
            expected.Equals(actual);
        }
        [TestMethod]
        public void GivenAtSecondPositionReturnsSecond()
        {   //Arrange
            int expected = 50;
            //Act
            int actual = FindMaximum.GenericMethod.GetMaximumInt(20, 50,30);
            //Assert
            expected.Equals(actual);
        }
        [TestMethod]
        public void GivenAtThirdPositionReturnsThird()
        {   //Arrange
            int expected = 50;
            //Act
            int actual = FindMaximum.GenericMethod.GetMaximumInt(20, 30, 50);
            //Assert
            expected.Equals(actual);
        }
    }
}
