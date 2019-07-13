using System.Collections.Generic;
using FactoryMethod.Factory;
using FactoryMethod.Resolver;

namespace FactoryMethod.ResolverFactory
{
    public class ResolverFactory
    {
        public static IObstacleFactoryResolver CreateObstacleFactoryResolver()
        {
            var obstacleFactories = new List<IObstacleFactory>()
            {
                new RandomObstacleFactory(),
                new BalancedObstacleFactory()
            };

            var factoryResolver = new ObstacleFactoryResolver(obstacleFactories);
            return factoryResolver;
        }
    }
}
