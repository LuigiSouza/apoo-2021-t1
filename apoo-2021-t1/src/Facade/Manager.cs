using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apoo_2021_t1.src.Singleton;
using apoo_2021_t1.src.Models;
using apoo_2021_t1.src.utils;

namespace apoo_2021_t1.src.Facade
{
    public class Manager
    {
        private BancoProxy db;
        private int id;

        internal IDictionary<int, myTuple<Comida, int>> cart;
        public Manager(int id)
        {
            Console.WriteLine("Criando Facade");
            this.id = id;
            db = new BancoProxy(id);
            cart = new Dictionary<int, myTuple<Comida, int>>();
        }

        public Comida[] getItems()
        {
            return db.getItems();
        }

        public bool addToCart(int id)
        {
            myTuple<Comida, int> comida;
            if (!cart.TryGetValue(id, out comida))
            {
                Comida exists = db.getItem(id);
                if (exists == null) return false;
                cart.Add(id, new myTuple<Comida, int>(exists, 1));
                return true;
            }
            cart[id].Item2 += 1;
            return true;
        }
        public bool removeFromCart(int id)
        {
            myTuple<Comida, int> comida;
            if (!cart.TryGetValue(id, out comida))
            {
                return false;
            }
            if (cart[id].Item2 == 0) return false;
            cart[id].Item2 -= 1;
            return true;
        }

        public void clearCart()
        {
            cart.Clear();
        }

        public void order()
        {
            Order pedido = new Order();

            cart.Clear();
        }
    }
}
