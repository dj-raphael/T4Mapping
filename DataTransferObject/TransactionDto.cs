using System;
using System.Collections.Generic;
using ConsoleApplicationParceAttribute.Attributes;

namespace DataTransferObject
{
    [Map]
    public class TransactionDto
    {
        public Guid OrderId { get; set; }
        public Guid Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public int TillId { get; set; }
        public int EmployeeId { get; set; }
        public string CustomerId { get; set; }
        public int? PointsEarned { get; set; }
        public int TotalItemsScanned { get; set; }
        public double RingsPerMin { get; set; }
        public double RingsPerTotal { get; set; }
        public double TimeOn { get; set; }
        public int TransactionNumber { get; set; }
        public short SyncState { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
