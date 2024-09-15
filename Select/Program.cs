// See https://aka.ms/new-console-template for more information
using LINQSamples;
SamplesViewModel vm = new SamplesViewModel();

// List<Product> products = vm.GetAllQuery();
List<Product> products = vm.GetAllMethod();

vm.Display(products);