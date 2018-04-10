using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPanda
{
    class Robot : Being, ISayHello
    {
        public int VersionNumber { get; set; }

        public void StartUp(string name)
        {
            IsAsleep = false;
            Console.WriteLine($"{name} powering up.");
        }

        public void PowerDown (string name)
        {
            IsAsleep = true;
            Console.WriteLine($"{name} powering down.");
        }


        public void SayHello()
        {
            Console.WriteLine("Greetings!");
        }

        public override string ToString()
        {
            return $"Greetings! I am {Name} and I'm a robot. My birthday is {Birthday} ";
        }

    }
}
