using System;
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

            typeDiscoverySubject.OnNext(typeof(string));
        }
    }
}
