﻿using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.TagScreens;

public static class ListTagsScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Lista de tags");
        Console.WriteLine("--------------");

        List();
        
        Console.ReadKey();
        MenuTagScreen.Load();
    }

    private static void List()
    {
        var repository = new Repository<Tag>();
        var tags = repository.Get();
        foreach ( var tag in tags )
            Console.WriteLine($"{tag.Id} - {tag.Title} ({tag.Slug})");
    }
}
