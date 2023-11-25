using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Originator
    {
        private string state;

        public string State
        {
            get { return state; }
            set
            {
                Console.WriteLine("Setting state to: " + value);
                state = value;
            }
        }

        public Memento CreateMemento()
        {
            Console.WriteLine("Creating memento");
            return new Memento(state);
        }

        public void RestoreMemento(Memento memento)
        {
            Console.WriteLine("Restoring state from memento");
            state = memento.State;
        }
    }
}
