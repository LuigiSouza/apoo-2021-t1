using System;
using apoo_2021_t1.src.Models;
using apoo_2021_t1.src.utils;

namespace apoo_2021_t1.src.Singleton
{
    class BancoProxy : BancoOperacoes
    {
        private int id;

        public BancoProxy()
        {
            Console.WriteLine("Criando proxy");
        }

        public BancoProxy(int id)
        {
            Console.WriteLine("Criando proxy");
            this.id = id;
        }

        private bool hasOwnership(Order order) { return order.getUserId() == id; }

        private bool hasPermission(Roles_enum role)
        {
            Pessoa pessoa;
            if (!db.pessoas_id_indexes.TryGetValue(id, out pessoa))
            {
                return false;
            }

            return pessoa.getRole() == role;
        }

        public override Order createOrder(int user_id)
        {
            if (hasPermission(Roles_enum.customer))
            {
                return base.createOrder(user_id);
            }
            return null;
        }

        public override Order[] getOrders()
        {
            if (hasPermission(Roles_enum.admin))
            {
                return base.getOrders();
            }
            return null;
        }

        public override Order[] getOwnOrders(int id)
        {
            return base.getOwnOrders(this.id);
        }

        public override Order getOrder(int id)
        {
            Order order = base.getOrder(id);
            if (hasOwnership(order) || hasPermission(Roles_enum.admin))
            {
                return order;
            }
            return null;
        }

        public override myTuple<Item, int>[] getOrderItems(int id)
        {
            Order order = base.getOrder(id);
            if (hasOwnership(order) || hasPermission(Roles_enum.admin))
            {
                return base.getOrderItems(id);
            }
            return null;
        }
    }
}
