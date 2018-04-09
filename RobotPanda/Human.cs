using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPanda
{
    class Human : Animal, ISayHello
    {

        public string AdoptPet(string type)
        {
            Console.WriteLine($"What do you want to name your {type}?");
            var newName = Console.ReadLine();
            if (type == "panda")
            {
                var newPanda = new Panda();
                newPanda.pet();
            }

            return newPetName;


        }

        public void SayHello()
        {
            Console.WriteLine("Hi!");
        }

        public string Food { get; set; } = "Chips";
    }
}
