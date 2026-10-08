using week3_library;

class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("C# for beginners", "Bill Gates", "1234567");
        Book book1 = new Book("Ultimate C# Guide", "Steve Jobs", "7654321");

        Console.WriteLine("Currently available books:");
        book.DisplayInfo();
        book1.DisplayInfo();

        Member member  = new Member(1, "John Doe", "123 Main St", "555-1234");
        Member member1 = new Member(2, "Jane Smith", "456 Elm St", "555-5678");
        

        Console.WriteLine("Current library members:");
        member.DisplayInfo();
        member1.DisplayInfo();
    }
}
