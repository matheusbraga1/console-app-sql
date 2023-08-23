using Blog.Models;
using Dapper;

namespace Blog.Repositories;

public class TagRepository : Repository<Tag>
{
    public static void GetWithPost()
    {
        var query = @"
                    SELECT 
                        [Tag].[Id],
                        [Tag].[Title],
                        COUNT([Post].[Id]) AS Qtd_Posts
                    FROM
                        [Tag]
                        LEFT JOIN [PostTag] ON [PostTag].[TagId] = [Tag].[Id]
                        LEFT JOIN [Post] ON [PostTag].[PostId] = [Post].[Id]
                    GROUP BY
                        [Tag].[Id], [Tag].[Title]";

        var tags = new Dictionary<int, Tag>();

        Database.Connection.Query<Tag, int, Tag>(query, (tag, postCount) =>
        {
            if (!tags.ContainsKey(tag.Id))
            {
                tags[tag.Id] = tag;
            }

            tags[tag.Id].PostCount = postCount;
            return tag;
        }, splitOn: "Qtd_Posts");

        foreach (var tag in tags.Values)
        {
            Console.WriteLine($"{tag.Title} - Quantidade de posts: {tag.PostCount}");
        }
    }

    public static List<Tag> GetWithTag()
    {
        var query = @"
                    SELECT
                        [Tag].[Id],
                        [Tag].[Title],
                        [Post].[Id],
                        [Post].[Title]
                    FROM 
                        [Tag]
                        INNER JOIN [PostTag] ON [PostTag].[TagId] = [Tag].[Id]
                        INNER JOIN [Post] ON [PostTag].[PostId] = [Post].[Id]
                    ORDER BY
                        [Post].[Title]";

        var tags = new List<Tag>();

        var items = Database.Connection.Query<Tag, Post, Tag>(query,
            (tag, post) =>
        {
            var tg = tags.FirstOrDefault(t => t.Id == tag.Id);
            if (tg == null)
            {
                tg = tag;
                tg.Posts.Add(post);
                tags.Add(tg);
            }
            else
            {
                tg.Posts.Add(post);
            }
            return tg;
        }, splitOn: "Id");

        return tags;
    }
}
