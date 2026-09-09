using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MethodsAndClasses
{
    public class Book
    {
        public string Title { get; set; }
        public string Author {  get; set; }
        private int _pageCount;
        public int PageCount
        {
            get
            {
                return _pageCount;
            }
            set
            {
                if (value >= 0)
                    _pageCount = value;
                else
                    _pageCount = 0;
            }
        }
        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount=pageCount;
            Count++;
        }

        public string Describe() => $"Szerző: {Author}, Cím: {Title}, Oldalszám: {PageCount}";
        public bool IsLong() => PageCount > 300;
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            PageCount = 0;
            Count++;
        }
        bool IsAvailable { get; set; } = true;
        public bool Borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                return true;
            }
            else
                return false;
        }
        public void Return() => IsAvailable = true;
        public static int Count { get; set; }
    }
}
