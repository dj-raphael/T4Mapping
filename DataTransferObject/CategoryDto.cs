using System;
using System.Collections.Generic;
using DataTransferObject.Attributes;

namespace DataTransferObject
{
    [Map(Name = "NewsCategory")]
    public class CategoryDto
    {
        public Guid NewsCategoryId { get; set; }
        public string Name { get; set; }
        public CategoryDto ParentCategory { get; set; }
        public IEnumerable<CategoryDto> ChildCategories { get; set; }
    }
}