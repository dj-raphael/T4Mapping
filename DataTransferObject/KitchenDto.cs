using System;
using ConsoleApplicationParceAttribute.Attributes;

namespace DataTransferObject
{
    [Map]
    public class KitchenDto
    {
        public Guid KitchenId { get; set; }
        public string Name { get; set; }
    }
}