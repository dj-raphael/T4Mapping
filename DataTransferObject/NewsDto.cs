using System;
using System.Collections.Generic;
using DataTransferObject.Attributes;

namespace DataTransferObject
{
    [Map]
    public class NewsDto
    {
        public Guid? NewsId { get; set; }
        public string Title { get; set; }
        public string Anounce { get; set; }
        public string Text { get; set; }
        public string Status { get; set; }
        public CategoryDto Category { get; set; }
        public DateTime Created { get; set; }
        public string Author { get; set; }
        public IEnumerable<string> Tags { get; set; }
    }
}