using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apoo_2021_t1.src.gui
{
    public partial class ClienteForm : Form
    {
        private int id;
        public ClienteForm(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {

        }
    }
}
