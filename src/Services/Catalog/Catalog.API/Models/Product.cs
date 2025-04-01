namespace Catalog.API.Models;

public class Product
{
    public Guid Id { get; set; }// use Guid to generate unique id
    public string Name { get; set; }= default!; // default! is a new feature in C# 9.0 that allows you to specify that a property is not null
    //one to many relationship between Catalog and Product
    public List<string> Category { get; set; } = new(); // when create new Cat when  a product is created, it will be initialized as an empty list
    public string Description { get; set; } = default!;
    public string ImageFile { get; set; } = default!;
    public decimal Price { get; set; }=default!;  

}
