using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ConcreteObserver : IObserver
    {
        private string name;
        private ConcreteSubject subject;

        public ConcreteObserver(string name, ConcreteSubject subject)
        {
            this.name = name;
            this.subject = subject;
            subject.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine($"Observer {name} received an update. New state: {subject.State}");
        }
    }
}
