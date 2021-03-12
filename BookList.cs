using System;
using System.Collections.Generic;

namespace BookStore
{
  public class BookList
  {
    private static List<Book> _books = new List<Book>();

    public static void AddBook(Book book)
    {
      _books.Add(book);
    }

    public static void DisplayBooks()
    {
      if (_books.Count == 0) {
        Console.WriteLine();
        Console.WriteLine("No books have been registered yet.");
        Console.WriteLine();
      } else {
        foreach (Book item in _books)
        {
            Console.WriteLine();
            Console.WriteLine("Book Title: {0}", item.Title);
            Console.WriteLine("Book Price: ${0}", item.Price);
            Console.WriteLine();
        }
      }
    }
  }
}
