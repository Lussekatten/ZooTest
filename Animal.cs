using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooTest
{
    internal class Animal
    {
        public Animal(string name, int age, string origin, int currVal)
        {
            Name = name;
            Age = age;
            Origin = origin;
            CurrentValue = currVal;
            _index++;
            Id = _index;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public int CurrentValue { get; set; }
        public string Origin { get; set; }
        public int Id { get; set; }

        private static int _index=0;

        public void PutsOnAShow()
        {
            throw new NotImplementedException();
        }

        public virtual void MakesNoise()
        {
            throw new NotImplementedException();
        }
    }
}
