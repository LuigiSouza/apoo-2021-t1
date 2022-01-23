using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using apoo_2021_t1.src.Models;

namespace apoo_2021_t1.src.Command
{
    class RejectCommand : Command
    {
        Order order;
        public RejectCommand(Order order)
        {
            this.order = order;
        }
        public void execute()
        {
            order.status = "Rejeitado";
            order.finished = false;
        }
    }
}
