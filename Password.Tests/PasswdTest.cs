using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Password.Tests
{
    [TestClass]
    public class PasswdTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            string passwd = "";
            int expected = 0;

            // act
            Passwd validator = new Passwd();
            int actual = validator.ValidatePassword(passwd);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePassword_OnlyDigits_Return1()
        {
            // arrange
            string passwd = "12345";
            int expected = 1;

            // act
            Passwd proverka = new Passwd();
            int actual = proverka.ValidatePassword(passwd);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePassword_LowerDigits_Return2()
        {
            // arrange
            string passwd = "gaga123";
            int expected = 2;

            // act
            Passwd proverka = new Passwd();
            int actual = proverka.ValidatePassword(passwd);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePassword_UpperLowerDigits_Return3()
        {
            // arrange
            string passwd = "Goga123";
            int expected = 3;

            // act
            Passwd proverka = new Passwd();
            int actual = proverka.ValidatePassword(passwd);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePassword_AllRequirementsExceptLength_Return4()
        {
            // arrange
            string passwd = "Giga!123";
            int expected = 4;

            // act
            Passwd proverka = new Passwd();
            int actual = proverka.ValidatePassword(passwd);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidatePassword_AllRequirementsMet_Return5()
        {
            // arrange
            string passwd = "Guga!1234567";
            int expected = 5;

            // act
            Passwd proverka = new Passwd();
            int actual = proverka.ValidatePassword(passwd);

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}
