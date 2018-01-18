using System;
using System.Collections.Generic;
using System.Reactive.Subjects;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeDiscoverySubject = new Subject<Type>();

            var registrar = new MyConventionRegistrar();
            registrar.Subscribe(typeDiscoverySubject);

            foreach (Type type in EnumerateTypes())
            {
                typeDiscoverySubject.OnNext(type);
            }
        }

        private static IEnumerable<Type> EnumerateTypes()
        {
            yield return typeof(string);
        }
    }
}
