using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apoo_2021_t1.src.Models;

namespace apoo_2021_t1.src.Singleton
{
    internal class Storage
    {
        static Storage db_instance = null;

        internal IDictionary<int, Item> itens;
        internal int count_id_item = 1;

        internal IDictionary<int, Order> pedidos;
        internal int count_id_pedido = 1;

        internal IDictionary<string, Pessoa> pessoas;
        internal IDictionary<int, Pessoa> pessoas_id_indexes;
        internal int count_id_pessoa = 1;

        private Storage()
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
            count_id_pessoa = 3;

            itens = new Dictionary<int, Item>
            {
                { 1, new Item("Hamburguer", 5.0f, 1) },
                { 2, new Item("Pastel", 3.5f, 2) },
                { 3, new Item("Café", 1.0f, 3) }
            };
            count_id_item = 4;

            pedidos = new Dictionary<int, Order>();
        }

        public static Storage Instance
        {
            get
            {
                if (db_instance == null)
                    db_instance = new Storage();
                return db_instance;
            }
        }
    }
}
