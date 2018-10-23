using System.Collections.Generic;
using System.Linq;
using FactoryMethod.Enum;
using FactoryMethod.Factory;

namespace FactoryMethod.Resolver
{
    public class ObstacleFactoryResolver : IObstacleFactoryResolver
    {
        private readonly IEnumerable<IObstacleFactory> _factories;

        public ObstacleFactoryResolver(IEnumerable<IObstacleFactory> factories)
        {
            this._factories = factories;
        }

        public IObstacleFactory ResolveFactory(ObstacleFactoryType factoryType)
        {
            var factory = _factories.Single(f => f.Type == factoryType);
            return factory;
        }
    }
}
