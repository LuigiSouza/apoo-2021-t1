using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apoo_2021_t1.src.Facade;

namespace apoo_2021_t1.src.gui.components
{
    public partial class ItemDetailsControl : UserControl
    {
        public ItemDetailsControl()
        {
            InitializeComponent();
        }

        #region Properties

        private string _title;
        private float _price = 0.0f;
        private int _quantity = 0;
        private int _id;

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; title.Text = value; }
        }

        [Category("Custom Props")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [Category("Custom Props")]
        public float Price
        {
            get { return _price; }
            set
            {
                _price = value;
                totalPrice.Text = "R$ " + (value * _quantity).ToString("0.00");
                price.Text = "R$ " + value.ToString("0.00");
            }
        }

        [Category("Custom Props")]
        public int Quantity
        {
            get { return _quantity; }
            set
            {
                _quantity = value;
                totalPrice.Text = "R$ " + (value * _price).ToString("0.00");
                quantity.Text = value.ToString();
            }
        }

        #endregion


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
