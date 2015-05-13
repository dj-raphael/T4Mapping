using System;
using ConsoleApplicationParceAttribute.Attributes;

namespace DataObjects
{
    [Map]
    public class OrderItem
    {
        public Guid OrderItemId { get; set; }
        public Guid OrderId { get; set; }
        public Guid MenuItemId { get; set; }
        public int Seat { get; set; }
        public int Qty { get; set; }
        public decimal CalculatedPrice { get; set; }
    }
}
