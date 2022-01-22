using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apoo_2021_t1.src.Models;

namespace apoo_2021_t1.src.Singleton
{
    class BancoProxy
    {
        private Banco db;
        private int id;

        public BancoProxy()
        {
            Console.WriteLine("Criando proxy");
            db = Banco.Instance;
        }

        public BancoProxy(int id)
        {
            db = Banco.Instance;
            this.id = id;
        }

        private void hasPermission() { }

        public Tuple<int, string> login(string user, string password)
        {
            Pessoa pessoa = db.login(user, password);

            if (pessoa == null) return null;
            return Tuple.Create(pessoa.getId(), pessoa.getRole());
        }
    }
}
