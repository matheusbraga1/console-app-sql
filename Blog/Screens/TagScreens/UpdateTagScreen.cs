using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public class UpdateTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizar tag");
        Console.WriteLine("-------------");
        Console.Write("Digite o ID da tag: ");
        var id = Console.ReadLine()!;

        Console.Write("Title: ");
        var title = Console.ReadLine()!;

        Console.Write("Slug: ");
        var slug = Console.ReadLine()!;

        Update(new Tag
        {
            Id = int.Parse(id),
            Title = title,
            Slug = slug
        });
        Console.ReadKey();
        MenuTagScreen.Load();
    }

    public static void Update(Tag tag)
    {
        try
        {
            var repository = new Repository<Tag>();
            repository.Update(tag);
            Console.WriteLine("Tag atualizada com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível atualizar a tag.");
            Console.WriteLine(ex.Message);
        }
    }
}
