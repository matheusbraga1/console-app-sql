using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens;

public class ListPostScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de posts");
        Console.WriteLine("---------------");

        List();

        Console.ReadKey();
        MenuPostScreen.Load();
    }

    public static void List()
    {
        var repository = new Repository<Post>();
        var posts = repository.Get();

        foreach (var post in posts)
            Console.WriteLine($"Id: {post.Id},\n Title: {post.Title},\n Summary: {post.Summary},\n Slug: {post.Slug},\n Create date: {post.CreateDate}");
    }
}
