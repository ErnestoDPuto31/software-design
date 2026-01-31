using Lab7;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace lab7
{
    public partial class Form1 : Form
    {
        private BookstoreContext _context = new BookstoreContext();
        private int currentPage = 1;

        public Form1()
        {
            InitializeComponent();
            this.Load += async (s, e) => await RefreshDataGrid();
        }

        private async Task RefreshDataGrid()
        {
            listBoxBooks.DataSource = await GetBooksByPageAsync(currentPage);
            lblPageNumber.Text = $"{currentPage}";
            btnPreviousPage.Enabled = currentPage > 1;
        }

        // Task 1: Pagination with Exception Handling
        public async Task<List<string>> GetBooksByPageAsync(int pageNumber)
        {
            const int PageSize = 10;
            try
            {
                return await _context.Books
                    .Include(b => b.Author) // Joins the Authors table
                    .OrderBy(b => b.BookId)
                    .Skip((pageNumber - 1) * PageSize)
                    .Take(PageSize)
                    .Select(b => $"{b.Title}, {(b.Author != null ? b.Author.Name : "Unknown")}")
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                return new List<string>();
            }
        }

        private async void btnNextPage_Click(object sender, EventArgs e)
        {
            currentPage++;
            var data = await GetBooksByPageAsync(currentPage);

            if (data.Any())
            {
                listBoxBooks.DataSource = data;
                lblPageNumber.Text = $"{currentPage}";
                btnPreviousPage.Enabled = true;
            }
            else
            {
                currentPage--;
                MessageBox.Show("No more books to show.");
            }
        }

        private async void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                await RefreshDataGrid();
                listBoxBooks.DataSource = await GetBooksByPageAsync(currentPage);
                lblPageNumber.Text = $"{currentPage}";
            }
        }

        // Task 2: Save Book with Exception Handling
        public async Task SaveBookWithHandlingAsync(string bookTitle, string authorName)
        {
            try
            {
                var author = await _context.Authors
                    .FirstOrDefaultAsync(a => a.Name == authorName);

                if (author == null)
                {
                    author = new Author { Name = authorName };
                    _context.Authors.Add(author);
                }

                var newBook = new Book { Title = bookTitle, Author = author };
                _context.Books.Add(newBook);

                await _context.SaveChangesAsync();
                MessageBox.Show($"Saved '{bookTitle}' by {authorName}!");
                await RefreshDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save Error: {ex.Message}");
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            await SaveBookWithHandlingAsync(txtTitle.Text, txtAuthor.Text);
            txtTitle.Clear();
            txtAuthor.Clear();
        }

        // Task 3: Export Books to File
        public async Task ExportBooksAsync(string filePath)
        {
            try
            {
                var books = await _context.Books.Include(b => b.Author).ToListAsync();
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var b in books)
                    {
                        string authorName = b.Author?.Name ?? "Unknown Author";
                        await writer.WriteLineAsync($"{b.Title}, {authorName}");
                    }
                }
                MessageBox.Show($"Exported {books.Count} books to {filePath}");
            }
            catch (IOException ioEx)
            {
                MessageBox.Show($"File I/O Error: {ioEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private async void btnExportBooks_Click(object sender, EventArgs e)
        {
            await ExportBooksAsync("BookstoreExport.txt");
        }

        // Task 4: Search Books with Exception Handling and Import from File
        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string term = txtSearch.Text.ToLower();
            var results = await _context.Books
                .Include(b => b.Author)
                .Where(b => b.Title.ToLower().Contains(term) || b.Author.Name.ToLower().Contains(term))
                .Select(b => $"{b.Title} (Author: {b.Author.Name})")
                .ToListAsync();
            listBoxBooks.DataSource = results;
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = await File.ReadAllLinesAsync(openFileDialog.FileName);

                        int count = 0;
                        foreach (string line in lines)
                        {
                            var parts = line.Split(',');
                            if (parts.Length == 2)
                            {
                                await SaveBookWithHandlingAsync(parts[0].Trim(), parts[1].Trim());
                                count++;
                            }
                        }

                        MessageBox.Show($"Successfully imported {count} books!", "Success");
                        listBoxBooks.DataSource = await GetBooksByPageAsync(currentPage);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Import failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
