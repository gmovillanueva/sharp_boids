using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public class Field
    {
        private readonly double width;
        private readonly double height;
        public readonly Boid[] boids;

        public double flockWeight = 1.0;
        public double avoidWeight = 1.0;
        public double alignWeight = 1.0;
        public double boidVision = 100;
        public double boidVisionRepel = 20;

        public Field(double width, double height, int boidCount, int predCount, bool ran)
        {
            this.width = width;
            this.height = height;
            this.boids = new Boid[boidCount];
            randomizeBoids(predCount, ran);
        }

        private void randomizeBoids(int predCount, bool ran)
        {
            Random random = ran ? new Random() : new Random(0);

            for (int i = 0; i < boids.Length; i++)
            {
                boids[i] = new Boid(
                    x: random.NextDouble() * width,
                    y: random.NextDouble() * height,
                    xVel: (random.NextDouble() - 0.5),
                    yVel: (random.NextDouble() - 0.5),
                    tarSpeed: (random.NextDouble() - 0.5));
                if(i< predCount)
                {
                    boids[i].isPred = true;
                    boids[i].targetSpeed += 0.5;
                }
            }
        }

        public void flockBoid(double stepSize = 1.0)
        {
            Parallel.ForEach(boids, boid => 
            {
                boid.boidFlockBoids(boids, boidVision, 0.0005 * flockWeight);
                boid.boidAvoidBoids(boids, boidVisionRepel, 0.005 * flockWeight);
                boid.boidAlignNeighbors(boids, boidVision, 0.03 * alignWeight);
                boid.boidAvoidPreds(boids, boidVision, 0.002);
                boid.boidAvoidWalls(width, height, boidVision, 0.1);
                boid.flockBoid(stepSize);
            });
        }
    }
}
