using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens;

public class ListCategoryScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de categorias");
        Console.WriteLine("--------------------");

        List();

        Console.ReadKey();
        MenuCategoryScreen.Load();
    }

    public static void List()
    {
        var repository = new Repository<Category>();
        var categories = repository.Get();

        foreach (var category in categories)
            Console.WriteLine($"Id: {category.Id},\n Nome: {category.Name},\n Slug: {category.Slug}");
    }
}
