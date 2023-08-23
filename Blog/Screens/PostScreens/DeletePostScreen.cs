using Blog.Models;
using Blog.Repositories;
using Blog.Screens.UserScreens;

namespace Blog.Screens.PostScreens;

public class DeletePostScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Excluir post");
        Console.WriteLine("-----------------");

        Console.Write("Qual o id do post que deseja excluir? ");
        var id = Console.ReadLine()!;

        Delete(int.Parse(id));

        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<Post>();
            repository.Delete(id);

            Console.WriteLine("Registro excluído com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível excluir o registro.");
            Console.WriteLine(ex.Message);
        }
    }
}
