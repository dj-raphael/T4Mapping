using System;
using ConsoleApplicationParceAttribute.Attributes;
using Microsoft.Build.Framework;

namespace DataObjects
{
    [Map]
    public class Kitchen
    {
        [Required]
        public Guid KitchenId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}