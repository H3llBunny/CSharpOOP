﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {
        }

        //public override int Age
        //{
        //    get => base.Age;
        //    set => Age = value <= 15 ? value : throw new ArgumentException("Child's age must be less than 15!");
        //}

        //public override int Age
        //{
        //    get => base.Age;
        //    protected set
        //    {
        //        if (value >= 15)
        //        {
        //            throw new ArgumentException("Child's age must be less than 15!");
        //        }
        //        base.Age = value;
        //    }
        //}
    }
}
