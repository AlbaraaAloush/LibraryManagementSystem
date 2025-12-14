using LibraryManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMangementSystem
{
    internal class Book : LibraryItem
    {
        private string author;
        private int pageCount;

        public string Author
        {
            get => author;
            private set
            {
                if(String.IsNullOrWhiteSpace(Author))
                    throw new ArgumentException("Author cannot be null or empty");
                author = value;
            }   
        
        }

        public int PageCount
        {
            get => pageCount;
            set
            {
                pageCount = value >= 1 ? value : throw new ArgumentException("Page Count cannot be less than 1");
            }
        }

        public Book(string title, string author, int pageCount)
            : base(title)
        {
            Author = author;
            PageCount = pageCount;
        }

        public string ToString()
        {
            return $"{base.ToString} | Author: {Author}, Pages: {PageCount} ";
        }
    }
}
