using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        private State state;

        public Context(State initialState)
        {
            state = initialState;
        }

        public void Request()
        {
            state.Handle(this);
        }

        public State State
        {
            get { return state; }
            set
            {
                Console.WriteLine($"Changing state to {value.GetType().Name}");
                state = value;
            }
        }
    }
}
