namespace lab3
{
    public class Books
    {
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

    }
}
