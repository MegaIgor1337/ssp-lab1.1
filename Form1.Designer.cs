namespace lab1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackRectangle = new TrackBar();
            trackCircle = new TrackBar();
            trackSine = new TrackBar();
            rectangle = new PictureBox();
            circle = new PictureBox();
            sine = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)trackRectangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackCircle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackSine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rectangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)circle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sine).BeginInit();
            SuspendLayout();
            // 
            // trackRectangle
            // 
            trackRectangle.Anchor = AnchorStyles.None;
            trackRectangle.LargeChange = 1;
            trackRectangle.Location = new Point(158, 237);
            trackRectangle.Name = "trackRectangle";
            trackRectangle.Size = new Size(229, 56);
            trackRectangle.TabIndex = 0;
            trackRectangle.Scroll += TrackRectangle_Scroll;
            // 
            // trackCircle
            // 
            trackCircle.Anchor = AnchorStyles.None;
            trackCircle.LargeChange = 1;
            trackCircle.Location = new Point(568, 237);
            trackCircle.Name = "trackCircle";
            trackCircle.Size = new Size(219, 56);
            trackCircle.TabIndex = 1;
            trackCircle.Scroll += TrackCircle_Scroll;
            // 
            // trackSine
            // 
            trackSine.Anchor = AnchorStyles.None;
            trackSine.Location = new Point(970, 237);
            trackSine.Maximum = 50;
            trackSine.Name = "trackSine";
            trackSine.Size = new Size(217, 56);
            trackSine.TabIndex = 2;
            trackSine.TickFrequency = 5;
            trackSine.Scroll += TrackSine_Scroll;
            // 
            // rectangle
            // 
            rectangle.Anchor = AnchorStyles.None;
            rectangle.BackColor = SystemColors.HotTrack;
            rectangle.Location = new Point(211, 105);
            rectangle.Name = "rectangle";
            rectangle.Size = new Size(125, 62);
            rectangle.TabIndex = 3;
            rectangle.TabStop = false;
            // 
            // circle
            // 
            circle.Anchor = AnchorStyles.None;
            circle.BackColor = Color.DarkGray;
            circle.Location = new Point(568, 105);
            circle.Name = "circle";
            circle.Size = new Size(219, 126);
            circle.TabIndex = 4;
            circle.TabStop = false;
            // 
            // sine
            // 
            sine.Anchor = AnchorStyles.None;
            sine.BackColor = SystemColors.ControlDark;
            sine.Location = new Point(973, 105);
            sine.Name = "sine";
            sine.Size = new Size(214, 120);
            sine.TabIndex = 5;
            sine.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1317, 392);
            Controls.Add(sine);
            Controls.Add(circle);
            Controls.Add(rectangle);
            Controls.Add(trackSine);
            Controls.Add(trackCircle);
            Controls.Add(trackRectangle);
            ForeColor = SystemColors.ControlDark;
            MinimumSize = new Size(1190, 400);
            Name = "Form1";
            Text = "Sliders";
            ((System.ComponentModel.ISupportInitialize)trackRectangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackCircle).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackSine).EndInit();
            ((System.ComponentModel.ISupportInitialize)rectangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)circle).EndInit();
            ((System.ComponentModel.ISupportInitialize)sine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackRectangle;
        private TrackBar trackCircle;
        private TrackBar trackSine;
        private PictureBox rectangle;
        private PictureBox circle;
        private PictureBox sine;
    }
}
