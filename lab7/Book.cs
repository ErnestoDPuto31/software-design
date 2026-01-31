using System.ComponentModel.DataAnnotations.Schema;

namespace Lab7
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public List<Book>? Books { get; set; }
        public override string ToString() => Name;
    }

    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public int AuthorId { get; set; } 
        public Author? Author { get; set; }
    }
}