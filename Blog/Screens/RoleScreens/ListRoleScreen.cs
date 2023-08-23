using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public class ListRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de perfis");
        Console.WriteLine("----------------");

        List();

        Console.ReadKey();
        MenuRoleScreen.Load();
    }

    public static void List()
    {
        var repository = new Repository<Role>();
        var roles = repository.Get();

        foreach (var role in roles)
            Console.WriteLine($"Id: {role.Id},\n Nome: {role.Name},\n Slug: {role.Slug}");
    }
}
