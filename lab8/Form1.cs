using Newtonsoft.Json.Linq;
using System.Text;

namespace lab8
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        private int currentIndex = 0;
        private const int maxResults = 10;
        private string currentAuthorQuery = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }


        public async Task<string> FetchBookDetailsAsync(string isbn)
        {
            string apiKey = "AIzaSyA-Qlft8vRZnNLylP4kJiLL-zHHIMkOE2A";
            string apiUrl = $"https://www.googleapis.com/books/v1/volumes?q=isbn:{isbn}&key={apiKey}";

            try
            {
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonResponse = JObject.Parse(jsonString);

                if (jsonResponse["items"] == null || !jsonResponse["items"].HasValues)
                {
                    return "Book not found.";
                }

                var volumeInfo = jsonResponse["items"]?[0]?["volumeInfo"];

                var title = volumeInfo?["title"]?.ToString() ?? "N/A";
                var publisher = volumeInfo?["publisher"]?.ToString() ?? "N/A";
                var publishedDate = volumeInfo?["publishedDate"]?.ToString() ?? "N/A";
                var description = volumeInfo?["description"]?.ToString() ?? "No description available.";

                var authorsToken = volumeInfo?["authors"];
                string authors = "N/A";
                if (authorsToken != null)
                {
                    authors = string.Join(", ", authorsToken);
                }

                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"TITLE:      {title}");
                sb.AppendLine($"AUTHOR(S):  {authors}");
                sb.AppendLine($"PUBLISHER:  {publisher} ({publishedDate})");
                sb.AppendLine("--------------------------------------------------");
                sb.AppendLine("DESCRIPTION:");
                sb.AppendLine(description);

                return sb.ToString();
            }
            catch (HttpRequestException ex)
            {
                return $"Error fetching book details: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Error: {ex.Message}";
            }
        }
        public async Task SearchBooksByAuthorAsync(string author, int startIndex)
        {
            string apiKey = "AIzaSyA-Qlft8vRZnNLylP4kJiLL-zHHIMkOE2A";
            string apiUrl = $"https://www.googleapis.com/books/v1/volumes?q=inauthor:{author}&startIndex={startIndex}&maxResults={maxResults}&key={apiKey}";

            try
            {
                var response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                var jsonString = await response.Content.ReadAsStringAsync();
                var jsonResponse = JObject.Parse(jsonString);

                lstBooks.Items.Clear();

                if (jsonResponse["items"] == null)
                {
                    lstBooks.Items.Add("No books found for this author.");
                    return;
                }

                foreach (var item in jsonResponse["items"])
                {
                    var info = item["volumeInfo"];

                    // Get Title
                    var title = info?["title"]?.ToString() ?? "Unknown Title";

                    // Get Publisher
                    var publisher = info?["publisher"]?.ToString();

                    // Format Date
                    var fullDate = info?["publishedDate"]?.ToString() ?? "N/A";
                    var year = (fullDate.Length >= 4) ? fullDate.Substring(0, 4) : fullDate;

                    // Construct the Display String
                    string displayString = $"[{year}]   {title}";

                    if (!string.IsNullOrEmpty(publisher))
                    {
                        displayString += $"  --  {publisher}";
                    }

                    lstBooks.Items.Add(displayString);
                }
                int currentPage = (startIndex / maxResults) + 1;
                lblPage.Text = $"Page {currentPage}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async void btnFetchBook_Click(object sender, EventArgs e)
        {
            var isbn = txtISBN.Text.Trim();

            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Please enter an ISBN.");
                return;
            }

            btnFetchBook.Enabled = false;
            txtBookDetails.Text = "Searching...";

            var bookInfo = await FetchBookDetailsAsync(isbn);
            txtBookDetails.Text = bookInfo;

            txtBookDetails.SelectionStart = 0;
            txtBookDetails.ScrollToCaret();

            btnFetchBook.Enabled = true;
        }
        private async void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text.Trim();
            if (string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Please enter an author name.");
                return;
            }

            // Reset pagination for a new search
            currentIndex = 0;
            currentAuthorQuery = author;
            btnPrev.Enabled = false;
            btnNext.Enabled = true;

            await SearchBooksByAuthorAsync(currentAuthorQuery, currentIndex);
        }

        private async void btnPrev_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentAuthorQuery)) return;
            currentIndex -= maxResults;

            if (currentIndex <= 0)
            {
                currentIndex = 0;
                btnPrev.Enabled = false;
            }

            await SearchBooksByAuthorAsync(currentAuthorQuery, currentIndex);
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentAuthorQuery)) return;
            currentIndex += maxResults;

            await SearchBooksByAuthorAsync(currentAuthorQuery, currentIndex);
            btnPrev.Enabled = true;
        }
    }
}