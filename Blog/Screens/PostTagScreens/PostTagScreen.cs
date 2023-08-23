using Dapper;

namespace Blog.Screens.PostTagScreens;

public class PostTagScreen
{
    public static void Load()
    {
        Console.Clear();
        Console.WriteLine("Vincular post com tag");
        Console.WriteLine("----------------------");

        Console.Write("Digite o ID do post: ");
        var postId = Console.ReadLine()!;

        Console.Write("Digite o ID da tag: ");
        var tagId = Console.ReadLine()!;

        PostWithTag(int.Parse(postId), int.Parse(tagId));

        Console.ReadKey();
        Program.Load();
    }

    public static void PostWithTag(int postId, int tagId)
    {
        var insertSql = "INSERT INTO [PostTag] VALUES(@postId, @tagId)";

        var rows = Database.Connection.Execute(insertSql, new
        {
            PostId = postId,
            TagId = tagId
        });

        Console.WriteLine($"Foram inserida(s) {rows} registro(s).");
    }
}
