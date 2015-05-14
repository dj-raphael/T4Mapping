using System;
using System.Collections.Generic;
using DataObjects.Attributes;

namespace DataObjects
{
    [Map]
    public class News
    {
        public Guid NewsId { get; set; }
        public string Title { get; set; }
        public string Anounce { get; set; }
        public string Text { get; set; }
        [Map(FunctionTo = "(DataObjects.Attributes.StatusEnum) System.Enum.Parse(typeof(DataObjects.Attributes.StatusEnum), itemDto.Status)")]
        public StatusEnum Status { get; set; }
        public NewsCategory Category { get; set; }
        public DateTime Created { get; set; }
        public User Author { get; set; }
        public IEnumerable<NewsToTags> NewsToTags { get; set; }
    }
}