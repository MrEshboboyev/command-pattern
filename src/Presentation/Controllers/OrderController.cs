using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Infrastructure.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrderController : ControllerBase
{
    private readonly OrderService _orderService;
    private readonly Dictionary<int, Order> _orders = [];

    public OrderController()
    {
        _orderService = new OrderService();
    }

    [HttpPost("place")]
    public IActionResult PlaceOrder(int orderId)
    {
        var order = new Order(orderId);
        _orders[orderId] = order;
        _orderService.PlaceOrder(order);
        return Ok($"Order {orderId} Status: {order.Status}");
    }

    [HttpPost("cancel")]
    public IActionResult CancelOrder(int orderId)
    {
        if (_orders.TryGetValue(orderId, out var order))
        {
            _orderService.CancelOrder(order);
            return Ok($"Order {orderId} Status: {order.Status}");
        }
        return NotFound("Order not found.");
    }

    [HttpPost("undo")]
    public IActionResult UndoLastAction()
    {
        _orderService.UndoLastAction();
        return Ok("Last action undone.");
    }
}
