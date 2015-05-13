using System;
using System.Collections.Generic;
using ConsoleApplicationParceAttribute.Attributes;
using DtoClass;

namespace DataTransferObject
{
    [Map]
    public class RestaurantOrderDto
    {
        public Guid OrderId { get; set; }

        public int OrderNumber { get; set; }

        public bool IsClosed { get; set; }

        public int Number { get; set; }

        public DateTime Created { get; set; }

        public DateTime? Closed { get; set; }

        public int LaneId { get; set; }

        public string TableId { get; set; }

        public decimal Amount { get; set; }

        public IEnumerable<TransactionDto> Transactions { get; set; }

    }
}
