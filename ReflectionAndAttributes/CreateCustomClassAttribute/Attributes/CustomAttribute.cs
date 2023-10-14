using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Attributes
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class CustomAttribute : Attribute
    {
        string author = "Pesho";
        int revision = 3;
        string description = "Used for C# OOP Advanced Course - Enumerations and Attributes.";
        string[] reviewers = new string[] { "Pesho", "Svetlio" };

        public string Author => this.author;

        public int Revision => this.revision;

        public string Description => this.description;

        public string[] Reviewers => this.reviewers;
    }
}
