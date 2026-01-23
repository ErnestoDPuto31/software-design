using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3;

namespace lab4
{
    [TestClass]
    public class Tests
    {
        // TEST CREATIONS
        [TestMethod]
        public void TestBookCreation()
        {
            var book = new Books.Book { Title = "C# Programming", Author = "John Smith" };
            Assert.AreEqual("C# Programming", book.Title);
            Assert.AreEqual("John Smith", book.Author);
            Assert.AreEqual("Book", book.Category);
        }

        [TestMethod]
        public void TestMagazineCreation()
        {
            var magazine = new Books.Magazine { Title = "Tech Today", Author = "Jane Doe", IssueNumber = 42 };
            Assert.AreEqual("Tech Today", magazine.Title);
            Assert.AreEqual("Jane Doe", magazine.Author);
            Assert.AreEqual(42, magazine.IssueNumber);
            Assert.AreEqual("Magazine", magazine.Category);
        }

        [TestMethod]
        public void TestTextbookCreation()
        {
            var textbook = new Books.TextBook { Title = "Physics 101", Author = "Dr. Albert", Subject = "Physics" };
            Assert.AreEqual("Physics 101", textbook.Title);
            Assert.AreEqual("Dr. Albert", textbook.Author);
            Assert.AreEqual("Physics", textbook.Subject);
            Assert.AreEqual("Textbook", textbook.Category);
        }


        // EXCEPTION HANDLINGS
        [TestMethod]
        public void TestBookWithEmptyTitle() {             
            var book = new Books.Book { Title = "", Author = "John Smith" };
            Assert.AreEqual("", book.Title);
            Assert.AreEqual("John Smith", book.Author);
            StringAssert.Contains(book.GetInfo(), "Title: ");
        }

        [TestMethod]
        public void TestMagazineWithNegativeIssueNumber()
        {
            var magazine = new Books.Magazine { Title = "Tech Today", Author = "Jane Doe", IssueNumber = -5};
            Assert.AreEqual(-5, magazine.IssueNumber);
            StringAssert.Contains(magazine.GetInfo(), "Issue Number: -5");
        }

        [TestMethod]
        public void TestTextbookWithEmptySubject()
        {
            var textbook = new Books.TextBook { Title = "Physics 101", Author = "Dr. Albert", Subject = "" };
            Assert.AreEqual("", textbook.Subject);
            StringAssert.Contains(textbook.GetInfo(), "Subject: ");

        }





    }
}
