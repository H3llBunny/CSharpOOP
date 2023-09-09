using CollectionHierarchy.Interfaces;
using CollectionHierarchy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionHierarchy.Controllers
{
    public class Engine
    {
        private IAddColletion<string> addCollection;
        private IAddRemoveCollection<string> addRemoveCollection;
        private IMyList<string> myList;
        private StringBuilder resultingOutput;

        public Engine()
        {
            this.addCollection = new AddCollection<string>();
            this.addRemoveCollection = new AddRemoveCollection<string>();
            this.myList = new MyList<string>();
            this.resultingOutput = new StringBuilder();
        }

        public void Run()
        {
            var input = Console.ReadLine().Split();
            this.FillCollection(ref input, this.addCollection);
            this.FillCollection(ref input, this.addRemoveCollection);
            this.FillCollection(ref input, this.myList);

            var numberOfRemovals = int.Parse(Console.ReadLine());
            this.RemoveOperation(numberOfRemovals, this.addRemoveCollection);
            this.RemoveOperation(numberOfRemovals, this.myList);

            Console.WriteLine(this.resultingOutput.ToString().Trim());
        }

        private void RemoveOperation<T>(int numberOfRemovals, IAddRemoveCollection<T> collection)
        {
            while(numberOfRemovals > 0)
            {
                var removeElement = collection.Remove();
                this.resultingOutput.Append($"{removeElement} ");
                numberOfRemovals--;
            }

            this.resultingOutput.Remove(this.resultingOutput.Length - 1, 1).AppendLine();
        }

        private void FillCollection(ref string[] input, IAddColletion<string> collection)
        {
            foreach (var str in input)
            {
                var index = collection.Add(str);
                this.resultingOutput.Append($"{index} ");
            }

            this.resultingOutput.Remove(this.resultingOutput.Length - 1, 1).AppendLine();
        }
    }
}
