using System;
using System.ComponentModel;
using System.Windows.Forms;
using apoo_2021_t1.src.utils;
using apoo_2021_t1.src.Models;
using apoo_2021_t1.src.Command;

namespace apoo_2021_t1.src.gui.components
{
    public partial class OrderDetailsControl : UserControl
    {
        private Command.Command reject, accept;
        private EventHandler backClick;
        public OrderDetailsControl()
        {
            InitializeComponent();
        }

        public OrderDetailsControl(EventHandler backClick)
        {
            this.backClick = backClick;
            InitializeComponent();
        }
        #region Properties

        private string _status;
        private float _price;
        private int _id;

        [Category("Custom Props")]
        public string Status
        {
            get { return _status; }
            set { _status = value; this.status.Text = _status; }
        }

        [Category("Custom Props")]
        public float Price
        {
            get { return _price; }
            set { _price = value; price.Text = "R$ " + value.ToString("0.00"); }
        }


        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; this.id.Text = value.ToString(); }
        }

        #endregion

        public void addItem(myTuple<Item, int> tuple)
        {
            ItemDetailsControl item = new ItemDetailsControl();
            item.Quantity = tuple.Item2;
            item.Title = tuple.Item1.getName();
            item.Price = tuple.Item1.getValue();
            flowLayoutPanel1.Controls.Add(item);
        }

        public void loadComponent(int id, Order order)
        {
            reject = new RejectCommand(order);
            accept = new AcceptCommand(order);
            this.Id = order.getId();
            this.Status = order.getStatus();
            this.Price = order.getTotalPrice();
            if (order.status != "Pendente" || order.getUserId() == id)
            {
                acceptBtn.Hide();
                rejectBtn.Hide();
            }
            else
            {
                acceptBtn.Show();
                rejectBtn.Show();
            }
        }


        private void backBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            if (backClick != null) backClick(this, EventArgs.Empty);
        }

        private void rejectBtn_Click(object sender, EventArgs e)
        {
            reject.execute();
            this.Status = "Rejeitado";
            acceptBtn.Hide();
            rejectBtn.Hide();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            accept.execute();
            this.Status = "Aceito";
            acceptBtn.Hide();
            rejectBtn.Hide();
        }
    }
}
