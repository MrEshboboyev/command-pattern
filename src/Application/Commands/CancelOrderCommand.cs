using Domain.Interfaces;
using Domain.Models;

namespace Application.Commands;

public class CancelOrderCommand(Order order) : ICommand
{
    private readonly Order _order = order;

    public void Execute()
    {
        _order.Cancel();
    }

    public void Undo()
    {
        _order.Place();
    }
}
