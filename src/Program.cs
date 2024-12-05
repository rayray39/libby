// See https://aka.ms/new-console-template for more information


using System.Text.Json;

class Program
{
    public static async Task Main(string[] args)
    {
        // main entry point of application
        Library library = new Library();

        Console.WriteLine("\nWelcome to Libby!");
        Console.WriteLine("Who would you like to login as?");
        Console.WriteLine("[manager] - manages the library");
        Console.WriteLine("[client] - use the library's services");

        string user = Console.ReadLine().Trim().ToLower();

        if (user == "manager") {
            // logged in as manager
            // library for manager should have write and read access
            ManagerRunner manager = new ManagerRunner(new Manager("Jane"));
            manager.Run(library);
        } else if (user == "client") {
            // logged in as client
            // library for client should only have read access.
            ClientRunner client = new ClientRunner(new Client("Joe"));
            client.Run(library);
        }

        library.save();
    }
}
