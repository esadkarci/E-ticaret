using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailsCommands
{
    public class RemoveOrderDerailCommand
    {
        public int Id { get; set; }

        public RemoveOrderDerailCommand(int id)
        {
            Id = id;
        }
    }
}
