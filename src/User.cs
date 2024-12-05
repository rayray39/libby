class User
{
    // public string name;    // name of user

    // property name, readonly
    public string Name{ get; init; }
     
    public User(string name) {
        Name = name;
    }

    public void greet() {
        Console.WriteLine("You are now logged in as {0}\n", Name );
    }
}