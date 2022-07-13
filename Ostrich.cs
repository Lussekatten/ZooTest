using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTest
{
    internal class Ostrich : Animal
    {
        public Ostrich(string name, int age, string origin, int currVal) : base(name, age, origin, currVal)
        {

        }

        public new void PutsOnAShow()
        {
            Console.WriteLine("Spreads out the feathers and runs in circles");
        }

        public override void MakesNoise()
        {
            Console.WriteLine("Starts making ostrich like sounds");
        }
    }
}
