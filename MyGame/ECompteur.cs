using MyECSEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public sealed class ECompteur : Entity
    {
        public ECompteur()
        {
            Name = "Compteur";
            Components = new List<Component>
            {
                new Compteur(),
                new TextRenderer()
            };
        }
    }
}
