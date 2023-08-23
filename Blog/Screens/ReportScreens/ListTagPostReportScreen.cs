using Blog.Models;
using Blog.Repositories;
using Dapper;

namespace Blog.Screens.ReportScreens;

public class ListTagPostReportScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Tag com quantidade de post");
        Console.WriteLine("---------------------------");

        TagWithPosts();

        Console.ReadKey();
        MenuReportScreen.Load();
    }

    public static void TagWithPosts()
    {
        //var tagRepository = new TagRepository();
        TagRepository.GetWithPost();
    }
}
