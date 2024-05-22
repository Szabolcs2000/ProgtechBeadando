using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufeBeadandoProject.Soup
{
    internal class BeanSoup : Soup
    {
        public BeanSoup(string name, int price) : base(name, price)
        {
            name = "Bableves";
            price = 500;
        }
    }
}
