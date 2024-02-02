using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public class Boid
    {
        public Position pos;
        public Velocity vel;
        public double targetSpeed = 1.0;
        public bool isPred;

        private readonly int posHistory = 20;
        public List<Position> positions = new List<Position>();

        public Boid(double x, double y, double xVel, double yVel, double tarSpeed)
        {
            pos = new Position(x, y);
            vel = new Velocity(xVel, yVel);
            targetSpeed = tarSpeed;
        }

        public void boidFlockBoids(Boid[] boids, double vision, double weight)
        {
            if (isPred)
            {
                vision *= 2;
            }
            
            int neighborCount = 0;
            double meanPosX = 0;
            double meanPosY = 0;

            foreach (Boid boid in boids)
            {
                if (boid.pos.positionX < vision)
                {
                    meanPosX += boid.pos.positionX;
                    meanPosY += boid.pos.positionY;
                    neighborCount += 1;
                }
            }

            meanPosX /= neighborCount;
            meanPosY /= neighborCount;

            vel.velocityX += (meanPosX - pos.positionX) * weight;
            vel.velocityY += (meanPosY - pos.positionY) * weight;
        }

        public void boidAvoidBoids(Boid[] boids, double vision, double weight)
        {
            foreach (Boid boid in boids)
            {
                if (boid.isPred)
                {
                    double hitbox = vision - boid.pos.positionDistance(pos);
                    if(hitbox > 0)
                    {
                        vel.velocityX -= (boid.pos.positionX - pos.positionX) * weight * hitbox;
                        vel.velocityY -= (boid.pos.positionY - pos.positionY) * weight * hitbox;
                    }
                }
            }
        }

        public void boidAlignNeighbors(Boid[] boids, double vision, double weight)
        {
            int neighborCount = 0;
            double meanVelX = 0;
            double meanVelY = 0;

            foreach(Boid boid in boids)
            {
                if(boid.pos.positionX < vision)
                {
                    meanVelX += boid.vel.velocityX;
                    meanVelY += boid.vel.velocityY;
                    neighborCount += 1; 
                }
            }

            meanVelX /= neighborCount;
            meanVelY /= neighborCount;

            vel.velocityX -= (pos.positionX - meanVelX) * weight;
            vel.velocityY -= (pos.positionY - meanVelY) * weight;
        }

        public void boidAvoidPreds(Boid[] boids, double vision, double weight)
        {
            for(int i = 0; i<boids.Length; i++)
            {
                Boid boid = boids[i];
                if(boid.isPred && boid.pos.positionDistance(pos)  < vision)
                {
                    if(boid.pos.positionDistance(pos) < vision) {
                        vel.velocityX -= (boid.pos.positionX - pos.positionX) * weight;
                        vel.velocityY -= (boid.pos.positionY - pos.positionY) * weight;
                    }
                }
            }
        }

        public void boidAvoidWalls(double width, double height, double padding, double turn)
        {
            if (pos.positionX < padding) vel.velocityX += turn;
            if (pos.positionY < padding) vel.velocityY += turn;
            if (pos.positionX > width - padding) vel.velocityX -= turn;
            if (pos.positionY > width - padding) vel.velocityY -= turn;
        }

        public void flockBoid(double stepSize)
        {
            vel.setSpeed(targetSpeed);
            pos.positionMove(vel, stepSize);

            positions.Add(pos);
            while (positions.Count > posHistory)
            {
                positions.RemoveAt(0);
            }
        }
    }
}
