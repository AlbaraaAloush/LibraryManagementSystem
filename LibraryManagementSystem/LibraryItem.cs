using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace LibraryManagementSystem
{
    internal abstract class LibraryItem : IBorrowable
    {
        // Static member (shared across all instances)
        private static int nextId = 1;

        // Backing field (protected by a property)
        private string title;

        // Properties 
        public int Id { get; }

        public string Title
        {
            // same as get {return title;}
            get => title;
            // private set to allow setting the value only when inistantiating an object using constructor
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title cannot be null or empty.");

                title = value;
            }
        }

        public bool IsAvailable { get; private set; }

        protected LibraryItem(string title)
        {
            // Id iss assigned origirnal value, and then incremented
            Id = nextId++;
            Title = title;
            IsAvailable = true;
        }

        public virtual int GetBorrowDuration()
        {
            return 15;
        }
        
        // C# provides default ToString method for all objects, so we need to override it and write our own method
        public override string ToString()
        {
            return $"[{Id}] {Title} - Available: {IsAvailable}";
        }
    }
}
