using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apoo_2021_t1.src.gui;

namespace apoo_2021_t1.src.gui
{
    class AdminFactory : FactoryForm
    {
        public Form createForm(int id)
        {
            return new AdminForm(id);
        }
    }
}
