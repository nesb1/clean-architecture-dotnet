// See https://aka.ms/new-console-template for more information

using ConsoleApp1;
using instagram.infrastructure.in_memroy_database;
using instagram.service;

var usersRepository = new UserRepository();
var postsRepository = new PostRepository();
var instagramService = new InstagramService(usersRepository,postsRepository);

var instagramCLI = new InstagramCLI(instagramService);

while (true)
{
    var input = Console.In.ReadLine();
    if (input.Equals("q"))
    {
        break;
    }
    var result = instagramCLI.runCommand(input);
    Console.Out.WriteLine(result);

}
    



