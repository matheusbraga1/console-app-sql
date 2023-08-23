using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens;

public class DeleteRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Excluir perfil");
        Console.WriteLine("--------------");

        Console.Write("Qual o id do perfil que deseja excluir? ");
        var id = Console.ReadLine()!;

        Delete(int.Parse(id));

        Console.ReadKey();
        MenuRoleScreen.Load();
    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<Role>();
            repository.Delete(id);

            Console.WriteLine("Perfil excluído com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível apagar excluir perfil.");
            Console.WriteLine(ex.Message);
        }
    }
}
