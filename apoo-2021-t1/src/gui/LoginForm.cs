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
using apoo_2021_t1.src.utils;

namespace apoo_2021_t1.src.gui
{
    public partial class LoginForm : Form
    {
        BancoProxy db;

        public LoginForm()
        {
            db = new BancoProxy();
            Storage asdf = Storage.Instance;
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
            myTuple<int, string> data = db.login(user, password);
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

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
