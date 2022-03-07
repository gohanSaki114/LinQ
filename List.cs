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
       
    }
}




