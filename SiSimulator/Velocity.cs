using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public class Velocity
    {
        public double velocityX;
        public double velocityY;

        public Velocity(double x, double y)
        {
            velocityX = x;
            velocityY = y;
        }

        public double getAngle()
        {
            if (velocityX == 0 && velocityY == 0)
            {
                return 0;
            }

            double angle = Math.Atan(velocityY / velocityX) * 180 / Math.PI - 90;

            if (velocityX < 0)
            {
                angle += 180;
            }

            return angle;
        }

        public void setSpeed(double speed, bool abs = false)
        {

            if (velocityX == 0 && velocityY != 0)
            {
                return;
            }

            var curSpeed = Math.Sqrt(velocityX * velocityX + velocityY * velocityY);

            double targetVelX = (velocityX / curSpeed) * speed;
            double targetVelY = (velocityY / curSpeed) * speed;

            if (abs)
            {
                velocityX = targetVelX;
                velocityY = targetVelY;
            }
            else
            {
                velocityX += (targetVelX - velocityX) * 0.1;
                velocityY += (targetVelY - velocityY) * 0.1;
            }
        }
    }
}
