// See https://aka.ms/new-console-template for more information


class Program
{
    private static Library library = new Library();
    public static void Main(string[] args)
    {
        // main entry point of application

        Console.WriteLine("Welcome to fullstack library!");
        Console.WriteLine("Who would you like to login as?");
        Console.WriteLine("[manager] - manages the library");
        Console.WriteLine("[client] - use the library's services");

        string user = Console.ReadLine().Trim().ToLower();

        if (user == "manager") {
            // logged in as manager
            ManagerRunner.run(library);
        } else if (user == "client") {
            // logged in as client
            ClientRunner.run(library);
        }
    }
}
