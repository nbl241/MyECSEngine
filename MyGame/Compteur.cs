using MyECSEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public sealed class Compteur : Component
    {
        private int Nbr;
        private TextRenderer TextRenderer;

        protected override void Start()
        {
            TextRenderer = Entity.GetComponent<TextRenderer>();
        }

        public override void Update()
        {
            ++Nbr;
            TextRenderer.ToDisplay = Nbr.ToString();
        }
    }
}
