using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public class UpdateUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Atualizar usuário");
        Console.WriteLine("-------------------");
        
        Console.Write("Digite o ID do usuário: ");
        var id = Console.ReadLine()!;

        Console.Write("Nome: ");
        var name = Console.ReadLine()!;

        Console.Write("Email: ");
        var email = Console.ReadLine()!;

        Console.Write("Password Hash: ");
        var password = Console.ReadLine()!;

        Console.Write("Bio: ");
        var bio = Console.ReadLine()!;

        Console.Write("Image: ");
        var image = Console.ReadLine()!;

        Console.Write("Slug: ");
        var slug = Console.ReadLine()!;

        Update(new User
        {
            Id = int.Parse(id),
            Name = name,
            Email = email,
            PasswordHash = password,
            Bio = bio,
            Image = image,
            Slug = slug
        });

        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void Update(User user)
    {
        try
        {
            var repository = new Repository<User>();
            repository.Update(user);

            Console.WriteLine("Usuário atualizado com sucesso!");
        }
        catch (Exception ex) 
        {
            Console.WriteLine("Não foi possível atualizar esse usuário.");
            Console.WriteLine(ex.Message);
        }
    }
}
