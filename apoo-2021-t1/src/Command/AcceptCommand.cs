using apoo_2021_t1.src.Models;

namespace apoo_2021_t1.src.Command
{
    class AcceptCommand : Command
    {
        private Order order;
        public AcceptCommand(Order order)
        {
            this.order = order;
        }
        public void execute()
        {
            order.status = "Aceito";
            order.finished = true;
        }
    }
}
