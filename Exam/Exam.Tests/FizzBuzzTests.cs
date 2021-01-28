using Exam.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exam.Tests
{
    // FizzBuzz
    // Count up to a number. For classic numbers, say the number itself.
    // However, any number divisible by three is replaced by the word "Fizz" and any number divisible by five by the word "Buzz"
    // Numbers divisible by 15 become FizzBuzz
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void Should_Say1_When_1IsGivenAsInput()
        {
            // Arrange
            var fizzBuzz = new FizzBuzzService();

            // Act
            var output = fizzBuzz.Play(1);

            // Assert
            Assert.AreEqual("1", output);
        }

        [TestMethod]
        public void Should_Say12_When_2IsGivenAsInput()
        {
            // Arrange
            var fizzBuzz = new FizzBuzzService();

            // Act
            var output = fizzBuzz.Play(2);

            // Assert
            Assert.AreEqual("12", output);
        }

        [TestMethod]
        public void Should_Say12Fizz_When_3IsGivenAsInput()
        {
            // Arrange
            var fizzBuzz = new FizzBuzzService();

            // Act
            var output = fizzBuzz.Play(3);

            // Assert
            Assert.AreEqual("12Fizz", output);
        }

        [TestMethod]
        public void Should_Say12Fizz4_When_4IsGivenAsInput()
        {
            // Arrange
            var fizzBuzz = new FizzBuzzService();

            // Act
            var output = fizzBuzz.Play(4);

            // Assert
            Assert.AreEqual("12Fizz4", output);
        }

        [TestMethod]
        public void Should_Say12Fizz4Buzz_When_5IsGivenAsInput()
        {
            // Arrange
            var fizzBuzz = new FizzBuzzService();

            // Act
            var output = fizzBuzz.Play(5);

            // Assert
            Assert.AreEqual("12Fizz4Buzz", output);
        }

        [TestMethod]
        public void Should_Say12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz_When_15IsGivenAsInput()
        {
            // Arrange
            var fizzBuzz = new FizzBuzzService();

            // Act
            var output = fizzBuzz.Play(15);

            // Assert
            Assert.AreEqual("12Fizz4BuzzFizz78FizzBuzz11Fizz1314FizzBuzz", output);
        }
    }
}
