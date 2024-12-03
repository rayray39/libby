// See https://aka.ms/new-console-template for more information


class Program
{
    private static bool isRunning = true;
    private static Library library = new Library();
    private const string lineBreak = "----------------------";

    public static void Main(string[] args)
    {
        // main entry point of application

        Console.WriteLine("Welcome to fullstack library!");
        Console.WriteLine("What would you like to do today?");

        while (isRunning)
        {
            Console.WriteLine(lineBreak);
            Console.WriteLine("[add] - add a book to the library");
            Console.WriteLine("[remove] - remove a book from the library");
            Console.WriteLine("[view] - view all books in the library");
            Console.WriteLine("[search] - search for a book in the library");
            Console.WriteLine("[exit] - exit the program");
            Console.WriteLine(lineBreak + "\n");

            string command = Console.ReadLine();

            switch (command)
            {
                case "exit" : 
                    isRunning = false;
                    break;
                case "add" :
                    library.addBook();
                    break;
                case "remove" :
                    library.removeBook();
                    break;
                case "search" :
                    library.searchBook();
                    break;
                case "view" :
                    library.viewLibrary();
                    break;
                default:
                    Console.WriteLine("Please enter a valid command");
                    break;
            }
        }
    }
}
