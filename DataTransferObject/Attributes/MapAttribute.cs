﻿using System;

namespace DataTransferObject.Attributes
{
    public class MapAttribute : Attribute
    {
        public string Name { get; set; }
        public string FunctionTo { get; set; }
        public string FunctionFrom { get; set; }

    }
}
