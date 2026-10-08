namespace week3_library
{
    class Book
    {
        private string title;
        private string author;
        private string isbn;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Author
        {
            get { return author; }
            set
            {
                if (!value.Any(char.IsDigit))
                {
                    author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
          
        }
        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (value != "")
                {
                    isbn = value;
                }
                else 
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.title = bookTitle;
            this.author = bookAuthor;
            this.ISBN = bookISBN;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"BookAuthor: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }

    }
}
