using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECSEngine
{
    public abstract class ABehaviour
    {
        protected MyECSEngine Engine;

        protected virtual void Start()
        {
            Console.WriteLine(GetType().Name);
        }

        public virtual void Start(MyECSEngine engine)
        {
            Engine = engine;
            Start();
        }

        public virtual void Destroyed()
        {

        }

        public virtual void BeforeFrame()
        {

        }

        public virtual void Update()
        {

        }

        public virtual void AfterFrame()
        {

        }
    }
}
