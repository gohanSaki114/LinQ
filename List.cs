using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ
{
    public class List
    {
        public enum Color
        {
            Red, Green, Yellow
        }

        public class Fruit
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public Color Color { get; set; }
            public double Price { get; set; }


        }
        //public static List<Fruit> GetFruits()
        //{
        //    return new List<Fruit>()
        //    {


        //        new Fruit { Id = "f1", Name = "Apple", Color = Color.Red, Price = 23.0, },
        //        new Fruit { Id = "f2", Name = "Banana", Color = Color.Yellow, Price = 10.0, },
        //        new Fruit { Id = "f3", Name = "Pineapple", Color = Color.Yellow, Price = 55.0, },
        //        new Fruit { Id = "f4", Name = "Cherry", Color = Color.Red, Price = 40.0, },
        //        new Fruit { Id = "f5", Name = "Watermelon", Color = Color.Green, Price = 28.0, },
        //        new Fruit { Id = "f6", Name = "Strawberry", Color = Color.Red, Price = 33.0, }
        //    };
        //}
    }
}




