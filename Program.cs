using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinQ.List;

namespace LinQ
{
    public class Program
    {
        List<Fruit> fruits = new List<Fruit>() {


                new Fruit { Id = "f1", Name = "Apple", Color = Color.Red, Price = 23.0, },
                new Fruit { Id = "f2", Name = "Banana", Color = Color.Yellow, Price = 10.0, },
                new Fruit { Id = "f3", Name = "Pineapple", Color = Color.Yellow, Price = 55.0, },
                new Fruit { Id = "f4", Name = "Cherry", Color = Color.Red, Price = 40.0, },
                new Fruit { Id = "f5", Name = "Watermelon", Color = Color.Green, Price = 28.0, },
                new Fruit { Id = "f6", Name = "Strawberry", Color = Color.Red, Price = 33.0, }
            };
        public static void Main(string[] args)
        {

            Program program = new Program();
            //descendingorder
            var fruitInDescendingOrder = program.fruits.OrderByDescending(Fruit => Fruit.Name);
            Console.WriteLine();

            Console.WriteLine("DescendingOrder");

            foreach (var f in fruitInDescendingOrder)
            {
                Console.WriteLine(f.Name);

            }
            Console.WriteLine("");

            Console.WriteLine("Ascendingorder");
          
            //ascendingorder
            Console.WriteLine("");
            var fruitInOrder = program.fruits.OrderBy(Fruit => Fruit.Name);
            foreach (var f in fruitInOrder)
            {
                Console.WriteLine(f.Name);
            }
            

            Console.WriteLine("Color Green&Red");
        
            Console.WriteLine("");
            //green&red fruit
            
            var fruitwithcolor = program.fruits.Where(Fruit => Fruit.Color == Color.Red || Fruit.Color == Color.Green);
            foreach (var f in fruitwithcolor)
            {
                Console.WriteLine(f.Name);
            }
            //cheapest fruit
         
            Console.WriteLine("");
            Console.WriteLine("Cheapest");
           
            var mybudget = 30;
            var cheapestfruit = program.fruits.Where(Fruit => Fruit.Price <= mybudget);
            foreach (var f in cheapestfruit)
            {
                Console.WriteLine(f.Name);
            }
     
            Console.WriteLine("");
            Console.WriteLine("Expensive");
         
            var greaterthan = 40;
            var Costlyest = program.fruits.Where(Fruit => Fruit.Price > greaterthan);
            foreach (var f in Costlyest)
            {
                Console.WriteLine(f.Name);
            }
        
            Console.WriteLine("");
            Console.WriteLine("Under40");
           
            var budget = 40;
            var mybudgetfruit = program.fruits.Where(Fruit => Fruit.Price <= budget);
            foreach (var f in mybudgetfruit)
            {
                Console.WriteLine(f.Name);
            }
           
            Console.WriteLine("NumberofRedfruit");
           
            var redfruit = program.fruits.Count(Fruit => Fruit.Color == Color.Red);
            Console.WriteLine(redfruit);
            
            Console.WriteLine("FruitWithcolor");
         
            var fruitwithcolor1 = program.fruits.GroupBy(Fruit => Fruit.Color);

            foreach (var Group in fruitwithcolor1)
            {
                Console.WriteLine(("GroupID = " + Group.Key));
                foreach (var cx in Group)
                {
                    Console.WriteLine(cx.Name);
                }
            }


        }


    }
}


