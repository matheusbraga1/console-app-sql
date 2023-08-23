using Dapper;

namespace Blog.Screens.UserRoleScreens;

public class UserRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Vincular usuário com perfil");
        Console.WriteLine("----------------------------");

        Console.Write("Digite o ID do usuário que você quer vincular: ");
        var idUser = Console.ReadLine()!;

        Console.Write("Digite o ID do perfil que você quer vincular o usuário: ");
        var idRole = Console.ReadLine()!;

        UserWithRole(int.Parse(idUser), int.Parse(idRole));

        Console.ReadKey();
        Program.Load();
    }

    public static void UserWithRole(int idUser, int idRole)
    {
        var insertSql = "INSERT INTO [UserRole] VALUES(@UserId, @RoleId)";

        var items = Database.Connection.Execute(insertSql, new
        {
            UserId = idUser,
            RoleId = idRole
        });

        Console.WriteLine($"Foram inserido(s) {items} com sucesso!");
    }
}
