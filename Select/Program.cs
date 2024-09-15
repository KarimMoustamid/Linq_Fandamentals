// See https://aka.ms/new-console-template for more information

List<Product> products = new List<Product>
{
    new Product { Id = 1, Name = "Product 1", Price = 12.99m },
    new Product { Id = 2, Name = "Product 2", Price = 25.50m },
    new Product { Id = 3, Name = "Product 3", Price = 32.00m }
};

decimal Min = decimal.MaxValue;

// foreach (var product in products)
// {
//     if (product.Price < Min)
//     {
//         Min = product.Price;
//     }
// }
//
// Console.WriteLine($"Max Price: {Min}");


decimal value = (from prod in products select prod.Price).Min();
Console.WriteLine($"Price: {value}");
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}