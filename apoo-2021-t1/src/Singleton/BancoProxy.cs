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

        private void hasPermission() { }


    }
}
