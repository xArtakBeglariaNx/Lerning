using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_step_66_LINQ_FunWithLinqExpression
{
    #region ProductInfo class
    class ProductInfo
    {
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public int NumberInStock { get; set; } = 0;
        public override string ToString() => $"Name: {Name}, Description: {Description}, Number In Stock: {NumberInStock}";
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Fun with Querry Expression =====");

            #region Fill Arrat data
            ProductInfo[] itemInStock = new[] {
            new ProductInfo { Name = "Mac's Coffee",
                            Description = "Coffee with TEETH",
                            NumberInStock = 24},
            new ProductInfo { Name = "Milk Maid Milk",
                            Description = "Milk cow's love",
                            NumberInStock = 100},
            new ProductInfo { Name = "Pure Silk Tofu",
                            Description = "Bland as possible",
                            NumberInStock = 120},
            new ProductInfo { Name = "Crunch POPS",
                            Description = "Cheezy, peppery goodness",
                            NumberInStock = 2},
            new ProductInfo { Name = "RipOff Water",
                            Description = "From the tap to your wallet",
                            NumberInStock = 100},
            new ProductInfo { Name = "Classic Valpo Pizza",
                            Description = "Everyone loves pizza",
                            NumberInStock = 73}
            };
            #endregion

            SelectEverything(itemInStock);
            ListProductNames(itemInStock);
            GetOverStock(itemInStock);
            GetNamesAndDescriptions(itemInStock);

            #region GetProjectedSubset
            Array obj = GetProjectedSubset(itemInStock);
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.WriteLine();

            GetCountFromQuerry();
            ReverseEverything(itemInStock);
            AlphabetizeProductName(itemInStock);
            DisplayDiff();
            DisplayIntersection();
            DisplayUnion();
            DisplayConcat();
            DisplayConcatNoDups();
            AgregateOps();

            Console.ReadLine();
        }
        #region Linq querrys
        static void SelectEverything(ProductInfo[] products)
        {
            Console.WriteLine("All product details:");

            var allProducts = from p in products select p;
            foreach (var prod in allProducts)
            {
                Console.WriteLine(prod.ToString());
            }
            Console.WriteLine();
        }

        static void ListProductNames(ProductInfo[] products)
        {
            Console.WriteLine("Product names:");

            var nameProducts = from p in products select p.Name;
            foreach (var prodName in nameProducts)
            {
                Console.WriteLine($"Name: {prodName}");
            }
            Console.WriteLine();
        }

        static void GetOverStock(ProductInfo[] products)
        {
            Console.WriteLine("Products over 25 items:");
            var overStock = from p in products where p.NumberInStock > 25 select p;
            foreach (var overProd in overStock)
            {
                Console.WriteLine($"In Stock over 25 items: {overProd}");
            }
            Console.WriteLine();
        }

        static void GetNamesAndDescriptions(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions: ");
            var nameDesc = from p in products select new { p.Name, p.Description };
            foreach (var nD in nameDesc)
            {
                Console.WriteLine(nD.ToString());
            }
            Console.WriteLine();
        }

        #region Аннонимный тип данных
        /*static var GetProjectedSubset(ProductInfo[] products)
         * {var nameDesc = from p in products select new {p.Name, p.Description};
         *  return nameDesc; // Так поступать нельзя
         * }
         */
        static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from p in products select new { p.Name, p.Description };
            return nameDesc.ToArray();
        }
        #endregion        

        static void GetCountFromQuerry()
        {
            Console.WriteLine("Get Count from Querry: ");
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "FallOut 2", "Dexter", "System Shock 2" };
            int num = (from g in currentVideoGames where g.Length > 6 select g).Count();
            Console.WriteLine("{0} items honor the LINQ querry.", num);
            Console.WriteLine();
        }

        static void ReverseEverything(ProductInfo[] products)
        {
            Console.WriteLine("Reverse all:");
            var reversAllProd = from p in products select p;
            foreach (var item in reversAllProd.Reverse())
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
        }

        static void AlphabetizeProductName(ProductInfo[] products)
        {
            Console.WriteLine("Sort in Alpahbetize:");
            var subset = from p in products orderby p.Name descending select p;
            foreach (var p in subset)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            var subset1 = from p in products orderby p.Name ascending select p;
            foreach (var p in subset1)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }
        #endregion

        #region Extending Methods in querrys (diagramm Venna)
        static void DisplayDiff()
        {
            List<string> myCars = new List<string> { "Aztec", "Yugo", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            var carDiff = (from c in myCars select c).Except(from c2 in yourCars select c2);
            var carDiff2 = (from c in yourCars select c).Except(from c2 in myCars select c2);
            Console.WriteLine("Here is what you don,t have, but i do:");
            foreach (var car in carDiff)
            {
                Console.WriteLine(car);
                foreach (var car2 in carDiff2)
                {
                    Console.WriteLine(car2);
                }
            }
            Console.WriteLine();
        }

        static void DisplayIntersection()
        {
            List<string> myCars = new List<string> { "Aztec", "Yugo", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            var interSec = (from c in myCars select c).Intersect(from c2 in yourCars select c2);
            Console.WriteLine("Here is what we have in common: ");
            foreach (var sec in interSec)
            {
                Console.WriteLine(sec);
            }
            Console.WriteLine();
        }

        static void DisplayUnion()
        {
            List<string> myCars = new List<string> { "Aztec", "Yugo", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            var union = (from c in myCars select c).Union(from c2 in yourCars select c2);
            Console.WriteLine("Here is everything:");
            foreach (var item in union)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        static void DisplayConcat()
        {
            List<string> myCars = new List<string> { "Aztec", "Yugo", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            var concat = (from c in myCars select c).Concat(from c2 in yourCars select c2);
            Console.WriteLine("Here is concatination:");
            foreach (var ct in concat)
            {
                Console.WriteLine(ct);
            }
            Console.WriteLine();
        }
        static void DisplayConcatNoDups()
        {
            List<string> myCars = new List<string> { "Aztec", "Yugo", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };
            var carConcat = (from c in myCars select c).Concat(from c2 in yourCars select c2);
            Console.WriteLine("Here is concatination:");
            foreach (var ct in carConcat.Distinct())
            {
                Console.WriteLine(ct);
            }
            Console.WriteLine();
        }

        static void AgregateOps()
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8, 2 };
            Console.WriteLine("Max temp: {0}", (from t in winterTemps select t).Max());
            Console.WriteLine("Min temp: {0}", (from t in winterTemps select t).Min());
            Console.WriteLine("Avarage temp: {0}", (from t in winterTemps select t).Average());
            Console.WriteLine("Sum temp: {0}", (from t in winterTemps select t).Sum());
            Console.WriteLine();
        }
        #endregion
    }
}
