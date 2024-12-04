// represents a Library that contains,
// Books


class Library
{
    private static int sizeOfLibrary = 5;   // number of Books allowed to hold in Library
    public List<Book> books = new List<Book>();     // initialised to empty list (zero items)

    // adds the book to the library
    public void addBook() {
        Console.WriteLine("Enter the book you would like to add:");
        string bookTitle = Console.ReadLine();

        if (books.Count + 1 > sizeOfLibrary) {
            Console.WriteLine("--- The library is full, book cannot be added ---\n");
            return;
        }
        bookTitle = bookTitle.Trim();
        Book book = new Book(bookTitle);
        books.Add(book);
        Console.WriteLine("--- {0} is successfully added to library ---\n", bookTitle);
        return;
    }

    // removes the book from the library
    public void removeBook() {
        Console.WriteLine("Enter the book you would like to remove:");
        string bookTitle = Console.ReadLine();

        if (!books.Any()) {
            Console.WriteLine("--- The library is empty, no books removed ---");
            return;
        }
        bookTitle = bookTitle.Trim();
        int numberOfBooksRemoved = books.RemoveAll(book => book.Title == bookTitle);
        Console.WriteLine("--- {0} book(s) have been removed ---\n", numberOfBooksRemoved);
    }

    // search for a book in the library, prints msg to indicate found or not found
    public void searchBook() {
        Console.WriteLine("Enter the book you would like to search:");
        string bookTitle = Console.ReadLine();

        if (books.Exists(book => book.Title == bookTitle)) {
            Console.WriteLine("--- {0} is found in the library ---\n", bookTitle);
        } else {
            Console.WriteLine("--- {0} is not found in the library ---\n", bookTitle);
        }
    }

    // prints all the books in the library to the console
    public void viewLibrary() {
        Console.WriteLine("--- List of the library books ---");
        if (!books.Any()) {
            Console.WriteLine("* the library is empty *");
            return;
        }
        foreach (Book book in books)
        {
            Console.WriteLine(book.Title);
        }
    }
}