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
using apoo_2021_t1.src.Facade;
using apoo_2021_t1.src.Models;

namespace apoo_2021_t1.src.gui
{
    public partial class AdminForm : Form
    {
        private int id;
        private Manager facade;
        public AdminForm(int id)
        {
            this.id = id;
            this.facade = new Manager(id);
            InitializeComponent();
        }

        private void loadOrders()
        {
            Order[] orders = facade.getOrders();
            foreach (Order order in orders)
            {
                OrderControl orderControl = new OrderControl(expand);
                orderControl.Price = order.getTotalPrice();
                orderControl.Quantity = order.getTotalCount();
                orderControl.Id = order.getId();
                orderControl.Status = order.getStatus();
                flowLayoutOrders.Controls.Add(orderControl);
            };
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            loadOrders();
        }

        private void expand(object sender, EventArgs e)
        {

        }

        private void refresh_Click(object sender, EventArgs e)
        {
            flowLayoutOrders.Controls.Clear();
            loadOrders();
        }
    }
}
