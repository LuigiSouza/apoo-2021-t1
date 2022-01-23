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
        protected Database db;
        public BancoOperações()
        {
            Console.WriteLine("Criando Operações");
            db = Database.Instance;
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
        public Comida getItem(int id)
        {
            Comida comida;
            if (!db.itens.TryGetValue(id, out comida))
            {
                return null;
            }

            return comida;
        }

        public Comida[] getItems()
        {
            ICollection<Comida> values = db.itens.Values;
            Comida[] comidas = new Comida[db.itens.Count];
            int i = 0;
            foreach (Comida comida in values) comidas[i++] = comida;
            return comidas;
        }

        public virtual void addOrder(Order order)
        {
            db.pedidos.Add(db.count_id_pedido++, order);
        }
    }
}
