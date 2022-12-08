using UserRegistrationExceptionHandling;

namespace TestOnExceptionHandling
{
    [TestClass]
    public class UserRegistrationTestClass
    {
        [TestMethod]
        [DataRow("", "Input should not be empty or null")]
        [DataRow("Ab", "Input should be in proper format")]
        [DataRow("abc", "Input should be in proper format")]
        [DataRow("Abc", "Validated successfully!")]
        [DataRow("Abcd", "Validated successfully!")]

        public void TestFirstName(string userInput, string expected)
        {
            //Arrange
            //string userInput = "Abc";

            //Act
            string actualOutput = UserDetails.FirstName(userInput);

            //Assert
            Assert.AreEqual(expected, actualOutput);

        }
    }
}