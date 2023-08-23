using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public class ListUserScreens
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de usuários");
        Console.WriteLine("------------------");

        List();
        
        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void List()
    {
        var repository = new Repository<User>();
        var users = repository.Get();

        foreach ( var user in users )
        {
            Console.WriteLine($"ID: {user.Id}\n " +
                $"- Nome: {user.Name}\n " +
                $"- Email: {user.Email}\n " +
                $"- Bio: {user.Bio}");
        }
    }
}
