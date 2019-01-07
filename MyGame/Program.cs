using MyECSEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            MyECSEngine.MyECSEngine engine = new MyECSEngine.MyECSEngine();

            engine.Entities = new List<Entity>
            {
                new ECompteur(),
                new EMessage()
            };

            engine.Run();
        }
    }
}
