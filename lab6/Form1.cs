using lab5;
using Microsoft.EntityFrameworkCore;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public async Task<List<string>> GetBooksAsync(IProgress<int> progress = null)
        {
            using var context = new BookstoreContext();
            var booksList = await context.Books.Include(b => b.Author).ToListAsync();

            List<string> books = new List<string>();
            int total = booksList.Count;

            for (int i = 0; i < total; i++)
            {
                var item = booksList[i];
                books.Add($"ID: {item.BookID} | {item.Title} by {item.Author.Name}");
                progress?.Report((i + 1) * 100 / total);
                await Task.Delay(10); // optional for demo progress
            }

            return books;
        }


        private async void btnFetchBooks_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = 0;

                var progress = new Progress<int>(percent =>
                {
                    progressBar1.Value = percent;
                });

                var books = await GetBooksAsync(progress);
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching books:\n" + ex.Message);
            }
        }


        public async Task SaveBookAsync(string bookTitle, string authorName)
        {
            using var context = new BookstoreContext();

            var author = new Author { Name = authorName };
            var book = new Book { Title = bookTitle, Author = author };

            context.Authors.Add(author);
            context.Books.Add(book);

            await context.SaveChangesAsync();
        }


        private async void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtAuthorName.Text) ||
                    string.IsNullOrWhiteSpace(txtBookTitle.Text))
                {
                    MessageBox.Show("Please enter both author name and book title.");
                    return;
                }

                await SaveBookAsync(txtBookTitle.Text, txtAuthorName.Text);

                MessageBox.Show("Book and Author added successfully!");
                txtBookTitle.Clear();
                txtAuthorName.Clear();

                var books = await GetBooksAsync();
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book:\n" + ex.Message);
            }
        }


        public async Task UpdateBookAsync(int bookID, string newTitle, string newAuthorName, IProgress<int> progress = null)
        {
            using var context = new BookstoreContext();

            var book = await context.Books.Include(b => b.Author)
                                          .FirstOrDefaultAsync(b => b.BookID == bookID);
            if (book == null) throw new Exception("Book not found.");

            if (!string.IsNullOrWhiteSpace(newTitle))
                book.Title = newTitle;

            if (!string.IsNullOrWhiteSpace(newAuthorName) && book.Author != null)
                book.Author.Name = newAuthorName;

            await context.SaveChangesAsync();
            progress?.Report(100);
        }

        private async void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBookID.Text, out int bookID))
                {
                    MessageBox.Show("Invalid Book ID.");
                    return;
                }

                progressBar1.Value = 0;
                var progress = new Progress<int>(percent => progressBar1.Value = percent);

                await UpdateBookAsync(bookID, txtBookTitle.Text, txtAuthorName.Text, progress);

                MessageBox.Show("Book updated successfully!");

                txtBookID.Clear();
                txtBookTitle.Clear();
                txtAuthorName.Clear();

                var books = await GetBooksAsync(progress);
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book:\n" + ex.Message);
            }
        }

        public async Task DeleteBookAsync(int bookID, IProgress<int> progress = null)
        {
            using var context = new BookstoreContext();

            var book = await context.Books.FirstOrDefaultAsync(b => b.BookID == bookID);
            if (book == null) throw new Exception("Book not found.");

            context.Books.Remove(book);
            await context.SaveChangesAsync();
            progress?.Report(100);
        }

        private async void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtBookID.Text, out int bookID))
                {
                    MessageBox.Show("Invalid Book ID.");
                    return;
                }

                progressBar1.Value = 0;
                var progress = new Progress<int>(percent => progressBar1.Value = percent);

                await DeleteBookAsync(bookID, progress);

                MessageBox.Show("Book deleted successfully!");
                txtBookID.Clear();

                var books = await GetBooksAsync(progress);
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = books;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting book:\n" + ex.Message);
            }
        }

        public async Task<List<string>> SearchBooksAsync(string searchTitle, IProgress<int> progress = null)
        {
            using var context = new BookstoreContext();
            var query = context.Books.Include(b => b.Author)
                                     .Where(b => b.Title.Contains(searchTitle));

            var booksList = await query.ToListAsync();

            List<string> results = new List<string>();
            int total = booksList.Count;

            for (int i = 0; i < total; i++)
            {
                var b = booksList[i];
                results.Add($"ID: {b.BookID} | {b.Title} by {b.Author.Name}");
                progress?.Report((i + 1) * 100 / total);
                await Task.Delay(50);
            }

            return results;
        }

        private async void btnSearchBook_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtBookTitle.Text.Trim();
                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Enter a book title to search.");
                    return;
                }

                progressBar1.Value = 0;
                var progress = new Progress<int>(percent => progressBar1.Value = percent);

                var results = await SearchBooksAsync(title, progress);
                listBoxBooks.DataSource = null;
                listBoxBooks.DataSource = results;

                if (results.Count == 0)
                    MessageBox.Show("No books found with that title.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching books:\n" + ex.Message);
            }
        }
    }
}
