using Exam.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exam.Tests
{
    [TestClass]
    public class ArmstrongTests
    {
        [TestMethod]
        [Description("An Armstrong number of three digits is an integer such that the sum of the cubes of its digits is equal to the number itself.")]
        public void CheckForAnArmstrongNumber()
        {
            // Arrange
            var subject = new Armstrong();

            // Act
            var is153Armstrong = subject.IsArmstrong(153);
            var is370Armstrong = subject.IsArmstrong(370);
            var is336Armstrong = subject.IsArmstrong(336);
            var is200Armstrong = subject.IsArmstrong(200);


            // Assert
            Assert.IsTrue(is153Armstrong);
            Assert.IsTrue(is370Armstrong);
            Assert.IsFalse(is336Armstrong);
            Assert.IsFalse(is200Armstrong);
        }
    }
}
