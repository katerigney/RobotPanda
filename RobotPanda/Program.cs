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
            Console.WriteLine($"R2D2 is version {R2D2.VersionNumber}.");

            //robot: powering up and down
            R2D2.PowerDown(R2D2.Name);
            R2D2.StartUp(R2D2.Name);


            //animals:eat, sleep, wakeup
            var animals = new List<Animal>();
            animals.Add(kate);
            animals.Add(Allan);
            var animalsDoStuff = new Animal();

            foreach (var animal in animals)
            {
                animalsDoStuff.EatUp(animal.Name);
                animalsDoStuff.Wakeup(animal.Name);
                animalsDoStuff.FallAsleep(animal.Name);

            }

            //beings - interface: greeting
            var greetings = new List<ISayHello>();
            greetings.Add(new Panda());
            greetings.Add(new Robot());
            greetings.Add(new Human());

            foreach (var being in greetings)
            {
                being.SayHello();
            }

            //human adopts pets

            Panda jackie = kate.AdoptPanda("Jackie", kate.Name);
            Robot C3PO = kate.AdoptRobot("C3PO", kate.Name);

            var Pets = new List<Being>();
            Pets.Add(jackie);
            Pets.Add(C3PO);

            foreach (var pet in Pets)
            {
                //Ownersname would not work with being as the list type. Could make Pets class but can't put two inheritances on a class???
                Console.WriteLine($"{pet.Name} is {pet.Ownersname}'s new pet.");
            }

            var mingming = (Panda)kate.AdoptPet(new Panda());
            mingming.EatUp("bambooo");


            //wanted to join this into one call but classes...
            var kateMessage = kate.ToString();
            Console.WriteLine(kateMessage);
            var AllanMessage = Allan.ToString();
            Console.WriteLine(AllanMessage);
            var R2D2Message = R2D2.ToString();
            Console.WriteLine(R2D2Message);
            var JackieMessage = jackie.ToString();
            Console.WriteLine(JackieMessage);
            var C3POMessage = C3PO.ToString();
            Console.WriteLine(C3POMessage);


            Console.ReadLine();
        }
        


    }
}

