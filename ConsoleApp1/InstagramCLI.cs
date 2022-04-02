using System.Text;
using instagram.service;

namespace ConsoleApp1;

public class InstagramCLI
{
    private InstagramService _instagramService;

    public InstagramCLI(InstagramService instagramService)
    {
        _instagramService = instagramService;
    }

    public string runCommand(string command)
    {
        var parts = command.Split(" ");
        object result;

        switch (parts[0])
        {
            case "add_user":
                result =_instagramService.AddUser(parts[1]);
                return result.ToString();
            
            case "get_user":
                result =_instagramService.GetUser(long.Parse(parts[1]));
                return result.ToString();
            
            case "add_post":
                result = _instagramService.AddPost(long.Parse(parts[1]), parts[2], parts[3]);
                return result.ToString();
            
            case "get_post":
                result = _instagramService.GetPost(long.Parse(parts[1]));
                return result.ToString();
            
            case "add_like":
                result = _instagramService.AddLike(long.Parse(parts[1]), long.Parse(parts[2]));
                return result.ToString();
            
            case "get_post_likes":
                var likes = _instagramService.GetPostLikes(long.Parse(parts[1]));
                var sb = new StringBuilder("Лайки от пользователей: ");
                foreach (var like in likes)
                {
                    sb.Append(like.UserId);
                    sb.Append(',');
                }

                return sb.ToString();
            default:
                throw new Exception("Неправильно введены аргументы");
        }

    }
}