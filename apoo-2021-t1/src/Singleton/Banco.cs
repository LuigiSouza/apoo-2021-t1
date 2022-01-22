using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apoo_2021_t1.src.Models;

namespace apoo_2021_t1.src.Singleton
{
    internal class Banco
    {
        static Banco db_instance = null;

        private IDictionary<string, Pessoa> pessoas;
        private IDictionary<int, Pessoa> pessoas_id_indexes;
        private Banco()
        {
            Console.WriteLine("Criando banco");
            pessoas = new Dictionary<string, Pessoa>
            {
                { "admin", new Administrador("admin", "admin", 1) },
                { "cliente", new Cliente("cliente", "cliente", 2) }
            };
            pessoas_id_indexes = new Dictionary<int, Pessoa>
            {
                {1, pessoas["admin"] },
                {2, pessoas["cliente"] }
            };
        }

        public void addIngrediente() { }

        public Pessoa login(string user, string password)
        {
            Pessoa pessoa;
            if (!pessoas.TryGetValue(user, out pessoa))
            {
                return null;
            }

            return pessoa;
        }

        public static Banco Instance
        {
            get
            {
                if (db_instance == null)
                    db_instance = new Banco();
                return db_instance;
            }
        }
    }
}
