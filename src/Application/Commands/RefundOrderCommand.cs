using Domain.Interfaces;
using Domain.Models;

namespace Infrastructure.Commands;

public class RefundOrderCommand(Order order) : ICommand
{
    private readonly Order _order = order;

    public void Execute()
    {
        _order.Refund();
    }

    public void Undo()
    {
        _order.Place();
    }
}
