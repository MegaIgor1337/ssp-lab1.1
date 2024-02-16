using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab1._1
{
    public partial class Form1 : Form
    {
        private int defaultHeight;
        private int defaultTop;
        private int defaultRadius;
        public Form1()
        {
            InitializeComponent();
            defaultRadius = 10;
            trackRectangle.Scroll += TrackRectangle_Scroll;
            trackCircle.Scroll += TrackCircle_Scroll;
            trackSine.Scroll += TrackSine_Scroll;
            trackCircle.MouseDown += TrackCircle_MouseDown;
            trackRectangle.MouseDown += TrackRectangle_MouseDown;
            trackSine.MouseDown += TrackSine_MouseDown;

            DrawCircle(trackCircle.Value + defaultRadius);
            DrawSine((trackSine.Maximum - trackSine.Value) * 2);

            defaultHeight = rectangle.Height;
            defaultTop = rectangle.Top;
        }

        private void TrackRectangle_Scroll(object sender, EventArgs e)
        {
            ÑhangeRectangleWidth(trackRectangle.Value);
        }

        private void TrackRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            int newPosition = trackRectangle.Minimum + (int)(((double)e.X / trackRectangle.Width) * (trackRectangle.Maximum - trackRectangle.Minimum));
            trackRectangle.Value = newPosition;
            ÑhangeRectangleWidth(trackRectangle.Value);
        }

        private void ÑhangeRectangleWidth(int trackValue)
        {
            int newHeight = defaultHeight + trackValue * 8;
            int newTop = defaultTop - (newHeight - defaultHeight) / 2;
            rectangle.Height = newHeight;
            rectangle.Top = newTop;
        }

        private void TrackCircle_MouseDown(object sender, MouseEventArgs e)
        {
            int newPosition = trackCircle.Minimum + (int)(((double)e.X / trackCircle.Width) * (trackCircle.Maximum - trackCircle.Minimum));
            trackCircle.Value = newPosition;
            DrawCircle(trackCircle.Value * 5 + defaultRadius);
        }

        private void TrackCircle_Scroll(object sender, EventArgs e)
        {
            DrawCircle(trackCircle.Value * 5 + defaultRadius);
        }

        private void DrawCircle(int radius)
        {
            Bitmap bmp = new Bitmap(circle.Width, circle.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(BackColor);
                int diameter = Math.Min(circle.Width, circle.Height);
                int clampedRadius = Math.Min(radius, diameter / 2);

                int x = (circle.Width - clampedRadius * 2) / 2;
                int y = (circle.Height - clampedRadius * 2) / 2;

                g.DrawEllipse(Pens.Black, x, y, clampedRadius * 2, clampedRadius * 2);
                g.FillEllipse(Brushes.Green, x, y, clampedRadius * 2, clampedRadius * 2);
            }

            circle.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            circle.BackColor = this.BackColor;
        }

        private void TrackSine_Scroll(object sender, EventArgs e)
        {
            DrawSine((trackSine.Maximum - trackSine.Value) * 2);
        }

        private void DrawSine(double amplitude)
        {
            Bitmap bmp = new Bitmap(sine.Width, sine.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(BackColor);
                sine.BackColor = this.BackColor;
                int centerY = bmp.Height / 2;
                int period = bmp.Width;

                Pen pen = Pens.Blue;

                for (int i = 0; i < period; i++)
                {
                    double y = centerY + amplitude * Math.Sin(2 * Math.PI * 5 * i / period);
                    bmp.SetPixel(i, (int)y, Color.Blue);
                }
            }

            sine.Image = bmp;
        }

        private void TrackSine_MouseDown(object sender, MouseEventArgs e)
        {
            int newPosition = trackSine.Minimum + (int)(((double)e.X / trackSine.Width) * (trackSine.Maximum - trackSine.Minimum));
            trackSine.Value = newPosition;
            DrawSine((trackSine.Maximum - trackSine.Value) * 2);
        }
    }

}
