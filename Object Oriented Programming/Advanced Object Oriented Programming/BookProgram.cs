using System;
using System.Linq;

namespace Advanced_Application_Programming
{
    public record Book
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public int Pages { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }

        public Book(string iSBN, string author, string title, int pages, decimal price, int year)
        {
            this.ISBN = iSBN;
            this.Author = author;
            this.Title = title;
            this.Pages = pages;
            this.Price = price;
            this.Year = year;
        }

        public void Input()
        {

            Console.Write("Enter ISBN:> ");
            this.ISBN = Console.ReadLine();
            Console.Write("Enter Author:> ");
            this.Author = Console.ReadLine();
            Console.Write("Enter Book Title:> ");
            this.Title = Console.ReadLine();
            Console.Write("Enter number of pages:> ");
            this.Pages = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter price:> ");
            this.Price = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter Year of Publication:> ");
            this.Year = Convert.ToInt32(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("ISBN: {0}\nAuthor: {1}\nTitle: {2}\nNumber of pages: {3}\nPrice: {4:#,#.00}\nYear: {5}\n\n", this.ISBN, this.Author, this.Title, this.Pages, this.Price, this.Year);
        }
    }
    public class BookProgram
    {
        public static void Main(string[] args)
        {
            Book[] books = {new Book("123-456-789", "John Smith", "The Great Outdoors", 256, 2999m, 2020),
                new Book("987-654-321", "Jane Doe", "The Inner World", 320, 2499m, 2019),
                new Book("456-789-123", "Bob Johnson", "Exploring the Cosmos", 432, 3999m, 2021),
                new Book("321-654-987", "Sara Williams", "The Secret Life of Cats", 256, 2999m, 2020),
                new Book("789-123-456", "Michael Brown", "The Art of Cooking", 384, 3499m, 2020),
                new Book("654-321-987", "Emily Davis", "The Wonders of Nature", 448, 4499m, 2022),
                new Book("111-222-333", "James Taylor", "The History of Rome", 512, 4999m, 2020),
                new Book("333-222-111", "Emily Thompson", "The Science of Psychology", 320, 2999m, 2020),
                new Book("222-333-111", "David Scott", "The Mystery of the Universe", 256, 2499m, 2021),
                new Book("111-333-222", "Caroline Smith", "The Art of Drawing", 320, 2999m, 2020)};

            Array.ForEach(books.Where((Book b) => b.Price > 3500 && b.Pages > 400).ToArray(), (Book b) => b.Output());

            //OR
            /* foreach (Book b in books)
            {
                if (b.Price > 3500 && b.Pages > 400)
                    b.Output();
            } */
        }
    }
}
