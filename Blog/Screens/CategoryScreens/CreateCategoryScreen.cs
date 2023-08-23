using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens;

public class CreateCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Nova categoria");
        Console.WriteLine("---------------");
        Console.Write("Nome: ");
        var nome = Console.ReadLine()!;
        Console.WriteLine();
        Console.Write("Slug: ");
        var slug = Console.ReadLine()!;

        Create(new Category
        {
            Name = nome,
            Slug = slug
        });

        Console.ReadKey();
        MenuCategoryScreen.Load();
    }

    public static void Create(Category category)
    {
        try
        {
            var repository = new Repository<Category>();
            repository.Create(category);

            Console.WriteLine("Categoria cadastrada com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível cadastrar essa categoria.");
            Console.WriteLine(ex.Message);
        }
    }
}
