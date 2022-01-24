using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace apoo_2021_t1.src.gui.components
{
    public partial class ItemControl : UserControl
    {
        public event EventHandler minusClick;
        public event EventHandler addClick;
        public ItemControl(EventHandler min, EventHandler add)
        {
            this.minusClick = min;
            this.addClick = add;
            InitializeComponent();
        }

        #region Properties

        private string _title;
        private float _price;
        private int _quantity;
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
            set { _price = value; price.Text = "R$ " + value.ToString("0.00"); }
        }

        [Category("Custom Props")]
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; quantity.Text = value.ToString(); }
        }

        #endregion

        private void minBtn_Click(object sender, EventArgs e)
        {
            if (minusClick != null) minusClick(this, EventArgs.Empty);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (addClick != null) addClick(this, EventArgs.Empty);
        }
    }
}
