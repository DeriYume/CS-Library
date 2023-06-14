namespace LibraryCatalog
{
    public class Library
    {
        public List<Book> BooksList = new List<Book>();

        public void ListOfBooks()
        {
            foreach (Book b in BooksList)
            {
                Console.WriteLine($"Title: {b.Title}, ISBN: {b.ISBN}, Available: {b.IsAvailable}");
            }
        }

        public void AddBooks()
        {
            Book b = new Book();
            Console.Write("ISBN: ");
            b.ISBN = Console.ReadLine();


            Console.Write("Title: ");
            b.Title = Console.ReadLine();

            b.IsAvailable = true;
            BooksList.Add(b);
            Console.WriteLine("You've added a book!");
        }

        public void RemoveBooks()
        {
            Book b = new Book();
            Console.Write("ISBN: ");
            string inputISBN = Console.ReadLine();

            Console.Write("Title: ");
            string inputTitle = Console.ReadLine();

            for (int i = BooksList.Count - 1; i >= 0; i--)
            {
                if (BooksList[i].ISBN == inputISBN && BooksList[i].Title == inputTitle)
                {
                    BooksList.RemoveAt(i);
                    Console.WriteLine("You've removed a book!");
                }
                else
                {
                    Console.WriteLine("This book does not exist!");
                }
            }

        }

        public void CheckOutBooks()
        {
            Book b = new Book();
            Console.Write("ISBN: ");
            string inputISBN = Console.ReadLine();

            Console.Write("Title: ");
            string inputTitle = Console.ReadLine();

            for (int i = BooksList.Count - 1; i >= 0; i--)
            {
                if (BooksList[i].ISBN == inputISBN && BooksList[i].Title == inputTitle)
                {
                    if (BooksList[i].IsAvailable == true)
                    {
                        BooksList[i].IsAvailable = false;
                        BooksList[i].Date = DateTime.Now.AddDays(7);
                        Console.WriteLine("You have to return the book by {0}", BooksList[i].Date.ToString("dd/MM/yyyy"));
                    }
                    else
                    {
                        Console.WriteLine("This book is currently unavailable.");
                    }
                }
                else
                {
                    Console.WriteLine("Error: Wrong input!");
                }
            }
        }

        public void ReturnBooks()
        {
            Book b = new Book();
            Console.Write("ISBN: ");
            string inputISBN = Console.ReadLine();

            Console.Write("Title: ");
            string inputTitle = Console.ReadLine();

            for (int i = BooksList.Count - 1; i >= 0; i--)
            {
                if (BooksList[i].ISBN == inputISBN && BooksList[i].Title == inputTitle)
                {
                    if (BooksList[i].IsAvailable == false)
                    {
                        if (BooksList[i].Date >= DateTime.Now)
                        {
                            BooksList[i].Date = DateTime.Now;
                            BooksList[i].IsAvailable = true;
                            Console.WriteLine("You've returned the book!");
                        }
                        else
                        {
                            BooksList[i].Date = DateTime.Now;
                            BooksList[i].IsAvailable = true;
                            Console.WriteLine("You've returned the book too late. You have to pay a small fee of 2.00$.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("This book is already in our library!");
                    }
                }
            }
        }
    }
}