using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject.Soup
{
    internal abstract class Soup
    {
        public Soup(string name, int price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; private set; }

        public int Price { get; private set; }

    }
}
