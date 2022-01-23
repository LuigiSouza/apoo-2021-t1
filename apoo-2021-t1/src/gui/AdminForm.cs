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
using apoo_2021_t1.src.utils;

namespace apoo_2021_t1.src.gui
{
    public partial class AdminForm : Form
    {
        private int id;
        private Manager facade;
        private bool show = false;
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
            orderDetails.Hide();
            loadOrders();
        }

        private void switchShow(object sender, EventArgs e)
        {
            if (show)
            {
                flowLayoutOrders.Show();
                refresh.Show();
                orderDetails.Hide();
            }
            else
            {
                flowLayoutOrders.Hide();
                refresh.Hide();
                orderDetails.Show();
            }
            show = !show;
        }

        private void expand(object sender, EventArgs e)
        {
            OrderControl orderControl = (OrderControl)sender;
            Order order = facade.getOrder(orderControl.Id);
            if (order == null) return;
            orderDetails.loadComponent(order);
            myTuple<Item, int>[] itens = facade.getOrderItems(order.getId());
            foreach (myTuple<Item, int> item in itens)
            {
                Console.WriteLine(item.Item1.getName());
                orderDetails.addItem(item);
            }
            switchShow(sender, e);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            flowLayoutOrders.Controls.Clear();
            loadOrders();
        }

        private void orderDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
