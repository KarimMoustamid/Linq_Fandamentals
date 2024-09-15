// See https://aka.ms/new-console-template for more information
using LINQSamples;
SamplesViewModel vm = new SamplesViewModel();

// List<Product> products = vm.GetAllQuery();
// List<Product> products = vm.GetAllMethod();
// List<string> products = vm.GetSingleColumnQuery();
List<string> products = vm.GetSingleColumnMethod();

vm.Display(products);