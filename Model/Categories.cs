﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    internal class Categories
    {
        public int? Id { get; set;}
        public string Name { get; set;}
        public string Description { get; set;}

        public Categories(int? id, string name, string description) 
        { 
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
