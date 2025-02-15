using Application.Commands;
using Application.Invoker;
using Domain.Models;
using Infrastructure.Commands;

namespace Infrastructure.Services;

public class OrderService
{
    private readonly OrderInvoker _invoker = new();

    public void PlaceOrder(Order order)
    {
        _invoker.ExecuteCommand(new PlaceOrderCommand(order));
    }

    public void CancelOrder(Order order)
    {
        _invoker.ExecuteCommand(new CancelOrderCommand(order));
    }

    public void RefundOrder(Order order)
    {
        _invoker.ExecuteCommand(new RefundOrderCommand(order));
    }

    public void UndoLastAction()
    {
        _invoker.UndoLastCommand();
    }
}
