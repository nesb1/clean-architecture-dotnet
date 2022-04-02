

namespace ClassLibrary1.domain.model;

public class Post
{
    public Post(long postId,long userId, string description, string imageUrl)
    {
        PostId = postId;
        UserId = userId;
        Description = description;
        ImageUrl = imageUrl;
        Likes = new List<Like>();
    }
    
    public long PostId { get; }
    
    public long UserId { get; }
    public string Description { get; }
    
    public string ImageUrl { get; }
    
    public List<Like> Likes { get; }

    public override string ToString()
    {
        return PostId + " " + Description + " " + UserId;
    }

    public Like AddLike(long fromUserId)
    {
        if (Likes.Any(like => like.UserId == fromUserId))
        {
            throw new Exception("Лайк от этого пользователя уже поставлен");
        }

        var like = new Like(fromUserId);
        Likes.Add(like);
        return like;
    }
}