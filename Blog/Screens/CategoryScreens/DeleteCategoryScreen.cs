using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens;

public class DeleteCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Excluir categoria");
        Console.WriteLine("------------------");

        Console.Write("Qual o id da categoria que deseja excluir? ");
        var id = Console.ReadLine()!;

        Delete(int.Parse(id));

        Console.ReadKey();
        MenuCategoryScreen.Load();
    }

    public static void Delete(int id)
    {
        try
        {
            var repository = new Repository<Category>();
            repository.Delete(id);

            Console.WriteLine("Categoria excluída com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível excluir a categoria.");
            Console.WriteLine(ex.Message);
        }
    }
}
