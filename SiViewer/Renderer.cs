using SkiaSharp;

using Simulator;

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Viewer
{
    public static class Renderer
    {
        public static void Render(SKCanvas canvas, Field field, bool tails, bool ranges, bool direction)
        {
            canvas.Clear(SKColor.Parse("#003366"));

            using (var boidPath = new SKPath())
            {
                boidPath.MoveTo(0, 0);
                boidPath.LineTo(-5, -2);
                boidPath.LineTo(0, 8);
                boidPath.LineTo(-5, -2);
                boidPath.LineTo(0, 0);

                foreach (Boid boid in field.boids)
                {
                    SKColor color = boid.isPred ? SKColors.Yellow : SKColors.White;

                    if (tails)                   
                        DrawTailLines(boid, canvas, color);  
                    if (direction)
                        DrawBoidDirection(boid, canvas, boidPath, color);
                    else
                        DrawSimpleBoid(boid, canvas, color);
                }

                if (ranges)
                    DrawRanges(field, canvas);
            }
        }

        private static void DrawTailDots(Boid boid, SKCanvas canvas, SKColor color)
        {
            using (var paint = new SKPaint() { IsAntialias = true })
            {
                for (int i = 0; i < boid.positions.Count; i++)
                {
                    double fract = (i + 1d) / boid.positions.Count;
                    byte alpha = (byte)(255 * fract * 0.5);
                    paint.Color = new SKColor(color.Red, color.Green, color.Blue, alpha);
                    var pos = boid.positions[i];

                    canvas.DrawCircle((float)pos.positionX, (float)pos.positionY, 2, paint);
                }
            }
        }

        private static void DrawTailLines(Boid boid, SKCanvas canvas, SKColor color)
        {
            using (var paint = new SKPaint() { IsAntialias = true, StrokeWidth = 2 })
            {
                for (int i = 0; i < boid.positions.Count; i++)
                {
                    double fract = (i + 1d) / boid.positions.Count;
                    byte alpha = (byte)(255 * fract * 0.5);
                    paint.Color = new SKColor(color.Red, color.Green, color.Blue, alpha);

                    canvas.DrawLine(
                        x0: (float)boid.positions[i - 1].positionX,
                        y0: (float)boid.positions[i - 1].positionY,
                        x1: (float)boid.positions[i].positionX,
                        y1: (float)boid.positions[i].positionY,
                        paint: paint
                        );
                }
            }
        }

        private static void DrawBoidDirection(Boid boid, SKCanvas canvas, SKPath boidPath, SKColor color)
        {
            using (var paint = new SKPaint() { IsAntialias = true, Color = color })
            {
                canvas.Save();
                canvas.Translate((float)boid.pos.positionX, (float)boid.pos.positionY);
                canvas.RotateDegrees((float)boid.vel.getAngle());
                canvas.DrawPath(boidPath, paint);
                canvas.Restore();
            }
        }

        private static void DrawSimpleBoid(Boid boid, SKCanvas canvas, SKColor color, float radius = 4)
        {
            using (var paint = new SKPaint() { IsAntialias = true, Color = color })
            {
                canvas.DrawCircle((float)boid.pos.positionX, (float)boid.pos.positionY, radius, paint);
            }
        }

        private static void DrawRanges(Field field, SKCanvas canvas)
        {
            Boid boid = field.boids[field.boids.Count() - 1];

            float vision = (float)field.boidVision;
            float repel = (float)field.boidVisionRepel;

            using (var paint = new SKPaint() { IsAntialias = true, StrokeWidth = 2, IsStroke = true })
            {
                canvas.Save();
                canvas.Translate((float)boid.pos.positionX, (float)boid.pos.positionY);
                canvas.RotateDegrees((float)boid.vel.getAngle());

                paint.Color = SKColors.Yellow;
                canvas.DrawLine(-5, 0, 5, 0, paint);
                canvas.DrawLine(0, 0, 0, 10, paint);

                paint.Color = SKColors.Magenta;
                canvas.DrawCircle(0, 0, repel, paint);
                canvas.DrawLine(0, repel - 5, 0, repel + 5, paint);

                paint.Color = SKColors.LightGreen;
                canvas.DrawCircle(0, 0, vision, paint);
                canvas.DrawLine(0, vision - 10, 0, vision + 10, paint);

                canvas.Restore();
            }

        }
    }
}