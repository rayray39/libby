class ClientRunner : Runner
{
    public ClientRunner(User client) : base(client) {
        
    }

    public override void Run(Library library) {
        isRunning = true;
        base.user.greet();

        while (isRunning) {
            Console.WriteLine(lineBreak);
            Console.WriteLine("[view] - view all books in the library");
            Console.WriteLine("[search] - search for a book in the library");
            Console.WriteLine("[checkout] - checkout/borrow a book");
            Console.WriteLine("[exit] - exit the program");
            Console.WriteLine(lineBreak + "\n");

            string command = Console.ReadLine().Trim().ToLower();

            switch (command)
            {
                case "exit" : 
                    isRunning = false;
                    break;
                case "search" :
                    library.searchBook();
                    break;
                case "view" :
                    library.viewLibrary();
                    break;
                case "checkout" :
                    library.checkout();
                    break;
                default:
                    Console.WriteLine("Please enter a valid command");
                    break;
            }
        }
    }
}