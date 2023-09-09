﻿using CollectionHierarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Models
{
    public class AddCollection<T> : IAddColletion<T>
    {
        public AddCollection()
        {
            this.Data = new List<T>();
        }
        public List<T> Data { get; set; }

        public virtual int Add(T element)
        {
            this.Data.Add(element);
            return this.Data.Count - 1;
        }
    }
}
