using System;
using System.Collections.Generic;
using DataObjects.Attributes;

namespace DataObjects
{
    [Map]
    public class NewsCategory
    {
        public Guid NewsCategoryId { get; set; }
        public string Name { get; set; }
        public NewsCategory ParentCategory { get; set; }
        public IEnumerable<NewsCategory> ChildCategories { get; set; }
    }
}