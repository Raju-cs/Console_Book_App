using Console_App;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        string userInput;

        do
        {
            Console.WriteLine("\nLibrary Menu:");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List Books");
            Console.WriteLine("4. Exit");

            Console.Write("\nChoose an option: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter book author: ");
                    string author = Console.ReadLine();
                    library.AddBook(new Book(title, author));
                    break;

                case "2":
                    Console.Write("Enter the title of the book to remove: ");
                    string titleToRemove = Console.ReadLine();
                    library.RemoveBook(titleToRemove);
                    break;

                case "3":
                    library.ListBooks();
                    break;

                case "4":
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }

        } while (userInput != "4");
    }
}

