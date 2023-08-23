using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public class DeleteUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Excluir usuário");
        Console.WriteLine("-----------------");

        Console.Write("Qual o id do usuário que deseja excluir? ");
        var id = Console.ReadLine()!;

        Delete(int.Parse(id));

        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<User>();
            repository.Delete(id);

            Console.WriteLine("Usuário excluído com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível excluir o usuário.");
            Console.WriteLine(ex.Message);
        }
    }
}
