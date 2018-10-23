using System.Collections.Generic;
using AbstractFactory.AbstractFactory;
using AbstractFactory.Resolver;

namespace AbstractFactory.ResolverFactory
{
    public class ResolverFactory
    {
        public IInterfaceFactoryResolver CreateInterfaceFactoryResolver()
        {
            var obstacleFactories = new List<IInterfaceFactory>()
            {
                new WindowsInterfaceFactory(),
                new LinuxInterfaceFactory(),
                new MacInterfaceFactory(),
            };

            var factoryResolver = new InterfaceFactoryResolver(obstacleFactories);
            return factoryResolver;
        }
    }
}
