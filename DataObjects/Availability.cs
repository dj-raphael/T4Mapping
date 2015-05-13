using System;
using ConsoleApplicationParceAttribute.Attributes;
using Microsoft.Build.Framework;

namespace DataObjects
{
    [Map]
    public class Availability
    {
        [Required]
        [Map]
        public Guid AvailabilityId { get; set; }
        [Required]
        public string Days { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }

    }
}