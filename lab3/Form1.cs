namespace lab3
{
    public partial class Form1 : Form
    {
        private List<Books.Book> bookCollection = new List<Books.Book>();
        public Form1()
        {
            InitializeComponent();
            txtUnique.Enabled = false;
        }

        // METHOD TO DISPLAY BOOKS IN LISTBOX
        private void DisplayBooks(Books.Book[] books)
        {
            listBox1.Items.Clear();

            foreach (var book in books)
            {
                String[] lines = book.GetInfo().Split('\n');
                foreach (var line in lines)
                {
                    listBox1.Items.Add(line);
                }
                listBox1.Items.Add("----------------------------");
            }
        }

        private void btnEnterInfo_Click(object sender, EventArgs e)
        {
            // ADD BOOK INFO TO LISTBOX
            string category = comboCategory.SelectedItem?.ToString() ?? "";
            try
            {
                switch (category)
                {
                    case "Book":
                        var book = new Books.Book
                        {
                            Title = txtBookName.Text,
                            Author = txtAuthor.Text
                        };
                        bookCollection.Add(book);
                        break;
                    case "Magazine":
                        var magazine = new Books.Magazine
                        {
                            Title = txtBookName.Text,
                            Author = txtAuthor.Text,
                            IssueNumber = int.Parse(txtUnique.Text)
                        };
                        bookCollection.Add(magazine);
                        break;
                    case "E-Book":
                        var ebook = new Books.EBook
                        {
                            Title = txtBookName.Text,
                            Author = txtAuthor.Text,
                            FileSizeMB = int.Parse(txtUnique.Text)
                        };
                        bookCollection.Add(ebook);
                        break;
                    case "Textbook":
                        var textbook = new Books.TextBook
                        {
                            Title = txtBookName.Text,
                            Author = txtAuthor.Text,
                            Subject = txtUnique.Text
                        };
                        bookCollection.Add(textbook);
                        break;
                    case "Audiobook":
                        var audiobook = new Books.AudioBook
                        {
                            Title = txtBookName.Text,
                            Author = txtAuthor.Text,
                            DurationMinutes = int.Parse(txtUnique.Text)
                        };
                        bookCollection.Add(audiobook);
                        break;
                }

            } catch (FormatException)
            {
                MessageBox.Show("Please enter valid data for the unique field.");
                return;
            }

            DisplayBooks(bookCollection.ToArray());

            // CLEAR INPUT FIELDS
            txtAuthor.Clear();
            txtBookName.Clear();
            txtUnique.Clear();
            txtUnique.Enabled = false;
            comboCategory.SelectedIndex = -1;
            comboCategory.Text = "Select Category:";
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = comboCategory.SelectedItem?.ToString() ?? "";
            txtUnique.Clear();
            txtUnique.Enabled = true;
            switch (category)
            {
                case "Magazine":
                    txtUnique.PlaceholderText = "Enter Issue Number:";
                    txtUnique.Enabled = true;
                    break;
                case "E-Book":
                    txtUnique.PlaceholderText = "Enter File Size (MB):";
                    txtUnique.Enabled = true;
                    break;
                case "Textbook":
                    txtUnique.PlaceholderText = "Enter Subject:";
                    txtUnique.Enabled = true;
                    break;
                case "Audiobook":
                    txtUnique.PlaceholderText = "Enter Duration (minutes):";
                    txtUnique.Enabled = true;
                    break;
                default:
                    txtUnique.Clear();
                    txtUnique.Enabled = false;
                    break;
            }
        }
    }
}