using System;
using ConsoleApplicationParceAttribute.Attributes;

namespace DataObjects
{
    [Map]
    public class StoreTable
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Url { get; set; }
        public string Ip { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public string Logo { get; set; }
        public short TimeShift { get; set; }
        public string TimeZone { get; set; }
        public int OpeningTime { get; set; }
        public bool IsActive { get; set; }
    }
}