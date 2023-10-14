using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    public class TrafficLight
    {
        private Signal currentSignal;

        public TrafficLight(string signal)
        {
            this.currentSignal = (Signal)Enum.Parse(typeof(Signal), signal);
        }

        public void Update()
        {
            int previous = (int)currentSignal;
            currentSignal = (Signal)(++previous % Enum.GetNames(typeof(Signal)).Length);
        }
    }
}
