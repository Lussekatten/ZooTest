using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTest
{
    internal class Oragutan : Animal
    {
        public Oragutan(string name, int age, string origin, int currVal) : base(name, age, origin, currVal)
        {

        }

        private string _showGoesOn = "Eats the food very quickly asking for more";

        public void PutsOnAShow()
        {
            Console.WriteLine(_showGoesOn);
        }

        public void MakesNoise()
        {
            Console.WriteLine("Starts making orangutang like sounds");
        }
    }
}
