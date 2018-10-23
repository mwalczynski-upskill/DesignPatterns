using System.Collections.Generic;
using System.Linq;
using AbstractFactory.AbstractFactory;
using AbstractFactory.Enum;

namespace AbstractFactory.Resolver
{
    public class InterfaceFactoryResolver : IInterfaceFactoryResolver
    {
        private readonly IEnumerable<IInterfaceFactory> _factories;

        public InterfaceFactoryResolver(IEnumerable<IInterfaceFactory> factories)
        {
            this._factories = factories;
        }

        public IInterfaceFactory ResolveFactory(InterfaceFactoryType factoryType)
        {
            var factory = _factories.Single(f => f.Type == factoryType);
            return factory;
        }
    }
}
