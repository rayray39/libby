abstract class Runner
{
    protected static bool isRunning = false;
    protected const string lineBreak = "----------------------";
    protected User user;

    protected Runner(User assignedUser) {
        user = assignedUser;
    }

    public abstract void Run(Library library);

}