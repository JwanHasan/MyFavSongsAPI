using EFDatabase.EF;
using EFDatabase.Moduls;
using Microsoft.EntityFrameworkCore;



var context = new MySongContext();
await context.Database.EnsureCreatedAsync();

var artist = new Artist {  Name = "jack" };

 await context.Artists.AddAsync(new Artist { Name = "Blalalala" });
    

await context.SaveChangesAsync();

var list = context.Artists.ToList();

foreach(var item in list)
{
    Console.WriteLine("the name is: "+item.Name+ "  The Id is:  " +item.Id);
}

