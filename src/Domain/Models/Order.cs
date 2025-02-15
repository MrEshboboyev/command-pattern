using Domain.Enums;

namespace Domain.Models;

public class Order(int orderId)
{
    public int OrderId { get; set; } = orderId;
    public OrderStatus Status { get; set; } = OrderStatus.Pending;

    public void Place()
    {
        Status = OrderStatus.Placed;
    }

    public void Cancel()
    {
        Status = OrderStatus.Canceled;
    }

    public void Refund()
    {
        Status = OrderStatus.Refunded;
    }
}
