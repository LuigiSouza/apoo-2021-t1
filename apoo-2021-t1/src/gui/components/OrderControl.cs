using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apoo_2021_t1.src.gui.components
{
    public partial class OrderControl : UserControl
    {
        public event EventHandler expandClick;
        public OrderControl(EventHandler exp)
        {
            InitializeComponent();
            this.expandClick = exp;
        }

        #region Properties

        private string _status;
        private float _price;
        private int _id;
        private int _quantity;

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
        [Category("Custom Props")]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; quantity.Text = value.ToString(); }
        }

        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void expand_Click(object sender, EventArgs e)
        {
            var handler = expandClick;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        private void status_Click(object sender, EventArgs e)
        {

        }
    }
}
