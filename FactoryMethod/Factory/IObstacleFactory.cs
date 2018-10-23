using FactoryMethod.Enum;
using FactoryMethod.Obstacle;

namespace FactoryMethod.Factory
{
    public interface IObstacleFactory
    {
        ObstacleFactoryType Type { get; }

        IObstacle CreateObstacle();
    }
}
