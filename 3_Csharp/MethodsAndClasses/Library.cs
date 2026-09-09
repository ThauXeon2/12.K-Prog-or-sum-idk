using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace MethodsAndClasses
{
    public class Library
    {
        string Name {  get; set; }
        private List<Book> _books;
        public Library(string name)
        {
            Name = name;
            _books = new List<Book>();
        }
        public void AddBook(Book book)=>_books.Add(book);
        public void PrintAll()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine(book.Describe());
            }
        }
        public int BookCount { get { return _books.Count; }}
        public string FindByTitle(string title)
        {
            var titleFind = _books.Where(x=>x.Title==title).Select(x=>x.Describe()).FirstOrDefault();
            return titleFind ?? "null";
        }
        public List<Book> FindByAuthor(string author)
        {
            List<Book> book = _books.Where(x=>x.Author==author).ToList();
            return book;
        }
    }
}
