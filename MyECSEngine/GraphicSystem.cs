using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECSEngine
{
    public sealed class GraphicSystem : System
    {
        public Queue<TextRenderer> Renderers = new Queue<TextRenderer>();

        public override void AfterFrame()
        {
            foreach (TextRenderer renderer in Renderers)
            {
                Console.WriteLine(renderer);
            }

            Renderers.Clear();
        }

        public void Render(TextRenderer renderer)
        {
            Renderers.Enqueue(renderer);
        }
    }
}
