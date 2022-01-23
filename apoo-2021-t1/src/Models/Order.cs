using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apoo_2021_t1.src.Models;
using apoo_2021_t1.src.utils;

namespace apoo_2021_t1.src.Models
{
    class Order
    {
        private IDictionary<int, myTuple<Comida, int>> comidas;
        public bool finished = false;
        public Order()
        {
            this.comidas = new Dictionary<int, myTuple<Comida, int>>();
        }

        public void addItem(int id, myTuple<Comida, int> comida)
        {
            this.comidas.Add(id, comida);
        }
    }
}
