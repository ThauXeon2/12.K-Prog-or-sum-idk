namespace MethodsAndClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new("a","b",301);
            Book book2 = new("a", "b", -1);
            Console.WriteLine(book1.Describe());
            Console.WriteLine(book2.Describe());
            Console.WriteLine($"{book1.IsLong()} {book2.IsLong()}");
            Book book3 = new("a", "b");
            Console.WriteLine(book3.Describe());
            Console.WriteLine($"{book3.Borrow()} {book3.Borrow()}");
            book3.Return();
            Console.WriteLine(Book.Count);
            Library library = new("c");
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(new("c","d"));
            library.AddBook(new("d","e"));
            library.PrintAll();
            Console.WriteLine(library.BookCount);
            Console.WriteLine(library.FindByTitle(book1.Title));
            List<Book> book = library.FindByAuthor(book2.Author);
            foreach(Book _book in book) { Console.WriteLine(_book.Describe()); }
        }
    }
}
