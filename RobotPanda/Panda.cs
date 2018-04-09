using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPanda
{
    class Panda : Animal, ISayHello, IPet
    {
        public string Food { get; set; } = "Bamboo";


        public void pet(string name)
        {
            Name = name;
            OwnersName =
        }

        public void SayHello()
        {
            Console.WriteLine("Ni hao!");
        }
    }

        
    
}
