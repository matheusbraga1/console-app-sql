using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens;

public class UpdateCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizar categoria");
        Console.WriteLine("--------------------");

        Console.Write("Digite o ID da categoria: ");
        var id = Console.ReadLine()!;

        Console.Write("Nome: ");
        var nome = Console.ReadLine()!;

        Console.Write("Slug: ");
        var slug = Console.ReadLine()!;

        Update(new Category 
        {
            Id = int.Parse(id),
            Name = nome,
            Slug = slug
        });

        Console.ReadKey();
        MenuCategoryScreen.Load();
    }

    public static void Update(Category category)
    {
        try
        {
            var repository = new Repository<Category>();
            repository.Update(category);

            Console.WriteLine("Registro atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível atualizar esse registro.");
            Console.WriteLine(ex.Message);
        }
    }
}
