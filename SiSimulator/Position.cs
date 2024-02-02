using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public struct Position
    {
        public double positionX;
        public double positionY;

        public Position(double x, double y)
        {
            positionX = x;
            positionY = y;
        }

        public void positionShift(Position pos)
        {
            positionX += pos.positionX;
            positionY += pos.positionY;
        }

        public void positionMove(Velocity vel, double stepSize)
        {
            positionX += vel.velocityX * stepSize;
            positionY += vel.velocityY * stepSize;
        }

        public (double x, double y) positionDelta(Position otherPos)
        {
            return (otherPos.positionX - positionX, otherPos.positionY - positionY);
        }

        public double positionDistance(Position otherPos)
        {
            (double deltaX, double deltaY) = positionDelta(otherPos);
            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }
    }
}
