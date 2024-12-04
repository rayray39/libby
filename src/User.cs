class User
{
    public required string name;    // name of user

    // property name, readonly
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public User(string name) {
        Name = name;
    }
}