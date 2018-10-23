using FactoryMethod.Enum;
using FactoryMethod.Factory;

namespace FactoryMethod.Resolver
{
    public interface IObstacleFactoryResolver
    {
        IObstacleFactory ResolveFactory(ObstacleFactoryType factoryType);
    }
}
