// See https://aka.ms/new-console-template for more information


using System.Text.Json;

class Program
{
    private static Library library = new Library();
    public static async Task Main(string[] args)
    {
        // main entry point of application

        Console.WriteLine("Welcome to fullstack library!");
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

        // serialising the library data
        string filePath = ".\\data_manager";
        string fileName = filePath + "\\m_library.json";
        if (Directory.Exists(filePath)) {
            Console.WriteLine("the json file exists");
        } else {
            DirectoryInfo di = Directory.CreateDirectory(filePath);
            await using FileStream createStream = File.Create(fileName);
            var options = new JsonSerializerOptions { WriteIndented = true };
            await JsonSerializer.SerializeAsync(createStream, library.books, options);
        }
        
    }
}
