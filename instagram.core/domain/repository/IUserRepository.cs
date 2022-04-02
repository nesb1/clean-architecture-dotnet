using ClassLibrary1.domain.model;

namespace ClassLibrary1.domain.repository;

public interface IUserRepository
{
    public User GetUser(long id);
    public User AddUser(string username);
}