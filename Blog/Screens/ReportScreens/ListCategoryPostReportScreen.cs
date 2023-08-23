using Blog.Repositories;

namespace Blog.Screens.ReportScreens;

public class ListCategoryPostReportScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Categorias com quantidade de posts");
        Console.WriteLine("-----------------------------------");

        CategoryWithPost();

        Console.ReadKey();
        MenuReportScreen.Load();
    }

    public static void CategoryWithPost()
    {
        //var categoryRepository = new CategoryRepository();
        CategoryRepository.GetWithPosts();
    }
}
