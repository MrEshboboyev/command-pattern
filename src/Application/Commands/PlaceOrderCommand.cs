using Domain.Interfaces;
using Domain.Models;

namespace Application.Commands;

public class PlaceOrderCommand(Order order) : ICommand
{
    private readonly Order _order = order;

    public void Execute()
    {
        _order.Place();
    }

    public void Undo()
    {
        _order.Cancel();
    }
}
