using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallorieMapBL
{
    public class Product
    {
        public string Name { get; set; }
        public int Callorie { get; set; }

        public Product(string name, int callorie)
        {
            Name = name;
            Callorie = callorie;
        }
    }
}
