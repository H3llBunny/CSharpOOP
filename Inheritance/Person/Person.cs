using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        //public virtual string Name 
        //{
        //    get => name;
        //    set => name = value.Length >= 3 ? value : throw new ArgumentException("Name's length should not be less than 3 symbols!");
        //}

        //public string Name
        //{
        //    get => this.name;
        //    private set
        //    {
        //        if (value.Length < 3)
        //        {
        //            throw new ArgumentException("Name's length should not be less than 3 symbols!");
        //        }
        //        this.name = value;
        //    }
        //}

        public int Age { get; set; }

        //public virtual int Age 
        //{
        //    get => age;
        //    set => age = value >= 0 ? value : throw new ArgumentException("Age must be positive!");
        //}

        //public virtual int Age
        //{
        //    get => this.age;
        //    protected set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentException("Age must be positive!");
        //        }
        //        this.age = value;
        //    }
        //}
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(String.Format("Name: {0}, Age: {1}", this.Name, this.Age));

            return sb.ToString();
        }
    }
}
