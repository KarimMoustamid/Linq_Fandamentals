using System.Text;

namespace LINQSamples
{
    public class SamplesViewModel : ViewModelBase
    {
        // Note : The query syntax can express everything that's available in Linq !

        #region Select
        #region GetAllQuery
        /// <summary>
        /// Put all products into a collection using LINQ
        /// </summary>
        public List<Product> GetAllQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Query Syntax Here
            list = (from product in products select product).ToList();


            return list;
        }
        #endregion

        #region GetAllMethod
        /// <summary>
        /// Put all products into a collection using LINQ
        /// </summary>
        public List<Product> GetAllMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Method Syntax Here


            return list;
        }
        #endregion

        #region GetSingleColumnQuery
        /// <summary>
        /// Select a single column
        /// </summary>
        public List<string> GetSingleColumnQuery()
        {
            List<Product> products = GetProducts();
            List<string> list = new();

            // Write Query Syntax Here
            list.AddRange(from product in products select product.Name);

            return list;
        }
        #endregion

        #region GetSingleColumnMethod
        /// <summary>
        /// Select a single column
        /// </summary>
        public List<string> GetSingleColumnMethod()
        {
            List<Product> products = GetProducts();
            List<string> list = new();

            // Write Method Syntax Here
            list.AddRange(products.Select(p => p.Name));

            return list;
        }
        #endregion

        #region GetSpecificColumnsQuery
        /// <summary>
        /// Select a few specific pSandBoxies from products and create new Product objects
        /// </summary>
        public List<Product> GetSpecificColumnsQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Query Syntax Here
            list = (from product in products
                    select new Product
                    {
                        ProductID = product.ProductID,
                        Name = product.Name,
                        Size = product.Size
                    }
                ).ToList();

            return list;
        }
        #endregion

        #region GetSpecificColumnsMethod
        /// <summary>
        /// Select a few specifSandBoxperties from products and create new Product objects
        /// </summary>
        public List<Product> GetSpecificColumnsMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Method Syntax Here
            list.Select(product => new Product
            {
                ProductID = product.ProductID,
                Name = product.Name,
                Size = product.Size
            });

            return list;
        }
        #endregion

        #region AnonymousClassQuery
        /// <summary>
        /// Create an anonymous class from selected product properties
        /// </summary>
        public string AnonymousClassQuery()
        {
            List<Product> products = GetProducts();
            StringBuilder sb = new(2048);

            // Write Query Syntax Here
            var list = (from product in products
                select new
                {
                    Identifier = product.ProductID,
                    ProductName = product.Name,
                    ProductSize = product.Size
                });

            // Loop through anonymous class
            foreach (var prod in list)
            {
                sb.AppendLine($"Product ID: {prod.Identifier}");
                sb.AppendLine($"   Product Name: {prod.ProductName}");
                sb.AppendLine($"   Product Size: {prod.ProductSize}");
            }

            return sb.ToString();
        }
        #endregion

        #region AnonymousClassMethod
        /// <summary>
        /// Create an anonymous class from selected product properties
        /// </summary>
        public string AnonymousClassMethod()
        {
            List<Product> products = GetProducts();
            StringBuilder sb = new(2048);

            // Write Method Syntax Here
            var list = products.Select(product => new
            {
                Identifier = product.ProductID,
                ProductName = product.Name,
                ProductSize = product.Size
            });

            // Loop through anonymous class
            foreach (var prod in list)
            {
                sb.AppendLine($"Product ID: {prod.Identifier}");
                sb.AppendLine($"   Product Name: {prod.ProductName}");
                sb.AppendLine($"   Product Size: {prod.ProductSize}");
            }

            return sb.ToString();
        }
        #endregion
        #endregion

        #region OrderBy
        #region OrderByQuery
        /// <summary>
        /// Order products by Name
        /// </summary>
        public List<Product> OrderByQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Query Syntax Here
            list = (from prod in products
                orderby prod.Name
                select prod).ToList();

            return list;
        }
        #endregion

        #region OrderByMethod
        /// <summary>
        /// Order products by Name
        /// </summary>
        public List<Product> OrderByMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Method Syntax Here
            list.OrderBy(p => p.Name).ToList();

            return list;
        }
        #endregion

        #region OrderByDescendingQuery Method
        /// <summary>
        /// Order products by name in descending order
        /// </summary>
        public List<Product> OrderByDescendingQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Query Syntax Here
            list = (from prod in products
                orderby prod.Name descending
                select prod).ToList();


            return list;
        }
        #endregion

        #region OrderByDescendingMethod Method
        /// <summary>
        /// Order products by name in descending order
        /// </summary>
        public List<Product> OrderByDescendingMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Method Syntax Here
            list.OrderByDescending(p => p.Name).ToList();

            return list;
        }
        #endregion

        #region OrderByTwoFieldsQuery Method
        /// <summary>
        /// Order products by Color descending, then Name
        /// </summary>
        public List<Product> OrderByTwoFieldsQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Query Syntax Here
            list = (from prod in products
                orderby prod.Color descending, prod.Name ascending
                select prod).ToList();

            return list;
        }
        #endregion

        #region OrderByTwoFieldsMethod Method
        /// <summary>
        /// Order products by Color descending, then Name
        /// </summary>
        public List<Product> OrderByTwoFieldsMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Method Syntax Here
            list
                .OrderByDescending(prod => prod.Color)
                .ThenBy(prod => prod.Name)
                .ToList();

            return list;
        }
        #endregion

        #region OrderByTwoFieldsDescMethod Method
        /// <summary>
        /// Order products by Color descending, then Name Descending
        /// </summary>
        public List<Product> OrderByTwoFieldsDescMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Method Syntax Here
            list
                .OrderByDescending(prod => prod.Color)
                .ThenByDescending(prod => prod.Name)
                .ToList();


            return list;
        }
        #endregion
        #endregion

        #region Filter
        #region WhereQuery
        /// <summary>
        /// Filter products using where. If the data is not found, an empty list is returned
        /// </summary>
        public List<Product> WhereQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Query Syntax Here
            list = (from product in products
                where product.Name.StartsWith("S")
                select product).ToList();

            return list;
        }
        #endregion

        #region WhereMethod
        /// <summary>
        /// Filter products using where. If the data is not found, an empty list is returned
        /// </summary>
        public List<Product> WhereMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Method Syntax Here
            list = products.Where(p => p.Name.StartsWith("S")).ToList();

            return list;
        }
        #endregion

        #region WhereTwoFieldsQuery
        /// <summary>
        /// Filter products using where with two fields. If the data is not found, an empty list is returned
        /// </summary>
        public List<Product> WhereTwoFieldsQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Query Syntax Here
            list = (from product in products
                where product.Name.StartsWith("S") && product.Color.Equals("Blue")
                select product).ToList();

            return list;
        }
        #endregion

        #region WhereTwoFieldsMethod
        /// <summary>
        /// Filter products using where with two fields. If the data is not found, an empty list is returned
        /// </summary>
        public List<Product> WhereTwoFieldsMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Method Syntax Here
            list = products.Where(p => p.Name.StartsWith("S")
                                       && p.Color.Equals("Black")).ToList();

            return list;
        }
        #endregion

        #region WhereExtensionQuery
        /// <summary>
        /// Filter products using a custom extension method
        /// </summary>
        public List<Product> WhereExtensionQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Query Syntax Here
            list = (from p in products
                select p).ByColor("Red").ToList();

            return list;
        }
        #endregion

        #region WhereExtensionMethod
        /// <summary>
        /// Filter products using a custom extension method
        /// </summary>
        public List<Product> WhereExtensionMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list = new();

            // Write Method Syntax Here
            list = products.ByColor("Red").ToList();

            return list;
        }
        #endregion
        #endregion

        #region Single
        #region FirstQuery
        /// <summary>
        /// Locate a specific product using First(). First() searches forward in the collection.
        /// NOTE: First() throws an exception if the result does not produce any values
        /// Use First() when you know or expect the sequence to have at least one element.
        /// Exceptions should be exceptional, so try to avoid them.
        /// </summary>
        public Product FirstQuery()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Query Syntax Here
            value = (from prod in products
                select prod).First(p => p.Color == "Red");

            // Test the exception handling

            return value;
        }
        #endregion

        #region FirstMethod
        /// <summary>
        /// Locate a specific product using First(). First() searches forward in the collection.
        /// NOTE: First() throws an exception if the result does not produce any values
        /// Use First() when you know or expect the sequence to have at least one element.
        /// Exceptions should be exceptional, so try to avoid them.
        /// </summary>
        public Product FirstMethod()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Method Syntax Here
            value = products.First(p => p.Color == "Red");

            return value;
        }
        #endregion

        #region FirstOrDefaultQuery
        /// <summary>
        /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
        /// NOTE: FirstOrDefault() returns a null if no value is found
        /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
        /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
        /// </summary>
        public Product FirstOrDefaultQuery()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Query Syntax Here
            value = (from p in products select p).FirstOrDefault(p => p.Color == "Red", new Product {ProductID = -1, Name = "NOT FOUND"});

            // Test the exception handling

            return value;
        }
        #endregion

        #region FirstOrDefaultMethod
        /// <summary>
        /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
        /// NOTE: FirstOrDefault() returns a null if no value is found
        /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
        /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
        /// </summary>
        public Product FirstOrDefaultMethod()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Method Syntax Here
            value = products.FirstOrDefault(p => p.Color == "Red");
            return value;
        }
        #endregion

        #region FirstOrDefaultWithDefaultQuery
        /// <summary>
        /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
        /// NOTE: You may specify the return value with FirstOrDefault() if not found
        /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
        /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
        /// </summary>
        public Product FirstOrDefaultWithDefaultQuery()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Query Syntax Here

            // Test the exception handling

            return value;
        }
        #endregion

        #region FirstOrDefaultWithDefaultMethod
        /// <summary>
        /// Locate a specific product using FirstOrDefault(). FirstOrDefault() searches forward in the list.
        /// NOTE: You may specify the return value with FirstOrDefault() if not found
        /// Use FirstOrDefault() when you DON'T know if a collection might have one element you are looking for
        /// Using FirstOrDefault() avoids throwing an exception which can hurt performance
        /// </summary>
        public Product FirstOrDefaultWithDefaultMethod()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Method Syntax Here

            return value;
        }
        #endregion

        #region LastQuery
        /// <summary>
        /// Locate a specific product using Last(). Last() searches from the end of the list backwards.
        /// NOTE: Last returns the last value from a collection, or throws an exception if no value is found
        /// </summary>
        public Product LastQuery()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Query Syntax Here

            // Test the exception handling

            return value;
        }
        #endregion

        #region LastMethod
        /// <summary>
        /// Locate a specific product using Last(). Last() searches from the end of the list backwards.
        /// NOTE: Last returns the last value from a collection, or throws an exception if no value is found
        /// </summary>
        public Product LastMethod()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Method Syntax Here


            return value;
        }
        #endregion

        #region LastOrDefaultQuery
        /// <summary>
        /// Locate a specific product using LastOrDefault(). LastOrDefault() searches from the end of the list backwards.
        /// NOTE: LastOrDefault returns the last value in a collection or a null if no values are found
        /// </summary>
        public Product LastOrDefaultQuery()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Query Syntax Here


            // Test the exception handling

            return value;
        }
        #endregion

        #region LastOrDefaultMethod
        /// <summary>
        /// Locate a specific product using LastOrDefault(). LastOrDefault() searches from the end of the list backwards.
        /// NOTE: LastOrDefault returns the last value in a collection or a null if no values are found
        /// </summary>
        public Product LastOrDefaultMethod()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Method Syntax Here


            return value;
        }
        #endregion

        #region SingleQuery
        /// <summary>
        /// Locate a specific product using Single().
        /// NOTE: Single() expects only a single element to be found in the collection, otherwise an exception is thrown
        /// Single() always searches the complete collection
        /// </summary>
        public Product SingleQuery()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Query Syntax Here
            value = (from p in products select p).Single(p => p.ProductID == 706);

            // Test the exception handling for finding multiple values

            // Test the exception handling for the list is null

            return value;
        }
        #endregion

        #region SingleMethod
        /// <summary>
        /// Locate a specific product using Single().
        /// NOTE: Single() expects only a single element to be found in the collection, otherwise an exception is thrown
        /// Single() always searches the complete collection
        /// </summary>
        public Product SingleMethod()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Method Syntax Here
            value = products.Single(p => p.ProductID == 706);

            return value;
        }
        #endregion

        #region SingleOrDefaultQuery
        /// <summary>
        /// Locate a specific product using SingleOrDefault()
        /// NOTE: SingleOrDefault() returns a single element found in the collection, or a null value if none found in the collection, if multiple values are found an exception is thrown.
        /// SingleOrDefault() always searches the complete collection
        /// </summary>
        public Product SingleOrDefaultQuery()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Query Syntax Here


            // Test the exception handling for finding multiple values


            // Test the exception handling for the list is empty

            // Test the exception handling for the list is empty and a default value is supplied

            // Test the exception handling for the list is null


            return value;
        }
        #endregion

        #region SingleOrDefaultMethod
        /// <summary>
        /// Locate a specific product using SingleOrDefault()
        /// NOTE: SingleOrDefault() returns a single element found in the collection, or a null value if none found in the collection, if multiple values are found an exception is thrown.
        /// SingleOrDefault() always searches the complete collection
        /// </summary>
        public Product SingleOrDefaultMethod()
        {
            List<Product> products = GetProducts();
            Product value = null;

            // Write Method Syntax Here


            return value;
        }
        #endregion
        #endregion

        #region PartitionDistinct
        #region TakeQuery
        /// <summary>
        /// Use Take() to select a specified number of items from the beginning of a collection
        /// </summary>
        public List<Product> TakeQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Query Syntax Here
            list = (from prod in products
                orderby prod.Name
                select prod).Take(5).ToList();

            return list;
        }
        #endregion

        #region TakeMethod
        /// <summary>
        /// Use Take() to select a specified number of items from the beginning of a collection
        /// </summary>
        public List<Product> TakeMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Query Syntax Here
            list = products.OrderBy(prod => prod.Name).Take(5).ToList();

            return list;
        }
        #endregion

        #region TakeRangeQuery
        /// <summary>
        /// Use Take() to select a specified number of items from a collection using the Range operator
        /// </summary>
        public List<Product> TakeRangeQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Query Syntax Here
            list = (from prod in products
                orderby prod.Name
                select prod).Take(5..8).ToList();

            return list;
        }
        #endregion

        #region TakeRangeMethod
        /// <summary>
        /// Use Take() to select a specified number of items from the beginning of a collection
        /// </summary>
        public List<Product> TakeRangeMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Query Syntax Here
            list = products.OrderBy(prod => prod.Name).Take(5..8).ToList();

            return list;
        }
        #endregion

        #region TakeWhileQuery
        /// <summary>
        /// Use TakeWhile() to select a specified number of items from the beginning of a collection based on a true condition
        /// </summary>
        public List<Product> TakeWhileQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Query Syntax Here
            list = (from prod in products
                orderby prod.Name
                select prod).TakeWhile(prod => prod.Name.StartsWith("A")).ToList();

            return list;
        }
        #endregion

        #region TakeWhileMethod
        /// <summary>
        /// Use TakeWhile() to select a specified number of items from the beginning of a collection based on a true condition
        /// </summary>
        public List<Product> TakeWhileMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Method Syntax Here
            list = products.OrderBy(prod => prod.Name)
                .TakeWhile(prod => prod.Name.StartsWith("A")).ToList();

            return list;
        }
        #endregion

        #region SkipQuery
        /// <summary>
        /// Use Skip() to move past a specified number of items from the beginning of a collection
        /// </summary>
        public List<Product> SkipQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Query Syntax Here
            list = (from prod in products
                orderby prod.Name
                select prod).Skip(30).ToList();

            return list;
        }
        #endregion

        #region SkipMethod
        /// <summary>
        /// Use Skip() to move past a specified number of items from the beginning of a collection
        /// </summary>
        public List<Product> SkipMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Method Syntax Here
            list = products.OrderBy(prod => prod.Name).Skip(30).ToList();

            return list;
        }
        #endregion

        #region SkipWhileQuery
        /// <summary>
        /// Use SkipWhile() to move past a specified number of items from the beginning of a collection based on a true condition
        /// </summary>
        public List<Product> SkipWhileQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Query Syntax Here
            list = (from prod in products
                orderby prod.Name
                select prod).SkipWhile(prod => prod.Name.StartsWith("A")).ToList();

            return list;
        }
        #endregion

        #region SkipWhileMethod
        /// <summary>
        /// Use SkipWhile() to move past a specified number of items from the beginning of a collection based on a true condition
        /// </summary>
        public List<Product> SkipWhileMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Method Syntax Here
            list = products.OrderBy(prod => prod.Name)
                .SkipWhile(prod => prod.Name.StartsWith("A")).ToList();

            return list;
        }
        #endregion

        #region DistinctQuery
        /// <summary>
        /// The Distinct() operator finds all unique values within a collection.
        /// In this sample you put distinct product colors into another collection using LINQ
        /// </summary>
        public List<string> DistinctQuery()
        {
            List<Product> products = GetProducts();
            List<string> list;

            // Write Query Syntax Here
            list = (from prod in products
                    select prod.Color)
                .Distinct().OrderBy(c => c).ToList();

            return list;
        }
        #endregion

        #region DistinctWhere
        /// <summary>
        /// The Distinct() operator finds all unique values within a collection.
        /// In this sample you put distinct product colors into another collection using LINQ
        /// </summary>
        public List<string> DistinctWhere()
        {
            List<Product> products = GetProducts();
            List<string> list;

            // Write Method Syntax Here
            list = products.Select(p => p.Color).Distinct().OrderBy(c => c).ToList();

            return list;
        }
        #endregion

        #region DistinctByQuery
        /// <summary>
        /// The DistinctBy() operator finds all unique values within a collection using a property.
        /// It returns a collection of Product objects
        /// </summary>
        public List<Product> DistinctByQuery()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Query Syntax Here
            list = (from prod in products
                    select prod)
                .DistinctBy(prod => prod.Color)
                .OrderBy(p => p.Color).ToList();

            return list;
        }
        #endregion

        #region DistinctByMethod
        /// <summary>
        /// The DistinctBy() operator finds all unique values within a collection using a property.
        /// It returns a collection of Product objects
        /// </summary>
        public List<Product> DistinctByMethod()
        {
            List<Product> products = GetProducts();
            List<Product> list;

            // Write Method Syntax Here
            list = products.DistinctBy(prod => prod.Color, default)
                .OrderBy(p => p.Color).ToList();

            return list;
        }
        #endregion

        #region ChunkQuery
        /// <summary>
        /// Chunk() splits the elements of a larger list into a collection of arrays of a specified size where each element of the collection is an array of those items.
        /// </summary>
        public List<Product[]> ChunkQuery()
        {
            List<Product> products = GetProducts();
            List<Product[]> list;

            // Write Query Syntax Here
            list = (from prod in products
                select prod).Chunk(5).ToList();

            return list;
        }
        #endregion

        #region ChunkMethod
        /// <summary>
        /// Chunk() splits the elements of a larger list into a collection of arrays of a specified size where each element of the collection is an array of those items.
        /// </summary>
        public List<Product[]> ChunkMethod()
        {
            List<Product> products = GetProducts();
            List<Product[]> list;

            // Write Method Syntax Here
            list = products.Chunk(5).ToList();

            return list;
        }
        #endregion
        #endregion

        #region Contains
        #region AllQuery
        /// <summary>
        /// Use All() to see if all items in a collection meet a specified condition
        /// </summary>
        public bool AllQuery()
        {
            List<Product> products = GetProducts();
            bool value = false;

            // Write Query Syntax Here
            value = (from prod in products select prod).All(p => p.ListPrice > p.StandardCost);


            return value;
        }
        #endregion

        #region AllMethod
        /// <summary>
        /// Use All() to see if all items in a collection meet a specified condition
        /// </summary>
        public bool AllMethod()
        {
            List<Product> products = GetProducts();
            bool value = false;

            // Write Method Syntax Here
            value = products.All(p => p.ListPrice > p.StandardCost);


            return value;
        }
        #endregion

        #region AllSalesQuery
        /// <summary>
        /// Use All() to see if all items in a collection meet a specified condition
        /// </summary>
        public bool AllSalesQuery()
        {
            List<SalesOrder> sales = GetSales();
            bool value = false;

            // Write Query Syntax Here
            value = (from s in sales select s).All(sale => sale.OrderQty >= 1);


            return value;
        }
        #endregion

        #region AllSalesMethod
        /// <summary>
        /// Use All() to see if all items in a collection meet a specified condition
        /// </summary>
        public bool AllSalesMethod()
        {
            List<SalesOrder> sales = GetSales();
            bool value = false;

            // Write Method Syntax Here
            value = sales.All(s => s.OrderQty >= 1);


            return value;
        }
        #endregion

        #region AnyQuery
        /// <summary>
        /// Use Any() to see if at least one item in a collection meets a specified condition
        /// </summary>
        public bool AnyQuery()
        {
            List<SalesOrder> sales = GetSales();
            bool value = false;

            // Write Query Syntax Here
            value = (from s in sales select s).Any(s => s.OrderQty >= 1);


            return value;
        }
        #endregion

        #region AnyMethod
        /// <summary>
        /// Use Any() to see if at least one item in a collection meets a specified condition
        /// </summary>
        public bool AnyMethod()
        {
            List<SalesOrder> sales = GetSales();
            bool value = false;

            // Write Method Syntax Here
            value = sales.Any(s => s.OrderQty >= 1);


            return value;
        }
        #endregion

        #region ContainsQuery
        /// <summary>
        /// Use the Contains() operator to see if a collection contains a specific value
        /// </summary>
        public bool ContainsQuery()
        {
            List<int> numbers = new() {1, 2, 3, 4, 5};
            bool value = false;

            // Write Query Syntax Here
            value = (from num in numbers select num).Contains(3);


            return value;
        }
        #endregion

        #region ContainsMethod
        /// <summary>
        /// Use the Contains() operator to see if a collection contains a specific value
        /// </summary>
        public bool ContainsMethod()
        {
            List<int> numbers = new() {1, 2, 3, 4, 5};
            bool value = false;

            // Write Method Syntax Here
            value = numbers.Contains(3);


            return value;
        }
        #endregion

        #region ContainsComparerQuery
        /// <summary>
        /// Use the Contains() operator to see if a collection contains a specific value
        /// </summary>
        public bool ContainsComparerQuery()
        {
            List<Product> products = GetProducts();
            ProductIdComparer pc = new();
            bool value = false;

            // Write Query Syntax Here


            return value;
        }
        #endregion

        #region ContainsComparerMethod
        /// <summary>
        /// Use the Contains() operator to see if a collection contains a specific value.
        /// When comparing classes, you need to write a EqualityComparer class.
        /// </summary>
        public bool ContainsComparerMethod()
        {
            List<Product> products = GetProducts();
            ProductIdComparer pc = new();
            bool value = false;

            // Write Method Syntax Here
            value = (from prod in products select prod)
                .Contains(new Product {ProductID = 744}, pc);


            return value;
        }
        #endregion
        #endregion

        #region Compare
        #region SequenceEqualIntegersQuery
        /// <summary>
        /// SequenceEqual() compares two different collections to see if they are equal
        /// When using simple data types such as int, string, a direct comparison between values is performed
        /// </summary>
        public bool SequenceEqualIntegersQuery()
        {
            bool value = false;
            // Create a list of numbers
            List<int> list1 = new() {5, 2, 3, 4, 5};
            // Create a list of numbers
            List<int> list2 = new() {1, 2, 3, 4, 5};

            // Write Query Syntax Here
            value = (from num in list1 select num).SequenceEqual(list2);

            return value;
        }
        #endregion

        #region SequenceEqualIntegersMethod
        /// <summary>
        /// SequenceEqual() compares two different collections to see if they are equal
        /// When using simple data types such as int, string, a direct comparison between values is performed
        /// </summary>
        public bool SequenceEqualIntegersMethod()
        {
            bool value = false;
            // Create a list of numbers
            List<int> list1 = new() {5, 2, 3, 4, 5};
            // Create a list of numbers
            List<int> list2 = new() {1, 2, 3, 4, 5};

            // Write Method Syntax Here
            value = list1.SequenceEqual(list2);


            return value;
        }
        #endregion

        #region SequenceEqualObjectsQuery
        /// <summary>
        /// When using a collection of objects, SequenceEqual() performs a comparison to see if the two object references point to the same object
        /// </summary>
        public bool SequenceEqualObjectsQuery()
        {
            bool value = false;
            // Create a list of products
            List<Product> list1 = new()
            {
                new Product {ProductID = 1, Name = "Product 1"},
                new Product {ProductID = 2, Name = "Product 2"},
            };

            // Create a list of products
            List<Product> list2 = new()
            {
                new Product {ProductID = 1, Name = "Product 1"},
                new Product {ProductID = 2, Name = "Product 2"},
            };

            // Make Collections the Same
            list2 = list1;

            // Write Query Syntax Here
            value = (from prod in list1 select prod).SequenceEqual(list2);


            return value;
        }
        #endregion

        #region SequenceEqualObjectsMethod
        /// <summary>
        /// When using a collection of objects, SequenceEqual() performs a comparison to see if the two object references point to the same object
        /// </summary>
        public bool SequenceEqualObjectsMethod()
        {
            bool value = false;
            // Create a list of products
            List<Product> list1 = new()
            {
                new Product {ProductID = 1, Name = "Product 1"},
                new Product {ProductID = 2, Name = "Product 2"},
            };

            // Create a list of products
            List<Product> list2 = new()
            {
                new Product {ProductID = 1, Name = "Product 1"},
                new Product {ProductID = 2, Name = "Product 2"},
            };

            // Make Collections the Same
            // list2 = list1;

            // Write Method Syntax Here


            return value;
        }
        #endregion

        #region SequenceEqualUsingComparerQuery
        /// <summary>
        /// Use an EqualityComparer class to determine if the objects are the same based on the values in properties
        /// </summary>
        public bool SequenceEqualUsingComparerQuery()
        {
            bool value = false;
            ProductComparer pc = new ProductComparer();
            // Load all Product Data From Data Source 1
            List<Product> list1 = ProductRepository.GetAll();
            // Load all Product Data From Data Source 2
            List<Product> list2 = ProductRepository.GetAll();

            // Remove an element from 'list1' to make the collections different
            //list1.RemoveAt(0);

            // Write Query Syntax Here
               value = (from prod in list1 select prod).SequenceEqual(list2, pc);




            return value;
        }
        #endregion

        #region SequenceEqualUsingComparerMethod
        /// <summary>
        /// Use an EqualityComparer class to determine if the objects are the same based on the values in properties
        /// </summary>
        public bool SequenceEqualUsingComparerMethod()
        {
            bool value = false;
            ProductComparer pc = new ProductComparer();
            // Load all Product Data From Data Source 1
            List<Product> list1 = ProductRepository.GetAll();
            // Load all Product Data From Data Source 2
            List<Product> list2 = ProductRepository.GetAll();

            // Remove an element from 'list1' to make the collections different
            //list1.RemoveAt(0);

            // Write Method Syntax Here


            return value;
        }
        #endregion

        #region ExceptIntegersQuery
        /// <summary>
        /// Find all values in one list that are not in the other list
        /// </summary>
        public List<int> ExceptIntegersQuery()
        {
            List<int> list = null;
            // Create a list of numbers
            List<int> list1 = new() {5, 2, 3, 4, 5};
            // Create a list of numbers
            List<int> list2 = new() {3, 4, 5};

            // Write Query Syntax Here
              list = (from prod in list1 select prod).Except(list2).ToList();


            return list;
        }
        #endregion

        #region ExceptIntegersMethod
        /// <summary>
        /// Find all values in one list that are not in the other list
        /// </summary>
        public List<int> ExceptIntegersMethod()
        {
            List<int> list = null;
            // Create a list of numbers
            List<int> list1 = new() {5, 2, 3, 4, 5};
            // Create a list of numbers
            List<int> list2 = new() {3, 4, 5};

            // Write Method Syntax Here


            return list;
        }
        #endregion

        #region ExceptProductSalesQuery
        /// <summary>
        /// Find all products that do not have sales
        /// </summary>
        public List<int> ExceptProductSalesQuery()
        {
            List<int> list = null;
            List<Product> products = ProductRepository.GetAll();
            List<SalesOrder> sales = SalesOrderRepository.GetAll();

            // Write Query Syntax Here
            list = (from p in products select p.ProductID)
                .Except(from s in sales select s.ProductID)
                .ToList();


            return list;
        }
        #endregion

        #region ExceptProductSalesMethod
        /// <summary>
        /// Find all products that do not have sales
        /// </summary>
        public List<int> ExceptProductSalesMethod()
        {
            List<int> list = null;
            List<Product> products = ProductRepository.GetAll();
            List<SalesOrder> sales = SalesOrderRepository.GetAll();

            // Write Method Syntax Here


            return list;
        }
        #endregion

        #region ExceptUsingComparerQuery
        /// <summary>
        /// Find all products that are in one list but not the other using a comparer class
        /// </summary>
        public List<Product> ExceptUsingComparerQuery()
        {
            List<Product> list = null;
            ProductComparer pc = new();
            // Load all Product Data From Data Source 1
            List<Product> list1 = ProductRepository.GetAll();
            // Load all Product Data From Data Source 2
            List<Product> list2 = ProductRepository.GetAll();

            // Remove all products with color = "Black" from 'list2'
            // to give us a difference in the two lists
            list2.RemoveAll(prod => prod.Color == "Black");

            // Write Query Syntax Here
            list = (from p in list1 select p).Except(list2, pc).ToList();

            return list;
        }
        #endregion

        #region ExceptUsingComparerMethod
        /// <summary>
        /// Find all products that are in one list but not the other using a comparer class
        /// </summary>
        public List<Product> ExceptUsingComparerMethod()
        {
            List<Product> list = null;
            ProductComparer pc = new();
            // Load all Product Data
            List<Product> list1 = ProductRepository.GetAll();
            // Load all Product Data
            List<Product> list2 = ProductRepository.GetAll();

            // Remove all products with color = "Black" from 'list2'
            // to give us a difference in the two lists
            list2.RemoveAll(prod => prod.Color == "Black");

            // Write Method Syntax Here


            return list;
        }
        #endregion

        #region ExceptByQuery
        /// <summary>
        /// ExceptBy() finds products within a collection that DO NOT compare to a List<string> against a specified property in the collection.
        /// The default comparer for ExceptBy() is 'string'
        /// </summary>
        public List<Product> ExceptByQuery()
        {
            List<Product> list = null;
            // Load all Product Data
            List<Product> products = ProductRepository.GetAll();

            // The list of colors to exclude from the list
            List<string> colors = new() {"Red", "Black"};

            // Write Query Syntax Here
            list = (from p in products select p).ExceptBy(colors ,p => p.Color).ToList();


            return list;
        }
        #endregion

        #region ExceptByMethod
        /// <summary>
        /// ExceptBy() finds products within a collection that DO NOT compare to a List<string> against a specified property in the collection.
        /// The default comparer for ExceptBy() is 'string'
        /// </summary>
        public List<Product> ExceptByMethod()
        {
            List<Product> list = null;
            // Load all Product Data
            List<Product> products = ProductRepository.GetAll();

            // The list of colors to exclude from the list
            List<string> colors = new() {"Red", "Black"};

            // Write Method Syntax Here


            return list;
        }
        #endregion

        #region ExceptByProductSalesQuery
        /// <summary>
        /// Find all products that do not have sales
        /// Change the default comparer for ExceptBy()
        /// </summary>
        public List<Product> ExceptByProductSalesQuery()
        {
            List<Product> list = null;
            List<Product> products = ProductRepository.GetAll();
            List<SalesOrder> sales = SalesOrderRepository.GetAll();

            // Write Query Syntax Here
            list = (from p in products select p)
                .ExceptBy<Product , int>(from s in sales select s.ProductID,p => p.ProductID).ToList();


            return list;
        }
        #endregion

        #region ExceptByProductSalesMethod
        /// <summary>
        /// Find all products that do not have sales
        /// Change the default comparer for ExceptBy()
        /// </summary>
        public List<Product> ExceptByProductSalesMethod()
        {
            List<Product> list = null;
            List<Product> products = ProductRepository.GetAll();
            List<SalesOrder> sales = SalesOrderRepository.GetAll();

            // Write Method Syntax Here
            list = products.ExceptBy<Product, int>(sales.Select( p => p.ProductID), p => p.ProductID).ToList();


            return list;
        }
        #endregion

        #region IntersectIntegersQuery
        /// <summary>
        /// Intersect() finds all values in one list that are also in the other list
        /// </summary>
        public List<int> IntersectIntegersQuery()
        {
            List<int> list = null;
            // Create a list of numbers
            List<int> list1 = new() {5, 2, 3, 4, 5};
            // Create a list of numbers
            List<int> list2 = new() {3, 9, 5};

            // Write Query Syntax Here
            list = (from prod in list1 select prod).Intersect(list2).ToList();


            return list;
        }
        #endregion

        #region IntersectIntegersMethod
        /// <summary>
        /// Intersect() finds all values in one list that are also in the other list
        /// </summary>
        public List<int> IntersectIntegersMethod()
        {
            List<int> list = null;
            // Create a list of numbers
            List<int> list1 = new() {5, 2, 3, 4, 5};
            // Create a list of numbers
            List<int> list2 = new() {3, 4, 5};

            // Write Method Syntax Here


            return list;
        }
        #endregion

        #region IntersectProductSalesQuery
        /// <summary>
        /// Find all products that have sales
        /// </summary>
        public List<int> IntersectProductSalesQuery()
        {
            List<int> list = null;
            List<Product> products = ProductRepository.GetAll();
            List<SalesOrder> sales = SalesOrderRepository.GetAll();

            // Write Query Syntax Here


            return list;
        }
        #endregion

        #region IntersectProductSalesMethod
        /// <summary>
        /// Find all products that have sales
        /// </summary>
        public List<int> IntersectProductSalesMethod()
        {
            List<int> list = null;
            List<Product> products = ProductRepository.GetAll();
            List<SalesOrder> sales = SalesOrderRepository.GetAll();

            // Write Method Syntax Here


            return list;
        }
        #endregion

        #region IntersectUsingComparerQuery
        /// <summary>
        /// Intersect() finds all products that are in common between two collections using a comparer class
        /// </summary>
        public List<Product> IntersectUsingComparerQuery()
        {
            List<Product> list = null;
            ProductComparer pc = new();
            // Load all Product Data
            List<Product> list1 = ProductRepository.GetAll();
            // Load all Product Data
            List<Product> list2 = ProductRepository.GetAll();

            // Remove 'black' products from 'list1'
            list1.RemoveAll(prod => prod.Color == "Black");
            // Remove 'red' products from 'list2'
            list2.RemoveAll(prod => prod.Color == "Red");

            // Write Query Syntax Here


            return list;
        }
        #endregion

        #region IntersectUsingComparerMethod
        /// <summary>
        /// Intersect() finds all products that are in common between two collections using a comparer class
        /// </summary>
        public List<Product> IntersectUsingComparerMethod()
        {
            List<Product> list = null;
            ProductComparer pc = new();
            // Load all Product Data
            List<Product> list1 = ProductRepository.GetAll();
            // Load all Product Data
            List<Product> list2 = ProductRepository.GetAll();

            // Remove 'black' products from 'list1'
            list1.RemoveAll(prod => prod.Color == "Black");
            // Remove 'red' products from 'list2'
            list2.RemoveAll(prod => prod.Color == "Red");

            // Write Method Syntax Here


            return list;
        }
        #endregion

        #region IntersectByQuery
        /// <summary>
        /// Find products within a collection by comparing a List<string> against a specified property in the collection.
        /// </summary>
        public List<Product> IntersectByQuery()
        {
            List<Product> list = null;
            List<Product> products = ProductRepository.GetAll();

            // The list of colors to locate in the list
            List<string> colors = new() {"Red", "Black"};

            // Write Query Syntax Here


            return list;
        }
        #endregion

        #region IntersectByMethod
        /// <summary>
        /// IntersectBy() finds DISTINCT products within a collection by comparing a List<string> against a specified property in the collection.
        /// </summary>
        public List<Product> IntersectByMethod()
        {
            List<Product> list = null;
            List<Product> products = ProductRepository.GetAll();

            // The list of colors to locate in the list
            List<string> colors = new() {"Red", "Black"};

            // Write Method Syntax Here


            return list;
        }
        #endregion

        #region IntersectByProductSalesQuery
        /// <summary>
        /// Find all products that have sales using a 'int' key selector
        /// Change the default comparer for IntersectBy()
        /// </summary>
        public List<Product> IntersectByProductSalesQuery()
        {
            List<Product> list = null;
            List<Product> products = ProductRepository.GetAll();
            List<SalesOrder> sales = SalesOrderRepository.GetAll();

            // Write Query Syntax Here


            return list;
        }
        #endregion

        #region IntersectByProductSalesMethod
        /// <summary>
        /// Find all products that have sales using a 'int' key selector
        /// Change the default comparer for IntersectBy()
        /// </summary>
        public List<Product> IntersectByProductSalesMethod()
        {
            List<Product> list = null;
            List<Product> products = ProductRepository.GetAll();
            List<SalesOrder> sales = SalesOrderRepository.GetAll();

            // Write Method Syntax Here


            return list;
        }
        #endregion
        #endregion
    }
}