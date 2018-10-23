using AbstractFactory.AbstractFactory;
using AbstractFactory.Enum;

namespace AbstractFactory.Resolver
{
    public interface IInterfaceFactoryResolver
    {
        IInterfaceFactory ResolveFactory(InterfaceFactoryType factoryType);
    }
}