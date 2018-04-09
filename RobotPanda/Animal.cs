using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPanda
{
    class Animal : Being
    {
        public void Wakeup(string name)
        {
            IsAsleep = false;
            Console.WriteLine($"Good Morning, {name}! Hope you slept well.");
        }

        public void FallAsleep(string name)
        {
            IsAsleep = true;
            Console.WriteLine($"Shhh! Sleep Tight, {name}....");
        }


        public void EatUp(string who)
        {
            Console.WriteLine($"{who} is eating.");
        } 
    }
}
