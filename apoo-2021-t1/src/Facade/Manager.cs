using System;
using System.Collections.Generic;
using apoo_2021_t1.src.Singleton;
using apoo_2021_t1.src.Models;
using apoo_2021_t1.src.utils;

namespace apoo_2021_t1.src.Facade
{
    public class Manager
    {
        private BancoProxy db;
        private int id;

        ///
        /// Carrinho com os itens a serem pedidos: 
        /// IDictionary<quantia, myTuple<Item, id>> ...
        private IDictionary<int, myTuple<Item, int>> cart;
        public Manager(int id)
        {
            Console.WriteLine("Criando Facade");
            this.id = id;
            db = new BancoProxy(id);
            cart = new Dictionary<int, myTuple<Item, int>>();
        }

        public Item[] getItems()
        {
            return db.getItems();
        }

        public bool addToCart(int id)
        {
            myTuple<Item, int> item;
            if (!cart.TryGetValue(id, out item))
            {
                Item exists = db.getItem(id);
                if (exists == null) return false;
                cart.Add(id, new myTuple<Item, int>(exists, 1));
                return true;
            }
            cart[id].Item2 += 1;
            return true;
        }
        public bool removeFromCart(int id)
        {
            myTuple<Item, int> item;
            if (!cart.TryGetValue(id, out item))
            {
                return false;
            }
            if (item.Item2 == 0) return false;
            item.Item2 -= 1;
            return true;
        }

        public void clearCart()
        {
            cart.Clear();
        }

        public void order()
        {
            Order order = db.createOrder(id);

            foreach (int key in cart.Keys)
                if (cart[key].Item2 > 0) order.addItem(key, cart[key]);

            cart.Clear();
        }

        public Order[] getOwnOrders()
        {
            return db.getOwnOrders(this.id);
        }
        public Order[] getOrders()
        {
            return db.getOrders();
        }

        public Order getOrder(int id)
        {
            return db.getOrder(id);
        }

        public myTuple<Item, int>[] getOrderItems(int id)
        {
            return db.getOrderItems(id);
        }
    }
}
