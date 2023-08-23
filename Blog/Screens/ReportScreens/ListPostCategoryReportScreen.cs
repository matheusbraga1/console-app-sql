using Blog.Repositories;

namespace Blog.Screens.ReportScreens;

public class ListPostCategoryReportScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de todos os posts por categoria");
        Console.WriteLine("-----------------------------");

        PostWithCategory();

        Console.ReadKey();
        MenuReportScreen.Load();
    }

    public static void PostWithCategory()
    {
        //var categoryRepository = new CategoryRepository();
        var items = CategoryRepository.PostsWithCategory();

        foreach (var item in items)
        {
            Console.WriteLine($"Categoria: {item.Name}");
            foreach (var post in item.Posts)
            {
                Console.WriteLine($"- {post.Title}");
            }
        }
    }
}
