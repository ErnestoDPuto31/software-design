using Microsoft.EntityFrameworkCore;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Author
        {
            public int AuthorID { get; set; }
            public string? Name { get; set; }
            public virtual ICollection<Book>? Books { get; set; }
        }

        public class Book
        {
            public int BookID { get; set; }
            public string? Title { get; set; }
            public int AuthorID { get; set; }
            public virtual Author? Author { get; set; }

        }

        public void AddAuthorWithBooks(string authorName, string bookTitle)
        {
            using var context = new BookstoreContext();

            var author = new Author
            {
                Name = authorName,
                Books = new List<Book>
                {
                    new Book { Title = bookTitle }
                }
            };

            context.Authors.Add(author);
            context.SaveChanges();
        }


        public List<string> GetBooksWithAuthors()
        {
            using var context = new BookstoreContext();

            return context.Books
                .Include(b => b.Author)
                .Select(b => $"ID: {b.BookID} | {b.Title} by {b.Author.Name}")
                .ToList();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAuthorName.Text) ||
                    string.IsNullOrWhiteSpace(txtBookTitle.Text))
                {
                    MessageBox.Show("Please enter both Author Name and Book Title.");
                    return;
                }

                AddAuthorWithBooks(txtAuthorName.Text, txtBookTitle.Text);

                MessageBox.Show("Book added successfully!");
                txtAuthorName.Clear();
                txtBookTitle.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book and author:\n" + ex.Message);
            }
        }


        public void UpdateBookWithAuthor(int bookID, string newTitle, string newAuthorName)
        {
            using var context = new BookstoreContext();
            var book = context.Books
                              .Include(b => b.Author)
                              .FirstOrDefault(b => b.BookID == bookID);

            if (book == null)
                throw new Exception("Book not found.");
            if (!string.IsNullOrWhiteSpace(newTitle))
                book.Title = newTitle;
            if (book.Author != null && !string.IsNullOrWhiteSpace(newAuthorName))
                book.Author.Name = newAuthorName;

            context.SaveChanges();
        }


        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBookID.Text))
                {
                    MessageBox.Show("Please enter a Book ID.");
                    return;
                }
                int bookID;
                if (!int.TryParse(txtBookID.Text, out bookID))
                {
                    MessageBox.Show("Book ID must be a number.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtBookTitle.Text) && string.IsNullOrWhiteSpace(txtAuthorName.Text))
                {
                    MessageBox.Show("Please enter a new title or a new author name to update.");
                    return;
                }

                UpdateBookWithAuthor(bookID, txtBookTitle.Text, txtAuthorName.Text);
                MessageBox.Show("Book and Author updated successfully.");

                txtBookID.Clear();
                txtBookTitle.Clear();
                txtAuthorName.Clear();
                btnShowBook_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book and author:\n" + ex.Message);
            }
        }


        private void btnShowBook_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = GetBooksWithAuthors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books:\n" + ex.Message);
            }
        }

        public void DeleteBookByID(int bookID)
        {
            using var context = new BookstoreContext();

            var book = context.Books.FirstOrDefault(b => b.BookID == bookID);

            if (book == null)
                throw new Exception("Book not found.");

            context.Books.Remove(book);
            context.SaveChanges();
        }


        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBookID.Text))
                {
                    MessageBox.Show("Please enter a Book ID.");
                    return;
                }

                int bookID = int.Parse(txtBookID.Text);

                DeleteBookByID(bookID);

                MessageBox.Show("Book deleted successfully.");
                txtBookID.Clear();

                btnShowBook_Click(sender, e); // refresh list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting book:\n" + ex.Message);
            }
        }

        public List<string> SearchBooksByAuthor(string authorName)
        {
            using var context = new BookstoreContext();
            return context.Books
                          .Include(b => b.Author)
                          .Where(b => b.Author.Name.Contains(authorName))
                          .Select(b => $"ID: {b.BookID} | {b.Title} by {b.Author.Name}")
                          .ToList();
        }


        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAuthorName.Text))
                {
                    MessageBox.Show("Please enter an author name to search.");
                    return;
                }

                // Display search results in ListBox
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = SearchBooksByAuthor(txtAuthorName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching books:\n" + ex.Message);
            }
        }

    }
}
