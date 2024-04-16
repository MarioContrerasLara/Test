using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using Test2;

namespace Test2.Tests
{
    [TestClass]
    public class MailTests
    {
        [TestMethod]
        public void ValidEmail()
        {
            // Arrange
            string email = "test1@test.test";

            // Act
            bool result = Mail.IsValidEmail(email);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void InvalidEmail()
        {
            // Arrange
            string email = "email@";

            // Act
            bool result = Mail.IsValidEmail(email);

            // Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void EmailValidated()
        {
            // Arrange
            string email = "test1@test.test";
            var mockEmailList = new Mock<IEmailList>();
            mockEmailList.Setup(m => m.Contains(It.IsAny<string>())).Returns(true);


            // Act
            bool result = Mail.IsValidEmail(email);
            bool isAlreadyValidated = mockEmailList.Object.Contains(email);

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(isAlreadyValidated);
        }

        [TestMethod]
        public void EmailNotValidated()
        {
            // Arrange
            string email = "test1@test.test";
            var mockEmailList = new Mock<IEmailList>();
            mockEmailList.Setup(m => m.Contains(It.IsAny<string>())).Returns(false);

            // Act
            bool result = Mail.IsValidEmail(email);
            bool isAlreadyValidated = mockEmailList.Object.Contains(email);

            // Assert
            Assert.IsTrue(result);
            Assert.IsFalse(isAlreadyValidated);
        }
    }
}
