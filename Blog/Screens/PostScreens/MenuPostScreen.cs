﻿using Blog.Screens.TagScreens;

namespace Blog.Screens.PostScreens;

public class MenuPostScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Gestão de posts");
        Console.WriteLine("--------------");
        Console.WriteLine("O que deseja fazer?");
        Console.WriteLine();
        Console.WriteLine("1 - Listar posts");
        Console.WriteLine("2 - Cadastrar posts");
        Console.WriteLine("3 - Editar posts (Em desenvolvimento)");
        Console.WriteLine("4 - Apagar posts");
        Console.WriteLine("5 - Voltar para o Menu Principal");
        Console.WriteLine();
        Console.WriteLine();
        var option = short.Parse(Console.ReadLine()!);

        switch (option)
        {
            case 1:
                ListPostScreen.Load();
                break;
            case 2:
                CreatePostScreen.Load();
                break;
            case 3:
                UpdatePostScreen.Load();
                break;
            case 4:
                DeletePostScreen.Load();
                break;
            case 5:
                Program.Load();
                break;
            default: Load(); break;
        }
    }
}
