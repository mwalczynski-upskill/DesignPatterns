using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FactoryMethod.Enum;
using FactoryMethod.Obstacle;

namespace FactoryMethod.Factory
{
    public class BalancedObstacleFactory : IObstacleFactory
    {
        private static readonly Dictionary<string, int> NumberOfObstacles = new Dictionary<string, int>()
        {
            {"Human", 0},
            {"Rock", 0},
            {"Tree", 0},
        };

        public ObstacleFactoryType Type => ObstacleFactoryType.Balanced;

        public IObstacle CreateObstacle()
        {
            var type = this.GetObstacleTypeToKeepBalance();

            IObstacle obstacle = null;

            switch (type)
            {
                case "Human":
                    obstacle = new Human();
                    ObstacleAdded("Human");
                    break;
                case "Rock":
                    obstacle = new Rock();
                    ObstacleAdded("Rock");
                    break;
                case "Tree":
                    obstacle = new Tree();
                    ObstacleAdded("Tree");
                    break;
            }

            return obstacle;
        }

        private string GetObstacleTypeToKeepBalance()
        {
            var type = NumberOfObstacles.Aggregate((t1, t2) => t1.Value < t2.Value ? t1 : t2).Key;
            return type;
        }

        private void ObstacleAdded(string obstacleType)
        {
            NumberOfObstacles[obstacleType]++;
        }
    }
}
