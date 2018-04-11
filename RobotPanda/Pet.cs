using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotPanda
{
    interface IPet
    {
       // all pets have ownersName
       string OwnersName { get; set; }
    }
}
