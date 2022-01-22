using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Roles_enum
{
    customer,
    admin
}

namespace apoo_2021_t1.src.Models
{
    abstract class Pessoa
    {
        protected Roles_enum role;
        protected string user;

        private string password;
        private int id;

        public Pessoa(string user, string password, int id)
        {
            this.user = user;
            this.password = password;
            this.id = id;
        }

        public string getUser() { return user; }
        public int getId() { return id; }
        public string getRole() { return role.ToString(); }

        public bool passwordCorrect(string password) { return this.password == password; }
    }
}
