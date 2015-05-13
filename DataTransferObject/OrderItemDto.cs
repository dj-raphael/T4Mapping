using System;
using System.Collections.Generic;
using ConsoleApplicationParceAttribute.Attributes;

namespace DataTransferObject
{
    [Map]
    public class OrderItemDto
    {
        public Guid OrderId { get; set; }

        public Guid MenuItemId { get; set; }

        public int UPC { get; set; }

        public IEnumerable<Guid> RelatedModifiers { get; set; }

        public IEnumerable<Guid> CommonModifiers { get; set; }
    }
}