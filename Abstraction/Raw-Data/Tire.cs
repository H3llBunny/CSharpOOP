﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
{
    internal class Tire
    {
        public Tire(double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age
            , double tire3Pressure, int tire3Age, double tire4Pressure, int tire4Age)
        {
            Tire1Pressure = tire1Pressure;
            Tire1Age = tire1Age;
            Tire2Pressure = tire2Pressure;
            Tire2Age = tire2Age;
            Tire3Pressure = tire3Pressure;
            Tire3Age = tire3Age;
            Tire4Pressure = tire4Pressure;
            Tire4Age = tire4Age;
        }

        public double Tire1Pressure { get; set; }
        public int Tire1Age { get; set; }
        public double Tire2Pressure { get; set; }
        public int Tire2Age { get; set; }
        public double Tire3Pressure { get; set; }
        public int Tire3Age { get; set; }
        public double Tire4Pressure { get; set; }
        public int Tire4Age { get; set; }
    }
}
