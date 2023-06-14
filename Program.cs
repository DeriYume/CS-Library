using LibraryCatalog;

Console.WriteLine("Welcome to C# Book Library!");
Console.WriteLine("= * = * = * = M E N U = * = * = * =");
Console.WriteLine("1) List of all the books.");
Console.WriteLine("2) Add a book.");
Console.WriteLine("3) Remove a book.");
Console.WriteLine("4) Checkout a book.");
Console.WriteLine("5) Return a book.");
Console.WriteLine("6) Exit.");
Console.WriteLine("= * = * = * = * = * = * = * = * = * =");
Library library = new Library();



bool key = true;
while (key)
{
    Console.WriteLine();
    Console.Write("Pick an option: ");
    int x = int.Parse(Console.ReadLine());

    switch (x)
    {
        case 1:
            {
                Console.WriteLine("= * = * = * = L I S T = * = * = * =");
                library.ListOfBooks();
                break;
            }
        case 2:
            {
                library.AddBooks();
                break;
            }
        case 3:
            {
                library.RemoveBooks();
                break;
            }
        case 4:
            {
                library.CheckOutBooks();
                break;
            }
        case 5:
            {
                library.ReturnBooks();
                break;
            }
        case 6:
            {
                Console.WriteLine("Bye bye!");
                key = false;
                break;
            }
        default:
            {
                Console.WriteLine("Please pick a valid option!");
                break;
            }
    }

}