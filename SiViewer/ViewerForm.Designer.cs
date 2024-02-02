namespace SiViewer
{
    partial class viewerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.skglControl1 = new SkiaSharp.Views.Desktop.SKGLControl();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelPredCount = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelFPS = new System.Windows.Forms.Label();
            this.trackBarAlignment = new System.Windows.Forms.TrackBar();
            this.trackBarVision = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.checkboxDrawTails = new System.Windows.Forms.CheckBox();
            this.labelBoidCount = new System.Windows.Forms.Label();
            this.numericUpDownPredCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBoidCount = new System.Windows.Forms.NumericUpDown();
            this.labelVision = new System.Windows.Forms.Label();
            this.labelAttract = new System.Windows.Forms.Label();
            this.checkboxDrawRanges = new System.Windows.Forms.CheckBox();
            this.trackBarAttraction = new System.Windows.Forms.TrackBar();
            this.labelAvoid = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkboxDrawDirection = new System.Windows.Forms.CheckBox();
            this.trackBarAvoid = new System.Windows.Forms.TrackBar();
            this.labelAlign = new System.Windows.Forms.Label();
            this.checkBoxRandGen = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlignment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPredCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBoidCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAttraction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAvoid)).BeginInit();
            this.SuspendLayout();
            // 
            // skglControl1
            // 
            this.skglControl1.BackColor = System.Drawing.Color.Black;
            this.skglControl1.Location = new System.Drawing.Point(12, 12);
            this.skglControl1.Name = "skglControl1";
            this.skglControl1.Size = new System.Drawing.Size(987, 485);
            this.skglControl1.TabIndex = 0;
            this.skglControl1.VSync = false;
            this.skglControl1.PaintSurface += new System.EventHandler<SkiaSharp.Views.Desktop.SKPaintGLSurfaceEventArgs>(this.skglControl1_PaintSurface);
            this.skglControl1.SizeChanged += new System.EventHandler(this.skglControl1_SizeChanged);
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(525, 534);
            this.trackBarSpeed.Maximum = 20;
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(100, 45);
            this.trackBarSpeed.TabIndex = 1;
            this.trackBarSpeed.Value = 10;
            // 
            // labelPredCount
            // 
            this.labelPredCount.AutoSize = true;
            this.labelPredCount.Location = new System.Drawing.Point(715, 518);
            this.labelPredCount.Name = "labelPredCount";
            this.labelPredCount.Size = new System.Drawing.Size(60, 13);
            this.labelPredCount.TabIndex = 2;
            this.labelPredCount.Text = "Pred Count";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(17, 546);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset Simulation";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Location = new System.Drawing.Point(916, 542);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(51, 13);
            this.labelFPS.TabIndex = 4;
            this.labelFPS.Text = "0.00 FPS";
            // 
            // trackBarAlignment
            // 
            this.trackBarAlignment.Location = new System.Drawing.Point(419, 534);
            this.trackBarAlignment.Maximum = 20;
            this.trackBarAlignment.Name = "trackBarAlignment";
            this.trackBarAlignment.Size = new System.Drawing.Size(100, 45);
            this.trackBarAlignment.TabIndex = 5;
            this.trackBarAlignment.Value = 10;
            this.trackBarAlignment.Scroll += new System.EventHandler(this.trackBarAlignment_Scroll);
            // 
            // trackBarVision
            // 
            this.trackBarVision.Location = new System.Drawing.Point(98, 534);
            this.trackBarVision.Maximum = 20;
            this.trackBarVision.Name = "trackBarVision";
            this.trackBarVision.Size = new System.Drawing.Size(100, 45);
            this.trackBarVision.TabIndex = 6;
            this.trackBarVision.Value = 10;
            this.trackBarVision.Scroll += new System.EventHandler(this.trackBarVision_Scroll);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(555, 518);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(38, 13);
            this.labelSpeed.TabIndex = 7;
            this.labelSpeed.Text = "Speed";
            // 
            // checkboxDrawTails
            // 
            this.checkboxDrawTails.AutoSize = true;
            this.checkboxDrawTails.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxDrawTails.Location = new System.Drawing.Point(813, 518);
            this.checkboxDrawTails.Name = "checkboxDrawTails";
            this.checkboxDrawTails.Size = new System.Drawing.Size(76, 17);
            this.checkboxDrawTails.TabIndex = 8;
            this.checkboxDrawTails.Text = "Draw Tails";
            this.checkboxDrawTails.UseVisualStyleBackColor = true;
            // 
            // labelBoidCount
            // 
            this.labelBoidCount.AutoSize = true;
            this.labelBoidCount.Location = new System.Drawing.Point(636, 518);
            this.labelBoidCount.Name = "labelBoidCount";
            this.labelBoidCount.Size = new System.Drawing.Size(59, 13);
            this.labelBoidCount.TabIndex = 9;
            this.labelBoidCount.Text = "Boid Count";
            // 
            // numericUpDownPredCount
            // 
            this.numericUpDownPredCount.Location = new System.Drawing.Point(720, 534);
            this.numericUpDownPredCount.Name = "numericUpDownPredCount";
            this.numericUpDownPredCount.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownPredCount.TabIndex = 10;
            this.numericUpDownPredCount.ValueChanged += new System.EventHandler(this.numericUpDownPredCount_ValueChanged);
            // 
            // numericUpDownBoidCount
            // 
            this.numericUpDownBoidCount.Location = new System.Drawing.Point(639, 534);
            this.numericUpDownBoidCount.Name = "numericUpDownBoidCount";
            this.numericUpDownBoidCount.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownBoidCount.TabIndex = 11;
            this.numericUpDownBoidCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBoidCount.ValueChanged += new System.EventHandler(this.numericUpDownBoidCount_ValueChanged);
            // 
            // labelVision
            // 
            this.labelVision.AutoSize = true;
            this.labelVision.Location = new System.Drawing.Point(132, 518);
            this.labelVision.Name = "labelVision";
            this.labelVision.Size = new System.Drawing.Size(35, 13);
            this.labelVision.TabIndex = 12;
            this.labelVision.Text = "Vision";
            // 
            // labelAttract
            // 
            this.labelAttract.AutoSize = true;
            this.labelAttract.Location = new System.Drawing.Point(229, 518);
            this.labelAttract.Name = "labelAttract";
            this.labelAttract.Size = new System.Drawing.Size(52, 13);
            this.labelAttract.TabIndex = 13;
            this.labelAttract.Text = "Attraction";
            // 
            // checkboxDrawRanges
            // 
            this.checkboxDrawRanges.AutoSize = true;
            this.checkboxDrawRanges.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxDrawRanges.Location = new System.Drawing.Point(798, 541);
            this.checkboxDrawRanges.Name = "checkboxDrawRanges";
            this.checkboxDrawRanges.Size = new System.Drawing.Size(91, 17);
            this.checkboxDrawRanges.TabIndex = 14;
            this.checkboxDrawRanges.Text = "Draw Ranges";
            this.checkboxDrawRanges.UseVisualStyleBackColor = true;
            // 
            // trackBarAttraction
            // 
            this.trackBarAttraction.Location = new System.Drawing.Point(207, 534);
            this.trackBarAttraction.Maximum = 20;
            this.trackBarAttraction.Name = "trackBarAttraction";
            this.trackBarAttraction.Size = new System.Drawing.Size(100, 45);
            this.trackBarAttraction.TabIndex = 15;
            this.trackBarAttraction.Value = 10;
            this.trackBarAttraction.Scroll += new System.EventHandler(this.trackBarAttraction_Scroll);
            // 
            // labelAvoid
            // 
            this.labelAvoid.AutoSize = true;
            this.labelAvoid.Location = new System.Drawing.Point(346, 518);
            this.labelAvoid.Name = "labelAvoid";
            this.labelAvoid.Size = new System.Drawing.Size(34, 13);
            this.labelAvoid.TabIndex = 16;
            this.labelAvoid.Text = "Avoid";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkboxDrawDirection
            // 
            this.checkboxDrawDirection.AutoSize = true;
            this.checkboxDrawDirection.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxDrawDirection.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkboxDrawDirection.Location = new System.Drawing.Point(895, 517);
            this.checkboxDrawDirection.Name = "checkboxDrawDirection";
            this.checkboxDrawDirection.Size = new System.Drawing.Size(96, 17);
            this.checkboxDrawDirection.TabIndex = 17;
            this.checkboxDrawDirection.Text = "Draw Direction";
            this.checkboxDrawDirection.UseVisualStyleBackColor = true;
            // 
            // trackBarAvoid
            // 
            this.trackBarAvoid.Location = new System.Drawing.Point(313, 534);
            this.trackBarAvoid.Maximum = 20;
            this.trackBarAvoid.Name = "trackBarAvoid";
            this.trackBarAvoid.Size = new System.Drawing.Size(100, 45);
            this.trackBarAvoid.TabIndex = 18;
            this.trackBarAvoid.Value = 10;
            this.trackBarAvoid.Scroll += new System.EventHandler(this.trackBarAvoid_Scroll);
            // 
            // labelAlign
            // 
            this.labelAlign.AutoSize = true;
            this.labelAlign.Location = new System.Drawing.Point(443, 518);
            this.labelAlign.Name = "labelAlign";
            this.labelAlign.Size = new System.Drawing.Size(53, 13);
            this.labelAlign.TabIndex = 19;
            this.labelAlign.Text = "Alignment";
            // 
            // checkBoxRandGen
            // 
            this.checkBoxRandGen.AutoSize = true;
            this.checkBoxRandGen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxRandGen.Location = new System.Drawing.Point(17, 523);
            this.checkBoxRandGen.Name = "checkBoxRandGen";
            this.checkBoxRandGen.Size = new System.Drawing.Size(92, 17);
            this.checkBoxRandGen.TabIndex = 20;
            this.checkBoxRandGen.Text = "Random Gen.";
            this.checkBoxRandGen.UseVisualStyleBackColor = true;
            // 
            // viewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 591);
            this.Controls.Add(this.checkboxDrawRanges);
            this.Controls.Add(this.checkBoxRandGen);
            this.Controls.Add(this.checkboxDrawTails);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.checkboxDrawDirection);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.numericUpDownBoidCount);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.labelBoidCount);
            this.Controls.Add(this.labelPredCount);
            this.Controls.Add(this.trackBarVision);
            this.Controls.Add(this.numericUpDownPredCount);
            this.Controls.Add(this.labelVision);
            this.Controls.Add(this.trackBarAvoid);
            this.Controls.Add(this.labelAlign);
            this.Controls.Add(this.labelAvoid);
            this.Controls.Add(this.trackBarAlignment);
            this.Controls.Add(this.trackBarAttraction);
            this.Controls.Add(this.labelFPS);
            this.Controls.Add(this.labelAttract);
            this.Controls.Add(this.skglControl1);
            this.Name = "viewerForm";
            this.Text = "Boids Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAlignment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPredCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBoidCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAttraction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAvoid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkiaSharp.Views.Desktop.SKGLControl skglControl1;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelPredCount;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.TrackBar trackBarAlignment;
        private System.Windows.Forms.TrackBar trackBarVision;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.CheckBox checkboxDrawTails;
        private System.Windows.Forms.Label labelBoidCount;
        private System.Windows.Forms.NumericUpDown numericUpDownPredCount;
        private System.Windows.Forms.NumericUpDown numericUpDownBoidCount;
        private System.Windows.Forms.Label labelVision;
        private System.Windows.Forms.Label labelAttract;
        private System.Windows.Forms.CheckBox checkboxDrawRanges;
        private System.Windows.Forms.TrackBar trackBarAttraction;
        private System.Windows.Forms.Label labelAvoid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkboxDrawDirection;
        private System.Windows.Forms.TrackBar trackBarAvoid;
        private System.Windows.Forms.Label labelAlign;
        private System.Windows.Forms.CheckBox checkBoxRandGen;
    }
}

