using ClassLibrary1.domain.model;
using ClassLibrary1.domain.repository;

namespace instagram.infrastructure.in_memroy_database;

public class PostRepository: IPostRepository
{
    private Dictionary<long, Post> _posts = new();
    private long _nextIndex = 1;
    
    public Post GetPost(long id)
    {
        return _posts[id];
    }

    public Post AddPost(long userId, string description, string imageUrl)
    {
        var post = new Post(_nextIndex,userId, description, imageUrl);
        _posts[_nextIndex] = post;
        _nextIndex++;
        return post;
    }
}