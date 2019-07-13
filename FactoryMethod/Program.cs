using System;
using FactoryMethod.Enum;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var obstacleFactoryResolver = ResolverFactory.ResolverFactory.CreateObstacleFactoryResolver();

            var obstacleFactory = obstacleFactoryResolver.ResolveFactory(ObstacleFactoryType.Balanced);

            for (int i = 0; i < 20; i++)
            {
                var obstacle = obstacleFactory.CreateObstacle();
                Console.WriteLine(obstacle.Name);
            }

            Console.ReadKey();
        }
    }
}
