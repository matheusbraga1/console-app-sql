using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public class CreateRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Novo perfil");
        Console.WriteLine("-------------");
        Console.Write("Nome: ");
        var nome = Console.ReadLine()!;

        Console.Write("Slug: ");
        var slug = Console.ReadLine()!;

        Create(new Role
        {
            Name = nome,
            Slug = slug
        });

        Console.ReadKey();
        MenuRoleScreen.Load();
    }

    public static void Create(Role role)
    {
        try
        {
            var repository = new Repository<Role>();
            repository.Create(role);

            Console.WriteLine("Perfil cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível cadastrar esse perfil.");
            Console.WriteLine(ex.Message);
        }
    }
}
