using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace OOP_step_97_ProcessAppDomain_ObjectContextApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SportCar sportCar = new SportCar();
            Console.WriteLine();

            SportCar sportCar1 = new SportCar();
            Console.WriteLine();

            SportCarTS sportCarTS = new SportCarTS();
            Console.WriteLine();

            Console.ReadLine();
        }
    }

    class SportCar
    {
        // SportsCar has no special contextual
        // needs and will be loaded into the
        // default context of the app domain.
        public SportCar()
        {
            Context ctx = Thread.CurrentContext;
            Console.WriteLine($"{this.ToString()} object in context {ctx.ContextID}");
            foreach (IContextProperty ctxProp in ctx.ContextProperties)
            {
                Console.WriteLine($"->> Context Prop: {ctxProp.Name}");
            }
        }        
    }

    // SportsCarTS demands to be loaded in
    // a synchronization context.
    [Synchronization]
    class SportCarTS : ContextBoundObject
    {
        public SportCarTS()
        {
            Context ctx = Thread.CurrentContext;
            Console.WriteLine($"{this.ToString()} object in context {ctx.ContextID}");
            foreach (IContextProperty ctxProp in ctx.ContextProperties)
            {
                Console.WriteLine($"->> Ctx Prop: {ctxProp.Name}");
            }
        }
    }
}
