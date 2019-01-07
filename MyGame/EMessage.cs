using MyECSEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public sealed class EMessage : Entity
    {
        public EMessage()
        {
            Name = "Message";
            Components = new List<Component>
            {
                new Message(),
                new TextRenderer()
            };
        }
    }
}
