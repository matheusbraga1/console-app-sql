using Blog.Repositories;

namespace Blog.Screens.ReportScreens;

public class ListPostTagReportScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista dos posts com suas tags");
        Console.WriteLine("------------------------------");

        GetWithTags();

        Console.ReadKey();
        MenuReportScreen.Load();
    }

    public static void GetWithTags()
    {
        var items = TagRepository.GetWithTag();

        foreach (var item in items)
        {
            Console.Write($"Tag: {item.Title}, ");
            foreach (var post in item.Posts)
            {
                Console.WriteLine($"{post.Title}");
            }
        }
    }
}
