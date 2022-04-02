namespace ClassLibrary1.domain.model;

public class Like
{
    public long UserId { get; }

    public Like(long userId)
    {
        UserId = userId;
    }

    public override string ToString()
    {
        return "Лайк от пользователя " + UserId;
    }
}