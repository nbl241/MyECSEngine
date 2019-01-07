using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECSEngine
{
    public sealed class TextRenderer : Component
    {
        public string ToDisplay;
        private GraphicSystem GraphicSystem;

        protected override void Start()
        {
            GraphicSystem = Engine.GetSystem<GraphicSystem>();
        }

        public override void Update()
        {
            if (ToDisplay != null)
                GraphicSystem.Render(this);
        }

        public override void BeforeFrame()
        {
            ToDisplay = null;
        }

        public override string ToString()
        {
            return (ToDisplay);
        }
    }
}
