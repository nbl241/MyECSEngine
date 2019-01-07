using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyECSEngine
{
    public class MyECSEngine
    {
        public bool Running;

        public List<Entity> Entities = new List<Entity>();
        public List<System> Systems = new List<System>
        {
            new GraphicSystem(),
            new InputSystem()
        };

        public void Run()
        {

            Start();

            //boucle

            while (Running)
            {
                Update();
            }

            Destroyed();
        }

        public void Start()
        {
            Running = true;

            foreach (Entity entity in Entities)
            {
                entity.Start(this);
            }
        }

        public void Destroyed()
        {

        }

        public void Update()
        {
            Systems.ForEach(i => i.BeforeFrame());
            Entities.ForEach(i => i.BeforeFrame());

            Systems.ForEach(i => i.Update());
            Entities.ForEach(i => i.Update());

            Systems.ForEach(i => i.AfterFrame());
            Entities.ForEach(i => i.AfterFrame());
        }

        public Entity GetEntity(string name)
        {
            return (Entities.FirstOrDefault(e => e.Name == name));
        }

        public T GetSystem<T>() where T : System
        {
            T system = Systems.OfType<T>().FirstOrDefault();

            return (system);
        }

    }
}
