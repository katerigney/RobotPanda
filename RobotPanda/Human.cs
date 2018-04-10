using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPanda
{
    class Human : Animal, ISayHello
    {

        public Panda AdoptPanda(string name, string ownersName)
        {
            var newPanda = new Panda();
            newPanda.Name = name;
            newPanda.Ownersname = ownersName;
            newPanda.Birthday = DateTime.Today;
            return newPanda;

        }

        public Robot AdoptRobot(string name, string ownersName)
        {
            var newRobot = new Robot();
            newRobot.Name = name;
            newRobot.Ownersname = ownersName;
            newRobot.Birthday = DateTime.Today;
            return newRobot;

        }

        public void SayHello()
        {
            Console.WriteLine("Hi!");
        }

        public override string ToString()
        {
            return $"Hi! I am {Name} and I'm a person. My birthday is {Birthday}.";
        }

    }
}
