using System;
using DataObjects.Attributes;

namespace DataObjects
{
    [Map]
    public class NewsToTags
    {
        public Guid NewsId { get; set; }
        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}