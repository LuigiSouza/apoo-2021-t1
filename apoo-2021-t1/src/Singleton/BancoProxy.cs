using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apoo_2021_t1.src.Models;

namespace apoo_2021_t1.src.Singleton
{
    class BancoProxy : BancoOperações
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
    }
}
