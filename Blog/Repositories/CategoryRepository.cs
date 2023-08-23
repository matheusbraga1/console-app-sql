using Blog.Models;
using Dapper;

namespace Blog.Repositories;

public class CategoryRepository : Repository<Category>
{
    public static void GetWithPosts()
    {
        var query = @"
                      SELECT 
                        [Category].[Id],
                        [Category].[Name],
                        COUNT([Post].[Id]) AS Qtd_Posts
                      FROM
                        [Category]
                        LEFT JOIN [Post] ON [Category].[Id] = [Post].[CategoryId]
                      GROUP BY 
                        [Category].[Id], [Category].[Name]";

        var categories = new Dictionary<int, Category>();

        Database.Connection.Query<Category, int, Category>(query, (category, postCount) =>
        {
            if (!categories.ContainsKey(category.Id))
            {
                categories[category.Id] = category;
            }

            categories[category.Id].PostsCount = postCount;
            return category;
        }, splitOn: "Qtd_Posts");

        foreach (var category in categories.Values)
        {
            Console.WriteLine($"Nome da categoria: {category.Name} - Quantidade de posts: {category.PostsCount}");
        }
    }

    public static List<Category> GetPostCategoryById(int id)
    {
        var query = @"
                    SELECT 
                        [Category].[Id],
                        [Category].[Name],
                        [Post].[CategoryId],
                        [Post].[Title]
                    FROM 
                        [Category]
                        INNER JOIN [Post] ON [Post].[CategoryId] = [Category].[Id]
                    WHERE
                        [Category].[Id] = @CategoryId
                    ORDER BY
                        [Category].[Name]";

        var categories = new Dictionary<int, Category>();

        var items = Database.Connection.Query<Category, Post, Category>(query,
            (category, post) =>
        {
            if (!categories.TryGetValue(category.Id, out var cat))
            {
                cat = category;
                categories[category.Id] = cat;
            }

            cat.Posts.Add(post);

            return cat;
        }, new { CategoryId = id }, splitOn: "CategoryId");

        return categories.Values.ToList();
    }

    public static List<Category> PostsWithCategory()
    {
        var query = @"
                    SELECT 
                        [Category].[Id],
                        [Category].[Name],
                        [Post].[CategoryId],
                        [Post].[Title]
                    FROM 
                        [Category]
                        INNER JOIN [Post] ON [Post].[CategoryId] = [Category].[Id]
                    ORDER BY
                        [Category].[Name]";

        var categories = new List<Category>();

        var items = Database.Connection.Query<Category, Post, Category>(query,
            (category, post) =>
        {
            var cat = categories.FirstOrDefault(x => x.Id == category.Id);
            if (cat == null)
            {
                cat = category;
                cat.Posts.Add(post);
                categories.Add(cat);
            }
            else
            {
                cat.Posts.Add(post);
            }
            return cat;
        }, splitOn: "CategoryId");

        return categories;
    }
}
