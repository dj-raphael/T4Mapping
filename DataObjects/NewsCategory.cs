using System;
using System.Collections.Generic;
using DataObjects.Attributes;

namespace DataObjects
{
    [Map]
    public class NewsCategory
    {
        private readonly ObservableRangeCollection<NewsCategory> _childCategories;

        public NewsCategory()
        {
            _childCategories = new ObservableRangeCollection<NewsCategory>();
        }

        public Guid NewsCategoryId { get; set; }
        public string Name { get; set; }
        public NewsCategory ParentCategory { get; set; }

        public ObservableRangeCollection<NewsCategory> ChildCategories
        {
            get { return _childCategories; }
        }
    }
}