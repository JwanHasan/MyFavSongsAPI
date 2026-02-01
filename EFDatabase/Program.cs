using EFDatabase.EF;
using EFDatabase.Moduls;
using Microsoft.EntityFrameworkCore;



var context = new MySongContext();


var artist = new Artist {  Name = "jack" };

 context.Artists.Add(artist);
 context.SaveChanges();

var list = context.Artists.ToList();

foreach(var item in list)
{
    Console.WriteLine(item.Name+ "fdhædfhpdfhådhdh"+item.Id);
}

