namespace week3_library
{
    public class Book
    {
       public string Title;
        public string Author;
        public string ISBN;


        public void DisplayInfo()
        {
            Console.WriteLine($"Book Title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }   
    }
}
