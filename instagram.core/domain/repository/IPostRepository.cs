using ClassLibrary1.domain.model;

namespace ClassLibrary1.domain.repository;

public interface IPostRepository
{
    public Post GetPost(long id);
    public Post AddPost(long userId, string description, string imageUrl);
}