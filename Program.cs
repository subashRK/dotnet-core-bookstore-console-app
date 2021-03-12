using System;

namespace BookStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Book Store");
            LeaveLine();

            while (true)
            {
                LogInformation();
                string option = Console.ReadLine();

                if (option == "1") {
                    AddBook();
                } else if (option == "2") {
                    DisplayBooks();
                } else {
                    break;
                }
            }

            LeaveLine();
        }

        private static void AddBook()
        {
            Console.Write("Enter the title of your book: ");
            string title = Console.ReadLine();

            while (title.Trim() == "")
            {
                Console.Write("Enter the correct title for your book: ");
                title = Console.ReadLine();
            }

            Console.Write("Enter the price of your book (Leave blank or type some ohter values to set the price as 0 dollars) : ");
            try {
                double price = Convert.ToDouble(Console.ReadLine());
                
                Book book = new Book(title, price);
                BookList.AddBook(book);
            } catch (Exception) {
                Book book = new Book(title);
                BookList.AddBook(book);
            }
        }

        private static void DisplayBooks()
        {
            BookList.DisplayBooks();
        }

        private static void LogInformation()
        {
            Console.WriteLine("Press,");
            LeaveLine();
            Console.WriteLine("1 -> To add a book");
            Console.WriteLine("2 -> To See all the books");
            Console.WriteLine("Any key -> To exit the program");
            LeaveLine();
            Console.Write(">>> ");
        }

        private static void LeaveLine()
        {
            Console.WriteLine();
        }
    }
}
