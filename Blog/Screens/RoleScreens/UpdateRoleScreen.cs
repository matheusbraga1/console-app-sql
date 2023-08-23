using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public class UpdateRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizar perfil");
        Console.WriteLine("-----------------");

        Console.Write("Digite o ID do perfil: ");
        var id = Console.ReadLine()!;

        Console.Write("Nome: ");
        var nome = Console.ReadLine()!;

        Console.WriteLine("Slug: ");
        var slug = Console.ReadLine()!;

        Update(new Role
        {
            Id = int.Parse(id),
            Name = nome,
            Slug = slug
        });
    }

    public static void Update(Role role)
    {
        try
        {
            var repository = new Repository<Role>();
            repository.Update(role);

            Console.WriteLine("Perfil atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível atualizar o perfil.");
            Console.WriteLine(ex.Message);
        }
    }
}
