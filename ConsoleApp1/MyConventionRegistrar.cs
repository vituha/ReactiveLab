using System;
using System.Linq;
using System.Reactive.Linq;

namespace ConsoleApp1
{
    internal class MyConventionRegistrar
    {
        public void Subscribe(IObservable<Type> observable)
        {
            var types =
                from t in observable
                from i in t.GetInterfaces()
                where IsGoodInterface(i)
                select new {i, t};

            types.Subscribe(x => Register(x.i, x.t));
        }

        private bool IsGoodInterface(Type type)
        {
            return true;
        }

        private void Register(Type iface, Type type)
        {
            Console.WriteLine($"Registered {iface.FullName} implemented by {type.FullName}.");
        }
    }
}