namespace lab3
{
    public partial class Form1 : Form
    {
        private List<Book> bookCollection = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            txtUnique.Enabled = false;
        }

        public class Book
        {
            public string? Title { get; set; }
            public string? Author { get; set; }
            public virtual string Category => "Book";

            public virtual string GetInfo()
            {
                return $"Category: {Category}\nTitle: {Title}\nAuthor: {Author}";
            }
        }

        // Derived classes
        public class Magazine : Book
        {
            public int IssueNumber { get; set; }
            public override string Category => "Magazine";
            public override string GetInfo()
            {
                return $"{base.GetInfo()}\nIssue Number: {IssueNumber}";
            }
        }
        public class EBook : Book
        {
            public int FileSizeMB { get; set; }
            public override string Category => "E-Book";

            public override string GetInfo()
            {
                return $"{base.GetInfo()}\nFile Size: {FileSizeMB} MB";
            }
        }
        public class TextBook : Book
        {
            public string? Subject { get; set; }
            public override string Category => "Textbook";

            public override string GetInfo()
            {
                return $"{base.GetInfo()}\nSubject: {Subject}";
            }
        }
        public class AudioBook : Book
        {
            public int DurationMinutes { get; set; }
            public override string Category => "Audiobook";

            public override string GetInfo()
            {
                return $"{base.GetInfo()}\nDuration: {DurationMinutes} minutes";
            }
        }



        // METHOD TO DISPLAY BOOKS IN LISTBOX
        private void DisplayBooks(Book[] books)
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
                        var book = new Book
                        {
                            Title = txtBookName.Text,
                            Author = txtAuthor.Text
                        };
                        bookCollection.Add(book);
                        break;
                    case "Magazine":
                        var magazine = new Magazine
                        {
                            Title = txtBookName.Text,
                            Author = txtAuthor.Text,
                            IssueNumber = int.Parse(txtUnique.Text)
                        };
                        bookCollection.Add(magazine);
                        break;
                    case "E-Book":
                        var ebook = new EBook
                        {
                            Title = txtBookName.Text,
                            Author = txtAuthor.Text,
                            FileSizeMB = int.Parse(txtUnique.Text)
                        };
                        bookCollection.Add(ebook);
                        break;
                    case "Textbook":
                        var textbook = new TextBook
                        {
                            Title = txtBookName.Text,
                            Author = txtAuthor.Text,
                            Subject = txtUnique.Text
                        };
                        bookCollection.Add(textbook);
                        break;
                    case "Audiobook":
                        var audiobook = new AudioBook
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