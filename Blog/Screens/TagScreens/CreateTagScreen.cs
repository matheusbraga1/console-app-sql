﻿using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public static class CreateTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Nova tag");
        Console.WriteLine("-------------");
        Console.Write("Titulo: ");
        var title = Console.ReadLine()!;

        Console.Write("Slug: ");
        var slug = Console.ReadLine()!;

        Create(new Tag
        {
            Title = title,
            Slug = slug
        });

        Console.ReadKey();
        MenuTagScreen.Load();
    }

    public static void Create(Tag tag)
    {
        try
        {
            var repository = new Repository<Tag>();
            repository.Create(tag);
            Console.WriteLine("Tag cadastrada com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível salvar a tag");
            Console.WriteLine(ex.Message);
        }
    }
}
