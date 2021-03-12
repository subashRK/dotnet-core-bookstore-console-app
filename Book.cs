using System;

namespace BookStore
{
  public class Book
  {
    public string Title;
    public double Price = 0.0;

    public Book(string title)
    {
      this.Title = title;
    }

    public Book(string title, double price) : this(title)
    {
      this.Price = price;
    }
  }
}
