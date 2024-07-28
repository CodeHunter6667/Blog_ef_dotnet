using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

using (var context = new DataContext())
{
    // var tag = new Tag { Name = ".NET", Slug = "dotnet"};
    // context.Tags.Add(tag);
    // context.SaveChanges();

    // var tag2 = new Tag { Name = "ASP.NET", Slug = "aspnet"};
    // context.Tags.Add(tag2);
    // context.SaveChanges();

    // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
    // tag.Name = ".Net";
    // tag.Slug = "dotnet";
    // context.Update(tag);
    // context.SaveChanges();

    // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
    // context.Tags.Remove(tag);
    // context.SaveChanges();

    // var tags = context.Tags.AsNoTracking().ToList();
    // foreach (var tag in tags)
    // {
    //     System.Console.WriteLine(tag.Name);
    // }
}