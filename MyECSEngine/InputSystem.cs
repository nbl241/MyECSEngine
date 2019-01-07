using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECSEngine
{
    public sealed class InputSystem : System
    {
        public string Command;

        public override void BeforeFrame()
        {
            Command = Console.ReadLine();
        }
    }
}
