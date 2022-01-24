using System;
using System.Windows.Forms;
using apoo_2021_t1.src.Singleton;
using apoo_2021_t1.src.utils;
using apoo_2021_t1.src.gui.Factory;

namespace apoo_2021_t1.src.gui
{
    public partial class LoginForm : Form
    {
        private BancoProxy db;
        private FactoryForm factory;

        public LoginForm()
        {
            db = new BancoProxy();
            InitializeComponent();
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
                        factory = new ClienteFactory();
                        break;
                    case "admin":
                        factory = new AdminFactory();
                        break;
                    default:
                        MessageBox.Show("Role inválida.");
                        return;
                }
                factory.createForm(data.Item1).Show();

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
