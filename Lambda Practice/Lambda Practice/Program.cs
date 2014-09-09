using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = new List<string>() {"Basketball", "Baseball", "Tennis Raquet", "Running Shoes", "Wrestling Shoes", 
                "Soccer Ball", "Football", "Shoulder Pads", 
                "Trail Running Shoes", "Cycling Shoes", "Kayak", "Kayak Paddles"};


            //declare a variable kayakProducts and set it equal to all products that contain the word "Kayak"
            List<string> kayakProducts = products.Where(x => x.Contains("kayak")).ToList();

            //print the kayakProducts to the console using a foreach loop.
            foreach (var kayak in kayakProducts)
            {
                Console.WriteLine(kayak);
            }
            //declare a variable shoeProducts and set it equal to all products that contain the word "Shoes"
            List<string> shoeProducts = products.Where(x => x.Contains("shoes")).ToList();
            //print the shoeProducts to the console using a foreach loop or string.Join().
            Console.WriteLine(string.Join(", ", products.Where(x => x.Contains("shoes"))));
            //declare a variable ballProducts and set it equal to all the products that have ball in the name.
            List<string> ballProducts = products.Where(x => x.Contains("ball")).ToList();
            //print the ballProducts to the console using a foreach loop or string.Join().
            Console.WriteLine(string.Join(", ", products.Where(x => x.Contains("ball"))));
            //sort ballProducts alphabetically and print them to the console.
            Console.WriteLine(string.Join(", ", products.OrderBy(x => x)));
            //add six more items to the products list using .add().
            products.Add("ki Boots");         
            products.Add("Boots");
            products.Add("Ball Cart");
            products.Add("Towels");
            products.Add("Life Jackets");
            products.Add("Life Jacket");
            //print the product with the longest name to the console using the .First() extension.
            Console.WriteLine(products.OrderByDescending(x => x.Length).First());
            //print the product with the shortest name to the console using OrderByDesceding() and the .First() extension.
            Console.WriteLine(products.OrderByDescending(x => x.Length).First());
            //print the product with the 4th shortest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Console.WriteLine(products.OrderBy(x => x.Length).ToList().Skip(3).First());
            //print the ballProduct with the 2nd longest name to the console using an index or Skip/Take (you must convert the results to a list using .ToList()).
            Console.WriteLine(ballProducts.OrderByDescending(x => x.Length).Skip(1).First());
            //declare a variable reversedProducts and set it equal to all products ordered by the longest word first. (use the OrderByDescending() extension).
            List<string> reverseProducts = products.OrderByDescending(x => x.Length).ToList();
            //print out the reversedProducts to the console using a foreach loop.
            foreach (var x in reverseProducts)
            {
	            Console.WriteLine(x);
            }

            //print out all the products ordered by the longest word first using the OrderByDecending() extension and a foreach loop.  
            foreach (var item in products)
            {
                Console.WriteLine(products.OrderByDescending(x => x.Length).First());
            }
            //Note: you will not use a variable to store your list

            Console.ReadKey();
        }
    }
}