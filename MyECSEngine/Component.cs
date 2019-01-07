using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECSEngine
{
    public abstract class Component : ABehaviour
    {
        protected Entity Entity;

        public void Start(MyECSEngine engine, Entity entity)
        {
            Entity = entity;
            base.Start(engine);
        }
    }
}
