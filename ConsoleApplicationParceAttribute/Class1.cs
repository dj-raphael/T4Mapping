using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplicationParceAttribute.Attributes;
using Microsoft.Build.Framework;

namespace ConsoleApplicationParceAttribute
{
    class Class1
    {
        [Required]
        [Map(Name = "test")]
        public Guid AvailabilityId { get; set; }
        [Required]
        public string Days { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
    }
}
