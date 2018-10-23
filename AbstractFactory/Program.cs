using System;
using AbstractFactory.Enum;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var interfaceFactoryResolver = new ResolverFactory.ResolverFactory().CreateInterfaceFactoryResolver();

            var interfaceFactory = interfaceFactoryResolver.ResolveFactory(InterfaceFactoryType.Windows);

            var scrollbar = interfaceFactory.CreateScrollbar();
            Console.WriteLine(scrollbar.Name);
            var checkbox = interfaceFactory.CreateCheckbox();
            Console.WriteLine(checkbox.Name);

            Console.ReadKey();
        }
    }
}
