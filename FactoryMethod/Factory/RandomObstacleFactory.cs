using System;
using FactoryMethod.Enum;
using FactoryMethod.Obstacle;

namespace FactoryMethod.Factory
{
    public class RandomObstacleFactory : IObstacleFactory
    {
        private readonly Random _random = new Random();

        public ObstacleFactoryType Type => ObstacleFactoryType.Random;

        public IObstacle CreateObstacle()
        {
            var type = _random.Next(0, 3);

            IObstacle obstacle = null;

            switch (type)
            {
                case 0:
                    obstacle = new Human();
                    break;
                case 1:
                    obstacle = new Rock();
                    break;
                case 2:
                    obstacle = new Tree();
                    break;
            }

            return obstacle;
        }
    }
}
