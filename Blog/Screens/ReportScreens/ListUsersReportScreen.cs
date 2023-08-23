using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ReportScreens;

public class ListUsersReportScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de usuários e perfis");
        Console.WriteLine("----------------------------");

        ListUsersWithRoles();

        Console.ReadKey();
        Program.Load();
    }

    public static void ListUsersWithRoles()
    {
        var usersRepository = new UserRepository();
        var usersWithRoles = usersRepository.GetWithRoles();

        foreach ( var user in usersWithRoles )
        {
            Console.WriteLine($"Nome: {user.Name}, Email: {user.Email}");
            foreach ( var role in user.Roles )
            {
                Console.WriteLine($"Perfil: {role.Name}, Slug do perfil: {role.Slug}");
            }

            Console.WriteLine();
        }
    }
}
