using LibraryManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
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
                if(String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Author cannot be null or empty");
                author = value;
            }   
        
        }

        public int PageCount
        {
            get => pageCount;
            private set
            {
                pageCount = value >= 1 ? value : throw new ArgumentOutOfRangeException(nameof(value), value, "Page Count cannot be less than 1");
            }
        }

        public Book(string title, string author, int pageCount)
            : base(title)
        {
            Author = author;
            PageCount = pageCount;
        }

        public override int GetBorrowDuration()
        {
            return 14;
        }
        public override string ToString()
        {
            return $"{base.ToString()} | Author: {Author}, Pages: {PageCount} ";
        }
    }
}
