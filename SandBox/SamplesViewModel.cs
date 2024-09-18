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
            value = (from s in sales select s).All( sale => sale.OrderQty >= 1);


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
            value = (from s in sales select s).Any( s => s.OrderQty >= 1);


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
            value = sales.Any( s => s.OrderQty >= 1);


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


            return value;
        }
        #endregion
        #endregion
    }
}