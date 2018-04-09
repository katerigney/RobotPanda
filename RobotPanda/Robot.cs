using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPanda
{
    class Robot : Being, ISayHello
    {
        public string Name { get; set; }
        public string OwnersName { get; set; }

        public Robot()
        {

            //version number

            //start up

            //shut down
        }

        public void SayHello()
        {
            Console.WriteLine("Greetings!");
        }

    }
}
