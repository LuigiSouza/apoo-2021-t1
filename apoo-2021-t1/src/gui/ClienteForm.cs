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
            Item[] items = facade.getItems();
            foreach (Item item in items)
            {
                ItemControl itemControl = new ItemControl(minus_btn, add_btn);
                itemControl.Title = item.getName();
                itemControl.Price = item.getValue();
                itemControl.Quantity = 0;
                itemControl.Id = item.getId();
                flowLayoutPanel1.Controls.Add(itemControl);
            };
        }

        private void minus_btn(object sender, EventArgs e)
        {
            ItemControl item = (ItemControl)sender;
            if (facade.removeFromCart(item.Id))
            {
                item.Quantity -= 1;
                Total -= item.Price;
            }
        }
        private void add_btn(object sender, EventArgs e)
        {
            ItemControl item = (ItemControl)sender;
            if (facade.addToCart(item.Id))
            {
                item.Quantity += 1;
                Total += item.Price;
            }
        }

        private void clearCart_Click(object sender, EventArgs e)
        {
            facade.clearCart();
            foreach (ItemControl item in flowLayoutPanel1.Controls)
                item.Quantity = 0;
            Total = 0;
        }

        private void finishCart_Click(object sender, EventArgs e)
        {
            facade.order();
            foreach (ItemControl item in flowLayoutPanel1.Controls)
                item.Quantity = 0;
            Total = 0;
        }
    }
}
