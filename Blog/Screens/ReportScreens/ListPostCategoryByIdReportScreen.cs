using Blog.Repositories;

namespace Blog.Screens.ReportScreens;

public class ListPostCategoryByIdReportScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de posts por categoria");
        Console.WriteLine("-----------------------------");

        Console.Write("Digite o ID da categoria: ");
        var categoryId = Console.ReadLine()!;

        GetPostsCategoryById(int.Parse(categoryId));

        Console.ReadKey();
        MenuReportScreen.Load();
    }

    public static void GetPostsCategoryById(int id)
    {
        var items = CategoryRepository.GetPostCategoryById(id);

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
