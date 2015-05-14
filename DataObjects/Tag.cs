using System;
using DataObjects.Attributes;

namespace DataObjects
{
    [Map]
    public class Tag
    {
        public Guid TagId { get; set; }
        public string Name { get; set; }
    }
}