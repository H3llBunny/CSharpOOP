﻿using Inferno_Infinity.Attributes;
using Inferno_Infinity.Contracts;
using Inferno_Infinity.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Inferno_Infinity.Core.Commands
{
    public class AuthorCommand : Command
    {
        public AuthorCommand(string[] data) : base(data)
        {
        }

        public override void Execute()
        {
            var type = typeof(Weapon);
            CustomAttribute customAttribute = (CustomAttribute)type.GetCustomAttribute(typeof(CustomAttribute), false);
            string author = customAttribute.Author;

            Console.WriteLine("Author: " + author);
        }
    }
}
