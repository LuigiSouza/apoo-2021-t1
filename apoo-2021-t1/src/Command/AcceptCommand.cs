using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apoo_2021_t1.src.Models;

namespace apoo_2021_t1.src.Command
{
    class AcceptCommand : Command
    {
        Order order;
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
