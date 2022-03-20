// See https://aka.ms/new-console-template for more information
using ShopDbApp;

ShopDb db = new ShopDb();
var result = db.Categories;
foreach (var item in result)
{
    Console.WriteLine($"Category: #{item.Id} {item.Name}");
}


