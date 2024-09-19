// See https://aka.ms/new-console-template for more information
using LINQSamples;

// Create instance of view model
SamplesViewModel vm = new();
//
// try
// {
//   // Call Sample Method
//   var result = vm.FirstQuery();
//
//   // Display Results
//   vm.Display(result);
// }
// catch (ArgumentNullException ex)
// {
//   // This collection was null
//   vm.Display(ex);
// }
// catch (InvalidOperationException ex)
// {
//   // First()/Last() methods = No item was found that matches the criteria
//   // Single*() methods = Multiple values were found
//   vm.Display(ex);
// }
// catch (Exception ex)
// {
//   // Catch-all exception
//   vm.Display(ex);
// }

// List<Product> products = vm.GetAllQuery();
// List<Product> products = vm.GetAllMethod();
// List<string> products = vm.GetSingleColumnQuery();
// List<string> products = vm.GetSingleColumnMethod();
// List<Product> products = vm.GetSpecificColumnsQuery();
// List<Product> products = vm.GetSpecificColumnsMethod();

// vm.Display(products);

// var result = vm.AnonymousClassQuery();
// var result = vm.AnonymousClassMethod();
// vm.Display(result);


// List<Product> products = vm.OrderByQuery();
// List<Product> products = vm.OrderByMethod();
//
// vm.Display(products);


var result = vm.IntersectIntegersQuery();
vm.Display(result);