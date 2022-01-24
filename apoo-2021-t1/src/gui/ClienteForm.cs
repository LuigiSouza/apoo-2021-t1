using System;
using System.ComponentModel;
using System.Windows.Forms;
using apoo_2021_t1.src.gui.components;
using apoo_2021_t1.src.Models;
using apoo_2021_t1.src.Facade;
using apoo_2021_t1.src.utils;

namespace apoo_2021_t1.src.gui
{
    public partial class ClienteForm : Form
    {
        private int id;
        private Manager facade;

        private bool main = true;
        private bool show = false;

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

        private void hideComponents()
        {
            total.Hide();
            clearCart.Hide();
            finishCart.Hide();
            total.Hide();
            labelTotal.Hide();
        }
        private void showComponents()
        {
            total.Show();
            clearCart.Show();
            finishCart.Show();
            total.Show();
            labelTotal.Show();
        }
        private void loadPanelItems()
        {
            flowLayoutPanel1.Controls.Clear();
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

        private void loadPanelOrders()
        {
            flowLayoutPanel1.Controls.Clear();
            Order[] orders = facade.getOwnOrders();
            foreach (Order order in orders)
            {
                OrderControl orderControl = new OrderControl(expand);
                orderControl.Price = order.getTotalPrice();
                orderControl.Quantity = order.getTotalCount();
                orderControl.Id = order.getId();
                orderControl.Status = order.getStatus();
                flowLayoutPanel1.Controls.Add(orderControl);
            };
        }
        private void switchShow(object sender, EventArgs e)
        {
            if (show)
            {
                flowLayoutPanel1.Show();
                orderDetails.Hide();
            }
            else
            {
                flowLayoutPanel1.Hide();
                orderDetails.Show();
            }
            show = !show;
        }

        private void expand(object sender, EventArgs e)
        {
            OrderControl orderControl = (OrderControl)sender;
            Order order = facade.getOrder(orderControl.Id);
            if (order == null) return;
            orderDetails.loadComponent(id, order);
            myTuple<Item, int>[] itens = facade.getOrderItems(order.getId());
            foreach (myTuple<Item, int> item in itens)
            {
                Console.WriteLine(item.Item1.getName());
                orderDetails.addItem(item);
            }
            switchShow(sender, e);
        }

        private void ClienteForm_Load(object sender, EventArgs e)
        {
            this.orderDetails.Hide();
            showComponents();
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

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            if (!main)
            {
                loadPanelItems();
                showComponents();
                flowLayoutPanel1.Show();
                orderDetails.Hide();
                if (show) switchShow(sender, e);
                main = true;
            }
        }

        private void oderbtn_Click(object sender, EventArgs e)
        {
            if (main)
            {
                loadPanelOrders();
                hideComponents();
                main = false;
            }

        }
    }
}
