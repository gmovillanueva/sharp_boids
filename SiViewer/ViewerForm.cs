using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulator;
using Viewer;

namespace SiViewer
{
    public partial class viewerForm : Form
    {
        public viewerForm()
        {
            InitializeComponent();
            Reset();
        }

        Field field;

        private void Reset()
        {
            field = new Field(
                width: skglControl1.Width,
                height: skglControl1.Height,
                boidCount: (int)numericUpDownBoidCount.Value,
                predCount: (int)numericUpDownPredCount.Value,
                ran: checkBoxRandGen.Checked);

            trackBarVision_Scroll(null, null); 
            trackBarAvoid_Scroll(null, null);
            trackBarAlignment_Scroll(null, null);
            trackBarAttraction_Scroll(null, null);

        }

        private void skglControl1_SizeChanged(object sender, EventArgs e) => Reset();

        private void buttonReset_Click(object sender, EventArgs e) => Reset();

        private void numericUpDownBoidCount_ValueChanged(object sender, EventArgs e) => Reset();

        private void numericUpDownPredCount_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < field.boids.Count(); i++)
            {
                field.boids[i].isPred = (i < numericUpDownPredCount.Value);
            }
        }

        private readonly Stopwatch stopwatch = new Stopwatch();

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopwatch.Restart();
            field.flockBoid(trackBarSpeed.Value * 0.2);
            skglControl1.Invalidate();
            double fps = (double)stopwatch.ElapsedTicks / Stopwatch.Frequency;
            labelFPS.Text = $"{1 / fps:0.00} FPS";
        }

        private void skglControl1_PaintSurface(object sender, SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs e)
        {
            Renderer.Render(
                e.Surface.Canvas,
                field,
                tails: checkboxDrawTails.Checked,
                ranges: checkboxDrawRanges.Checked,
                direction: checkboxDrawDirection.Checked);
        }

        private void trackBarVision_Scroll(object sender, EventArgs e)
        {
            field.boidVision = 10 * trackBarVision.Value;
        }

        private void trackBarAttraction_Scroll(object sender, EventArgs e)
        {
            double frac = 2.0 * trackBarAttraction.Value / trackBarAttraction.Maximum;
            field.flockWeight = Math.Pow(frac, 3);
            
        }

        private void trackBarAvoid_Scroll(object sender, EventArgs e)
        {
            double frac = 2.0 * trackBarAvoid.Value / trackBarAvoid.Maximum;
            field.avoidWeight = Math.Pow(frac, 4);
        }

        private void trackBarAlignment_Scroll(object sender, EventArgs e)
        {
            double frac = 2.0 * trackBarAlignment.Value / trackBarAlignment.Maximum;
            field.alignWeight = Math.Pow(frac, 3);
        }

    }
}
