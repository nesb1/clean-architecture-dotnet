namespace ClassLibrary1.domain.model;

public class User
{
    public long UserId { get; }
    public string Username { get; }

    public User(long userId, string username)
    {
        UserId = userId;
        Username = username;
    }

    public override string ToString()
    {
        return UserId + " " + Username;
    }
}