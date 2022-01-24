using System.Windows.Forms;

namespace apoo_2021_t1.src.gui.Factory
{
    class ClienteFactory : FactoryForm
    {
        public Form createForm(int id)
        {
            return new ClienteForm(id);
        }
    }
}
