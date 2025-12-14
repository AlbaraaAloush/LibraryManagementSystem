using System;

namespace LibraryManagementSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            LibraryService library = new LibraryService();

            IBorrowable book1 = new Book("The Disease and the Cure", "Ibn Al Qayyim", 530);
            IBorrowable dvd1 = new DVD("Surah Al-Mulk", 10);
            library.AddItem(book1);
            library.AddItem(dvd1);
            library.PrintBorrowInfo();

        }
    }
}