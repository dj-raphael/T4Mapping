using System;
using ConsoleApplicationParceAttribute.Attributes;

namespace DataTransferObject
{
    [Map]
    public class OrderFoodDto
    {
        public Guid MenuCategoryId { get; set; }

        public string SalesCategory { get; set; }

        public Guid OrderItemId { get; set; }

        public string Title { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
    }
}
