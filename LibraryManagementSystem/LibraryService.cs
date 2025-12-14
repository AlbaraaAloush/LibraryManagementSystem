using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class LibraryService
    {
        private List<IBorrowable> borrowableItems;

        public LibraryService()
        {
            borrowableItems = new List<IBorrowable>();
        }

        public List<IBorrowable> BorrowableItems
        {
            get => borrowableItems;
        }

        public void AddItem(IBorrowable item)
        {
            borrowableItems.Add(item);
        }
        public void PrintBorrowInfo()
        {
            // use var keyword to iterate over different object types
            foreach (var item in borrowableItems)
            {
                // item here calls ToString for the object
                Console.WriteLine($"Type: {item.GetType().Name}, {item}, Borrow Duration: {item.GetBorrowDuration()} days");
            }
        }

    }
}
