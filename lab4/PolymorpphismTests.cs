using lab3;
using Microsoft.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab4
{
    [TestClass]
    public class PolymorpphismTests
    {
        [TestMethod]
        public void TestPolymorphism_GetInfo_Method()
        {
            var books = new Books.Book[]
            {
                new Books.Book {Title = "Generic Book", Author = "John Doe"},
                new Books.Magazine {Title = "Tech Weekly", Author = "Jane Smith", IssueNumber = 12},
                new Books.EBook {Title = "C# Programming", Author = "Alice Johnson", FileSizeMB = 5},
            };
            Assert.AreEqual("Category: Book\nTitle: Generic Book\nAuthor: John Doe", books[0].GetInfo());
            Assert.AreEqual("Category: Magazine\nTitle: Tech Weekly\nAuthor: Jane Smith\nIssue Number: 12", books[1].GetInfo());
            Assert.AreEqual("Category: E-Book\nTitle: C# Programming\nAuthor: Alice Johnson\nFile Size: 5 MB", books[2].GetInfo());
        }
    }
}
