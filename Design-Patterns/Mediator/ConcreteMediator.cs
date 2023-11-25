using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class ConcreteMediator : IMediator
    {
        private Colleague colleagueA;
        private Colleague colleagueB;

        public Colleague ColleagueA
        {
            set { colleagueA = value; }
        }

        public Colleague ColleagueB
        {
            set { colleagueB = value; }
        }

        public void Send(string message, Colleague colleague)
        {
            if (colleague == colleagueA)
            {
                colleagueB.Receive(message);
            }
            else if (colleague == colleagueB)
            {
                colleagueA.Receive(message);
            }
        }
    }
}
