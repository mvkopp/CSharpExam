using System.Linq;
using Exam.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exam.Tests
{
    [TestClass]
    public class BookStoreTests
    {
        [TestMethod]
        public void GetAllBooks()
        {
            // Arrange
            var subject = new BookStore();

            // Act
            var books = subject.GetAllBooks();

            // Assert
            Assert.AreEqual(5, books.Count());
        }

        [TestMethod]
        public void GetAllBooksOrderedByDate()
        {
            // Arrange
            var subject = new BookStore();

            // Act
            var books = subject.GetAllBooksByDate();

            // Assert
            Assert.AreEqual(5, books.Count());
            Assert.AreEqual("Le jour où j'ai appris à vivre", books.ElementAt(0).Title);
            Assert.AreEqual("Le premier jour du reste de ma vie", books.ElementAt(1).Title);
            Assert.AreEqual("Ta 2ème vie commence quand tu comprends que tu n'en as qu'une", books.ElementAt(2).Title);
            Assert.AreEqual("Chère mamie", books.ElementAt(3).Title);
            Assert.AreEqual("Rompre", books.ElementAt(4).Title);
        }

        [TestMethod]
        public void GetAllBooksWrittenByGrimaldi()
        {
            // Arrange
            var subject = new BookStore();

            // Act
            var books = subject.GetAllBooksWrittenByAuthorLastName("Grimaldi");

            // Assert
            Assert.AreEqual(2, books.Count());
            Assert.AreEqual("Le premier jour du reste de ma vie", books.ElementAt(0).Title);
            Assert.AreEqual("Chère mamie", books.ElementAt(1).Title);
        }

        [TestMethod]
        public void GetAllBooksWrittenByGrimaldiAfterYear2017()
        {
            // Arrange
            var subject = new BookStore();

            // Act
            var books = subject.GetAllBooksWrittenByAuthorLastNameAfterYear("Grimaldi");

            // Assert
            Assert.AreEqual(1, books.Count());
            Assert.AreEqual("Chère mamie", books.ElementAt(0).Title);
        }
    }
}
