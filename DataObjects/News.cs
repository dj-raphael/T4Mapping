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
        [Map(FunctionFrom = "itemDto.Status = item.Status.ToString()", FunctionTo = "item.Status = (DataObjects.Attributes.StatusEnum) System.Enum.Parse(typeof(DataObjects.Attributes.StatusEnum), itemDto.Status)")]
        public StatusEnum Status { get; set; }
        public NewsCategory Category { get; set; }
        public DateTime Created { get; set; }
        [Map(FunctionFrom = "itemDto.Author = item.Author.Login")]
        public User Author { get; set; }
        [Map(Name = "Tags", FunctionFrom = "itemDto.Tags = item.NewsToTags.Select(p => p.Tag.Name)")]
        public IEnumerable<NewsToTags> NewsToTags { get; set; }
    }
}