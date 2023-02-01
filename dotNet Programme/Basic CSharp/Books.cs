using System;//Default APIs
using Entities;//For the Entity class
using Repository;//Repo class
using BasicsCSharp; //Utilities

namespace Entities
{
    class Books
    {
        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }
        public int BookStock { get; set; } = 10;

        public void ShallowCopy(Books copy)
        {
            this.BookId = copy.BookId;
            this.BookStock = copy.BookStock;
            this.BookTitle = copy.BookTitle;
            this.Price = copy.Price;
            this.Publisher = copy.Publisher;
            this.Author = copy.Author;
        }

        public Books DeepCopy(Books copy)
        {
            Books book = new Books();
            book.ShallowCopy(copy);
            return book;
        }
    }
}
//datatype [] identifier = new datatype[size]
namespace Repository
{
    class BookRepository
    {
        private Books[] _books = null;
        private readonly int _size = 0;
        public BookRepository(int size)
        {
            _size = size;
            _books = new Books[_size];
        }

        public int AddNewBook(Books book)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] == null)
                {
                    _books[i] = book.DeepCopy(book);
                    return 1;//To exit
                }
            }
            return _size;
        }

        public void UpdateBook(Books book)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] != null && _books[i].BookId == book.BookId)
                {
                    _books[i].ShallowCopy(book);
                    return;//To exit
                }
            }
            throw new Exception("No book found to update");
        }

        public void RemoveBook(int id)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_books[i] != null && _books[i].BookId == id)
                {
                    _books[i] = null;
                    return;//To exit
                }
            }
            throw new Exception("No book found to remove");
        }

        public Books[] FindByAuthor(string author)
        {
            int count = 0;
            foreach (Books book in _books)
            {
                if (book != null && book.Author.Contains(author))
                {
                    count += 1;
                }
            }
            Books[] books = new Books[count];
            count = 0;
            foreach (Books book in _books)
            {
                if (book != null && book.Author.Contains(author))
                {
                    books[count] = book.DeepCopy(book);
                    count += 1;
                }
            }
            return books;
        }

        public Books[] FindByTitle(string title)
        {
            int count = 0;
            foreach (Books book in _books)
            {
                if (book != null && book.BookTitle.Contains(title))
                {
                    count += 1;
                }
            }
            Books[] books = new Books[count];
            count = 0;
            foreach (Books book in _books)
            {
                if (book != null && book.BookTitle.Contains(title))
                {
                    books[count] = book.DeepCopy(book);
                    count += 1;
                }
            }
            return books;
        }
    }
}

namespace UILayer
{
    class UIComponent
    {
        public const string menu = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~BOOK STORE MANAGER SOFTWARE~~~~~~~~~~~~~~~~~~~\nTO ADD NEW BOOK------------------------>PRESS 1\nTO UPDATE EXISTING BOOK---------------->PRESS 2\nTO FIND BOOK BY AUTHOR----------------->PRESS 3\nTO FIND BOOK BY TITLE------------------>PRESS 4\nTO DELETE BOOK------------------------->PRESS 5\nPS: ANY OTHER KEY IS CONSIDERED AS EXIT.....................................";

       public static BookRepository BookRepository;
       

        public static void Run()
        {
            int size = Utilities.GetNumber("Enter the no of Books U need for the Store");
            BookRepository = new BookRepository(size);
            bool processing = true;
            do
            {
                string choice = Utilities.Prompt(menu);
                processing = processMenu(choice);
            } while (processing);
            Console.WriteLine("Thanks for Using our Application!!!");
        }
        private static void addingAccountHelper()
        {
            int id = Utilities.GetNumber("Enter the ID of the Account");
            int stock = Utilities.GetNumber("Enter the No of stock");
            string name = Utilities.Prompt("Enter the Name of the Book");
            int price = Utilities.GetNumber("Enter the price");
            string publisher = Utilities.Prompt("Enter the Name of the Publisher");
            string author = Utilities.Prompt("Enter the Name of the author");
            Books book = new Books { BookId = id, BookStock = stock, BookTitle =name,Price=price,Publisher=publisher,Author=author};
            BookRepository.AddNewBook(book);
            Console.WriteLine("book added");
            Utilities.Prompt("Press Enter to clear the Screen");
            Console.Clear();
        }

        private static void updatingBookHelper()
        {
            int id = Utilities.GetNumber("Enter the ID of the Account");
            int stock = Utilities.GetNumber("Enter the No of stock");
            string name = Utilities.Prompt("Enter the Name of the Book");
            int price = Utilities.GetNumber("Enter the price");
            string publisher = Utilities.Prompt("Enter the Name of the Publisher");
            string author = Utilities.Prompt("Enter the Name of the author");
            Books book = new Books { BookId = id, BookStock = stock, BookTitle = name, Price = price, Publisher = publisher, Author = author };
            BookRepository.UpdateBook(book);
            Console.WriteLine("book updated");
            Utilities.Prompt("Press Enter to clear the Screen");
            Console.Clear();
        }

        //private static void DsiplayAll()
        //{

        //    foreach (string item in BookRepository)
        //    {
        //        Console.WriteLine(item);
        //        //Console.WriteLine($"The Name of Author : {repo.}\n No Of stocks : {bk.BookStock}\nBook Name: {bk.BookTitle}\n";)
        //    }
        
        //}

        //private static void findingbookbyAuthorHelper()
        //{
        //    String authr = Utilities.Prompt("Enter the Aythor name");
        //    try
        //    {
        //       Books bk = BookRepository.FindByAuthor(authr) ;
        //        Console.WriteLine("The Details of the Account are as follows:");
        //        string content = $"The Name of Author : {bk.Author}\n No Of stocks : {bk.BookStock}\nBook Name: {bk.BookTitle}\n";
        //        Console.WriteLine(content);
        //        Utilities.Prompt("Press Enter to clear the Screen");
        //        Console.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //}





        private static bool processMenu(string choice)
        {
            switch (choice)
            {
                case "1":
                    addingAccountHelper();
                    break;
                case "2":
                    updatingBookHelper();
                    break;
                case "3":
                   // RemoveBook();
                    break;
                case "4":
                    // findingbookbyAuthorHelper();
                    break;
                case "5":
                    //DisplayAll();
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}

namespace TestingApp
{
    using Repository;
    using BasicsCSharp;
    using System;


    class App
    {
        static void Main(string[] args)
        {
            UILayer.UIComponent.Run();
        }
    }
}
