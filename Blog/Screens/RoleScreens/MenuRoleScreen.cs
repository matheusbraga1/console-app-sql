using Blog.Screens.UserScreens;

namespace Blog.Screens.RoleScreens;

public class MenuRoleScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Gestão de perfis");
        Console.WriteLine("--------------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine("1 - Listar perfis");
        Console.WriteLine("2 - Cadastrar perfil");
        Console.WriteLine("3 - Editar perfis (Em desenvolvimento)");
        Console.WriteLine("4 - Apagar perfis (Em desenvolvimento)");
        Console.WriteLine("5 - Voltar para o Menu Principal");
        Console.WriteLine();
        Console.WriteLine();
        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                ListRoleScreen.Load();
                break;
            case 2:
                CreateRoleScreen.Load();
                break;
            case 3:
                UpdateRoleScreen.Load();
                break;
            case 4:
                DeleteRoleScreen.Load();
                break;
            case 5:
                Program.Load();
                break;
            default: Load(); break;
        }
    }
}
