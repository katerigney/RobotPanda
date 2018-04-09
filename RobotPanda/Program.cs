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

            // Tried to use contructors here, when I pulled into list below, the properties weren't identified.
            var kate = new Human();
            kate.Name = "Kate";
            kate.Birthday = new DateTime(1990, 1, 15);
            var Allan = new Panda();
            Allan.Name = "Allan";
            Allan.Birthday = new DateTime(2010, 7, 23);
            var R2D2 = new Robot();
            R2D2.Name = "R2D2";
            R2D2.Birthday = new DateTime(2016, 5, 2);

            //beings: name and birthday
            var beings = new List<Being>();
            beings.Add(kate);
            beings.Add(Allan);
            beings.Add(R2D2);

            foreach (var being in beings)
            {
                Console.WriteLine($"{being.Name}'s birthday is {being.Birthday}");
            }

            //robot: version number
            R2D2.VersionNumber = 1;
            Console.WriteLine($"{R2D2.VersionNumber}");

            var animals = new List<Animal>();
            animals.Add(kate);
            animals.Add(Allan);


            var greetings = new List<ISayHello>();
            greetings.Add(new Panda());
            greetings.Add(new Robot());
            greetings.Add(new Human());

            foreach (var being in greetings)
            {
                being.SayHello();
            }


            var newAnimal = new Animal();
            newAnimal.Wakeup(kate.Name);

            Console.WriteLine("What would you like to eat for breakfast?");
            var food = Console.ReadLine();
            newAnimal.EatUp(newPerson.Name, food);

            Console.WriteLine("Let's get you pet! Do you want a (panda) or a (robot)?");
            var newAdoptionType = Console.ReadLine();

            var newPet = newPerson.AdoptPet(newAdoptionType);

            var Pets = new List<Being>();



            







            

            Console.ReadLine();
        }



    }
}

