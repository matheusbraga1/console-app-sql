using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens;

public class CreateUserScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Cadastro de usuário");
        Console.WriteLine("--------------------");
        Console.Write("Digite o nome do usuário: ");
        var nome = Console.ReadLine()!;
        Console.Write("Digite o email do usuário: ");
        var email = Console.ReadLine()!;
        Console.Write("Digite a senha do usuário: ");
        var senha = Console.ReadLine()!;
        Console.Write("Digite a bio do usuário: ");
        var bio = Console.ReadLine()!;
        Console.Write("Digite a image do usuário: ");
        var image = Console.ReadLine()!;
        Console.Write("Digite o slug do usuário: ");
        var slug = Console.ReadLine()!;

        Create(new User
        {
            Name = nome,
            Email = email,
            PasswordHash = senha,
            Bio = bio,
            Image = image,
            Slug = slug
        });
        Console.ReadKey();
        MenuUserScreen.Load();
    }

    public static void Create(User user)
    {
        try
        {
            var repository = new Repository<User>();
            repository.Create(user);
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Não foi possível cadastrar esse usuário.");
            Console.WriteLine(ex.Message);
        }
    }
}
