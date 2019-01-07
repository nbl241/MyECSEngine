using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECSEngine
{
    public abstract class Entity : ABehaviour
    {
        public string Name;

        protected List<Component> Components;

        public override void Start(MyECSEngine engine)
        {
            base.Start(engine);

            foreach (Component component in Components)
            {
                component.Start(engine, this);
            }
        }

        public override void Update()
        {
            foreach (Component component in Components)
            {
                component.Update();
            }
        }

        public override void AfterFrame()
        {
            foreach (Component component in Components)
            {
                component.AfterFrame();
            }
        }

        public override void BeforeFrame()
        {
            foreach (Component component in Components)
            {
                component.BeforeFrame();
            }
        }

        //public T GetComponent<T>() where T : Component
        //{
        //    T component = (T) Components.FirstOrDefault(i => i.GetType() == typeof(T));

        //    return (component);
        //}

        public T GetComponent<T>() where T : Component
        {
            T component = Components.OfType<T>().FirstOrDefault();

            return (component);
        }
    }
}
