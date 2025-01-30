using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoRecognitionSystem
{
    public class Winner
    {

        public int Neuron { get; set; }

        public double Value { get; set; }

        public Winner(int neuron, double value)
        {

            this.Neuron = neuron;
            this.Value = value;

        }


    }
}
