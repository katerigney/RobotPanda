using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPanda
{
    class Being 
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Greeting { get; set; }

        protected bool IsAsleep { get; set; } = true;

 
    }
}
