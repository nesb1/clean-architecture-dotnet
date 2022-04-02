using ClassLibrary1.domain.model;
using ClassLibrary1.domain.repository;

namespace instagram.infrastructure.in_memroy_database;

public class UserRepository: IUserRepository
{
    private Dictionary<long, User> _users = new();
    private long _nextIndex = 1;
    
    public User GetUser(long id)
    {
        return _users[id];
    }

    public User AddUser(string username)
    {
        var user = new User(_nextIndex, username);
        _users[_nextIndex] = user;
        _nextIndex++;
        return user;
    }
}