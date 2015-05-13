using System;
using ConsoleApplicationParceAttribute.Attributes;

namespace DataTransferObject
{
    [Map]
    public class AvailabilityDto
    {
        [Map(FunctionFrom = "tratata", FunctionTo = "trata2")]
        public Guid AvailabilityId { get; set; }
        public string Days { get; set; }
        public DateTime? TimeFrom { get; set; }
        public DateTime? TimeTo { get; set; }
        public bool IsChecked { get; set; }
    }
}