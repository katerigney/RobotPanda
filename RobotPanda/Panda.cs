using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPanda
{
    class Panda : Animal, ISayHello, IPet
    {
        public string OwnersName { get; set; }

        public void SayHello()
        {
            Console.WriteLine("Ni hao!");
        }

        public override string ToString()
        {
            return $"Ni hao! I am {Name} and I'm a panda. My birthday is {Birthday} ";
        }
    }

        
    
}
