using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailsCommands;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MultiShop.Order.Application.Interfaces.IRepository;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers
{
    public class RemoveOrderDetailCommandHandler
    {
        private readonly IRepository<OrderDetail> _repository;
        public RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveOrderDerailCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
