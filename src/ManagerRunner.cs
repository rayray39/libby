class ManagerRunner
{
    private static bool isRunning = false;
    private const string lineBreak = "----------------------";

    public static void run(Library library) {
        isRunning = true;

        while (isRunning) {
            Console.WriteLine(lineBreak);
            Console.WriteLine("[add] - add a book to the library");
            Console.WriteLine("[remove] - remove a book from the library");
            Console.WriteLine("[view] - view all books in the library");
            Console.WriteLine("[search] - search for a book in the library");
            Console.WriteLine("[exit] - exit the program");
            Console.WriteLine(lineBreak + "\n");

            string command = Console.ReadLine().Trim().ToLower();

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