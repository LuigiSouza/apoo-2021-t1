using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apoo_2021_t1.src.Models
{
    class Administrador : Pessoa
    {
        public Administrador(string user, string password, int id) : base(user, password, id)
        {
            this.role = Roles_enum.admin;
        }
    }
}
