using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apoo_2021_t1.src.Singleton;
using apoo_2021_t1.src.gui;

namespace apoo_2021_t1
{
    public partial class LoginForm : Form
    {
        BancoProxy db;

        public LoginForm()
        {
            db = new BancoProxy();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string user = this.textBoxLogin.Text;
            string password = this.textBoxPassword.Text;
            Tuple<int, string> data = db.login(user, password);
            if (data == null)
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }
            else
            {
                Console.WriteLine("Login: " + data.Item2);
                switch (data.Item2)
                {
                    case "customer":
                        new ClienteForm(data.Item1).Show();
                        break;
                    case "admin":
                        new AdminForm(data.Item1).Show();
                        break;
                    default:
                        MessageBox.Show("Role inválida.");
                        break;
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
