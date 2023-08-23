namespace Blog.Screens.UserScreens;

public class MenuUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Gestão de usuários");
        Console.WriteLine("--------------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Listar usuários");
        Console.WriteLine("2 - Cadastrar usuários");
        Console.WriteLine("3 - Editar usuários");
        Console.WriteLine("4 - Apagar usuários");
        Console.WriteLine("5 - Voltar para o Menu Principal");
        Console.WriteLine();
        Console.WriteLine();
        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                ListUserScreens.Load();
                break;
            case 2:
                CreateUserScreen.Load();
                break;
            case 3:
                UpdateUserScreen.Load();
                break;
            case 4:
                DeleteUserScreen.Load();
                break;
            case 5:
                Program.Load();
                break;
            default: Load(); break;
        }
    }
}
