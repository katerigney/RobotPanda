using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPanda
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, Human!");
            Console.WriteLine("What is your name?");

            var newPerson = new Human();
            newPerson.Name = Console.ReadLine();

            var IsRunning = true;
            while (IsRunning) {

                var newAnimal = new Animal();
                newAnimal.Wakeup(newPerson.Name);

                Console.WriteLine("What would you like to eat for breakfast?");
                var food = Console.ReadLine();
                newAnimal.EatUp(newPerson.Name, food);

                Console.WriteLine("Let's get you pet! Do you want a (panda) or a (robot)?");
                var newAdoptionType = Console.ReadLine();

                var newPet = newPerson.AdoptPet(newAdoptionType);

                var Pets = new List<Being>();



                 var newRobot = new Robot();

                var newPanda = new Panda();








                var greetings = new List<ISayHello>();
                greetings.Add(new Panda());
                greetings.Add(new Robot());
                greetings.Add(new Human());

                foreach (var being in greetings)
                {
                    being.SayHello();
                }
                 }


        }
    }
}
