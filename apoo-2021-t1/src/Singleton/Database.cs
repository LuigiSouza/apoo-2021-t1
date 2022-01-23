﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apoo_2021_t1.src.Models;

namespace apoo_2021_t1.src.Singleton
{
    internal class Database
    {
        static Database db_instance = null;

        internal IDictionary<int, Comida> itens;
        internal int count_id_item = 1;

        internal IDictionary<int, Order> pedidos;
        internal int count_id_pedido = 1;

        internal IDictionary<string, Pessoa> pessoas;
        internal IDictionary<int, Pessoa> pessoas_id_indexes;
        internal int count_id_pessoa = 1;

        private Database()
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

            itens = new Dictionary<int, Comida>
            {
                { 1, new Comida("Hamburguer", 5.0f, 1) },
                { 2, new Comida("Pastel", 3.5f, 2) },
                { 3, new Comida("Café", 1.0f, 3) }
            };
            count_id_item = 4;
        }

        public static Database Instance
        {
            get
            {
                if (db_instance == null)
                    db_instance = new Database();
                return db_instance;
            }
        }
    }
}
