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
            DrawSine(trackSine.Value);

            defaultHeight = rectangle.Height;
            defaultTop = rectangle.Top;
        }

        private void TrackRectangle_Scroll(object sender, EventArgs e)
        {
            changeRectangleWidth(trackRectangle.Value);
        }

        private void TrackRectangle_MouseDown(object sender, MouseEventArgs e)
        {
            int newPosition = trackRectangle.Minimum + (int)(((double)e.X / trackRectangle.Width) * (trackRectangle.Maximum - trackRectangle.Minimum));
            trackRectangle.Value = newPosition;
            changeRectangleWidth(trackRectangle.Value);
        }

        private void changeRectangleWidth(int trackValue)
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


        private void TrackSine_Scroll(object sender, EventArgs e)
        {
            DrawSine(trackSine.Value);
        }


        private void DrawSine(int value)
        {



            Bitmap bmp = new Bitmap(sine.Width, sine.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                int sinPeriod = (value + 1) * 7;
                g.Clear(BackColor);
                Pen greenPen = new Pen(Brushes.SteelBlue, 2);
                double amplitude = (value + 1) * 2.5;
                int xOffset = sine.Width / 2;

                int width = sine.Width;
                int height = sine.Height;

                Point[] points = new Point[sine.Width];
                for (int i = 0; i < width; i++)
                {
                    double angle = (i - xOffset) * 2 * Math.PI / sinPeriod;
                    int x = i;
                    int y = (int)(amplitude * Math.Sin(angle));

                    points[x] = new Point(x, sine.Height / 2 - y);
                }

                g.DrawLines(Pens.Red, points);
            }

            sine.Image = bmp;
        }



        private void TrackSine_MouseDown(object sender, MouseEventArgs e)
        {
            int newPosition = trackSine.Minimum + (int)(((double)e.X / trackSine.Width) * (trackSine.Maximum - trackSine.Minimum));
            trackSine.Value = newPosition;
            DrawSine(trackSine.Value);
        }


    }

}