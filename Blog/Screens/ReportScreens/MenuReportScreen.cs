using Blog.Screens.UserScreens;

namespace Blog.Screens.ReportScreens;

public class MenuReportScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("--------------------");
        Console.WriteLine("1 - Listar usuários e perfis");
        Console.WriteLine("2 - Listar categorias com quantidade de posts");
        Console.WriteLine("3 - Listar as tags com quantidade de posts");
        Console.WriteLine("4 - Listar posts de uma categoria");
        Console.WriteLine("5 - Listar todos os posts com sua categoria");
        Console.WriteLine("6 - Listar todos os posts com suas tags");
        Console.WriteLine("7 - Voltar para o Menu Principal");
        Console.WriteLine();
        Console.WriteLine();
        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                ListUsersReportScreen.Load();
                break;
            case 2:
                ListCategoryPostReportScreen.Load();
                break;
            case 3:
                ListTagPostReportScreen.Load();
                break;
            case 4:
                ListPostCategoryByIdReportScreen.Load();
                break;
            case 5:
                ListPostCategoryReportScreen.Load();
                break;
            case 6:
                ListPostTagReportScreen.Load();
                break;
            case 7:
                Program.Load();
                break;
            default: Load(); break;
        }
    }
}
