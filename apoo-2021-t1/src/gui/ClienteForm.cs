using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apoo_2021_t1.src.gui.components;
using apoo_2021_t1.src.Models;
using apoo_2021_t1.src.Facade;

namespace apoo_2021_t1.src.gui
{
    public partial class ClienteForm : Form
    {
        private int id;
        private Manager facade;

        public ClienteForm(int id)
        {
            this.id = id;
            facade = new Manager(id);
            InitializeComponent();
            Total = 0.0f;
        }

        #region Properties

        private float _total;

        [Category("Custom Props")]
        public float Total
        {
            get { return _total; }
            set { _total = value; total.Text = "R$ " + value.ToString("0.00"); }
        }

        #endregion

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            Comida[] items = facade.getItems();
            foreach (Comida comida in items)
            {
                Item item = new Item(minus_btn, add_btn);
                item.Title = comida.getName();
                item.Price = comida.getValue();
                item.Quantity = 0;
                item.Id = comida.getId();
                flowLayoutPanel1.Controls.Add(item);
            };
        }

        private void minus_btn(object sender, EventArgs e)
        {
            Item item = (Item)sender;
            if (facade.removeFromCart(item.Id))
            {
                item.Quantity -= 1;
                update_total(-item.Price);
            }
        }
        private void add_btn(object sender, EventArgs e)
        {
            Item item = (Item)sender;
            if (facade.addToCart(item.Id))
            {
                item.Quantity += 1;
                update_total(item.Price);
            }
        }

        private void update_total(float total)
        {
            this.Total += total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            facade.clearCart();
            foreach (Item item in flowLayoutPanel1.Controls)
                item.Quantity = 0;
        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
