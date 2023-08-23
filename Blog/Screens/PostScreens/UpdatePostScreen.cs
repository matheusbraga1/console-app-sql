using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens;

public class UpdatePostScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizar post");
        Console.WriteLine("---------------");

        Console.Write("Digite o ID do post: ");
        var id = Console.ReadLine()!;

        Console.Write("Digite o ID da categoria: ");
        var catId = Console.ReadLine()!;

        Console.Write("Digite o ID do autor: ");
        var authId = Console.ReadLine()!;

        Console.Write("Titulo: ");
        var titulo = Console.ReadLine()!;

        Console.Write("Summary: ");
        var summary = Console.ReadLine()!;

        Console.Write("Body: ");
        var body = Console.ReadLine()!;

        Console.Write("Slug: ");
        var slug = Console.ReadLine()!;

        Update(new Post 
        {
            Id = int.Parse(id),
            CategoryId = int.Parse(catId),
            AuthorId = int.Parse(authId),
            Title = titulo,
            Summary = summary,
            Body = body,
            Slug = slug
        });

        Console.ReadKey();
        MenuPostScreen.Load();
    }

    public static void Update(Post post)
    {
        try
        {
            var repository = new Repository<Post>();
            repository.Update(post);

            Console.WriteLine("Post atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível atualizar esse post.");
            Console.WriteLine(ex.Message);
        }
    }
}
