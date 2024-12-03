// represents a Book that contains,
// title

class Book
{
    // field title
    private string title;

    // property title
    public string Title
    {
        get { return title; }
        set { 
            if (value == string.Empty) {
                title = "no title";
            } else {
                title = value;
            }
        }
    }

    public Book(string title) {
        Title = title;
    }

}