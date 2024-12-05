class Client : User
{
    public List<Book> borrowedBooks = new List<Book>();     // initialised to empty list (zero items)

    public Client(string name) : base(name) {

    }
}