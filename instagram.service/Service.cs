using ClassLibrary1.domain.model;
using ClassLibrary1.domain.repository;

namespace instagram.service;

public class InstagramService
{
    private IUserRepository _userRepository;
    private IPostRepository _postRepository;
    
    public InstagramService(IUserRepository userRepository,
        IPostRepository post_repository)
    {
        _userRepository = userRepository;
        _postRepository = post_repository;
    }

    public User AddUser(string username)
    {
        return _userRepository.AddUser(username);
    }

    public User GetUser(long userId)
    {
        return _userRepository.GetUser(userId);
    }

    public Post GetPost(long postId)
    {
        return _postRepository.GetPost(postId);
    }

    public Post AddPost(long userId, string description, string imageUrl)
    {
        return _postRepository.AddPost(userId, description, imageUrl);
    }

    public List<Like> GetPostLikes(long postId)
    {
        return _postRepository.GetPost(postId).Likes;
    }

    public Like AddLike(long userId, long postId)
    {
        var post = _postRepository.GetPost(postId);
        return post.AddLike(userId);
    }
}