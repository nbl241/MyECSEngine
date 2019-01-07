using MyECSEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    public sealed class Message : Component
    {
        private string Msg = "Yay";
        private TextRenderer TextRenderer;
        private InputSystem InputSystem;

        protected override void Start()
        {
            TextRenderer = Entity.GetComponent<TextRenderer>();
            InputSystem = Engine.GetSystem<InputSystem>();
        }

        public override void Update()
        {
            if (InputSystem.Command.ToLower() == "unity")
            {
                TextRenderer.ToDisplay = Msg;
            }
        }
    }
}
