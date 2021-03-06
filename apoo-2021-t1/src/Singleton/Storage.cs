using System;
using System.Collections.Generic;
using apoo_2021_t1.src.Models;

namespace apoo_2021_t1.src.Singleton
{
    internal class Storage
    {
        private static Storage db_instance = null;

        /**
        * ... IDictionary<id, Model> ...
        */
        public IDictionary<int, Item> itens;
        public int count_id_item = 1;

        /**
        * ... IDictionary<id, Model> ...
        */
        public IDictionary<int, Order> pedidos;
        public int count_id_pedido = 1;

        /**
        * ... IDictionary<user, Model> ...
        */
        public IDictionary<string, Pessoa> pessoas;
        /**
        * ... IDictionary<id, Model> ...
        */
        public IDictionary<int, Pessoa> pessoas_id_indexes;
        public int count_id_pessoa = 1;

        private Storage()
        {
            Console.WriteLine("Criando banco");

            pessoas = new Dictionary<string, Pessoa>
            {
                { "admin", new Administrador("admin", "admin", 1) },
                { "cliente", new Cliente("cliente", "cliente", 2) },
                { "cliente2", new Cliente("cliente2", "cliente2", 3) }
            };
            pessoas_id_indexes = new Dictionary<int, Pessoa>
            {
                {1, pessoas["admin"] },
                {2, pessoas["cliente"] },
                {3, pessoas["cliente2"] }
            };
            count_id_pessoa = 4;

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
