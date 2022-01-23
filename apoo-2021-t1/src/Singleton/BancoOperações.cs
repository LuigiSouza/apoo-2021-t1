using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apoo_2021_t1.src.Models;
using apoo_2021_t1.src.utils;

namespace apoo_2021_t1.src.Singleton
{
    class BancoOperações
    {
        protected Storage db;
        public BancoOperações()
        {
            Console.WriteLine("Criando Operações");
            db = Storage.Instance;
        }
        public Pessoa getPessoa(string user)
        {
            Pessoa pessoa;
            if (!db.pessoas.TryGetValue(user, out pessoa))
            {
                return null;
            }

            return pessoa;
        }
        public Pessoa getPessoa(int id)
        {
            Pessoa pessoa;
            if (!db.pessoas_id_indexes.TryGetValue(id, out pessoa))
            {
                return null;
            }

            return pessoa;
        }
        public myTuple<int, string> login(string user, string password)
        {
            Pessoa pessoa = getPessoa(user);

            if (pessoa == null || !pessoa.passwordCorrect(password)) return null;
            return new myTuple<int, string>(pessoa.getId(), pessoa.getRole().ToString());
        }
        public Item getItem(int id)
        {
            Item item;
            if (!db.itens.TryGetValue(id, out item))
            {
                return null;
            }

            return item;
        }

        public Item[] getItems()
        {
            ICollection<Item> values = db.itens.Values;
            Item[] items = new Item[db.itens.Count];
            int i = 0;
            foreach (Item item in values) items[i++] = item;
            return items;
        }
        public virtual Order[] getOrders()
        {
            ICollection<Order> values = db.pedidos.Values;
            Order[] orders = new Order[db.pedidos.Count];
            int i = 0;
            foreach (Order order in values) orders[i++] = order;
            return orders;
        }

        public virtual Order createOrder(int user_id)
        {
            Order order = new Order(db.count_id_pedido, user_id);
            db.pedidos.Add(db.count_id_pedido++, order);
            return order;
        }
    }
}
