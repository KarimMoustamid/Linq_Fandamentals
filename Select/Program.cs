// See https://aka.ms/new-console-template for more information

using LINQSamples;
List<Product> products =  ProductRepository.GetAll();


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


decimal value = (from prod in products select prod.ListPrice).Min();
Console.WriteLine($"Price: {value}");