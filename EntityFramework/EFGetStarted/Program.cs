﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFGetStarted;

public class Program()
{
    static async Task Main(string[] args)
    {
        using var db = new BloggingContext();

        // Note: This sample requires the database to be created before running.
        Console.WriteLine($"Database path: {db.DbPath}.");


        // Create
        Console.WriteLine("Inserting a new blog");
        db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
        await db.SaveChangesAsync();


        // Read
        Console.WriteLine("Querying for a blog");
        var blog = await db.Blogs
            .OrderBy(b => b.BlogId)
            .FirstAsync();

        // Update
        Console.WriteLine("Updating the blog and adding a post");
        blog.Url = "https://devblogs.microsoft.com/dotnet";
        blog.Posts.Add(
            new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
        await db.SaveChangesAsync();

        // Delete
        Console.WriteLine("Delete the blog");
        db.Remove(blog);
        await db.SaveChangesAsync();
        
    }
}