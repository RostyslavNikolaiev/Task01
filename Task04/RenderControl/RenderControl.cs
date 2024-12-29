using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;

namespace Task04Nikolaiev
{
    public partial class RenderControl : OpenGL
    {
        Layout _l = new Layout();
        DrawFunction _dF = new DrawFunction();
        public double margin { get; set; } = 5.0;
        public int func { get; set; } = 0;
        public double A { get; set; } = 1;
        public double B { get; set; } = 0;
        public double C { get; set; } = 0;
        public double XStart { get; set; } = 0;
        public double YStart { get; set; } = 0;
        public double XEnd { get; set; } = 0;
        public double YEnd { get; set; } = 0;
        public bool DrawLine { get; set; } = false;

        public RenderControl()
        {
            InitializeComponent();
            this.MouseClick += OnMouseClick;
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClearColor(1, 1, 1, 1);
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            if (Width > Height)
                glViewport((Width - Height)/2, 0, Height, Height);
            else
                glViewport(0, (Height - Width)/2, Width, Width);
            gluOrtho2D(-margin, margin, -margin, margin);


            _l.DrawCellsCoordinate(-margin, margin, -margin, margin);
            _l.DrawCoordinates(-margin, margin, -margin, margin);

            if (func == 0)
                _dF.Hyperbola(A, B);

            if (func == 1)
            {
                _dF.Parabola(A, B, C);
                DrawLine = false;
                XStart = 0; YStart = 0; XEnd = 0; YEnd = 0;
            }
            if (DrawLine)
            {
                glColor3d(1, 0, 0);
                glBegin(GL_LINES);
                glVertex2d(XStart, YStart);
                glVertex2d(XEnd, YEnd);
                glEnd();

                DrawIntersectionPoints(A, B, XStart, YStart, XEnd, YEnd);
            }
        }
        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            double viewportWidth, viewportHeight;
            double xOffset = 0, yOffset = 0;

            if (Width > Height)
            {
                viewportWidth = (double)Height;
                viewportHeight = (double)Height;
                xOffset = (Width - Height) / 2.0;
            }
            else
            {
                viewportWidth = (double)Width;
                viewportHeight = (double)Width;
                yOffset = (Height - Width) / 2.0;
            }

            double normalizedX = (e.X - xOffset) / viewportWidth * 2.0 - 1.0;
            double normalizedY = -((e.Y - yOffset) / viewportHeight * 2.0 - 1.0);

            double x = normalizedX * margin;
            double y = normalizedY * margin;

            if (e.Button == MouseButtons.Left)
            {
                XStart = x;
                YStart = y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                XEnd = x;
                YEnd = y;
                DrawLine = true;
            }

            Invalidate();
        }

        private void DrawIntersectionPoints(double A, double B, double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;

            double a = Math.Pow(dx / A, 2) - Math.Pow(dy / B, 2);
            double b = 2 * ((x1 * dx) / (A * A) - (y1 * dy) / (B * B));
            double c = Math.Pow(x1 / A, 2) - Math.Pow(y1 / B, 2) - 1;

            double discriminant = b * b - 4 * a * c;
            if (discriminant < 0)
                return;

            double t1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double t2 = (-b + Math.Sqrt(discriminant)) / (2 * a);

            List<(double x, double y)> intersectionPoints = new List<(double x, double y)>();
            if (0 <= t1 && t1 <= 1)
                intersectionPoints.Add((x1 + t1 * dx, y1 + t1 * dy));
            if (0 <= t2 && t2 <= 1)
                intersectionPoints.Add((x1 + t2 * dx, y1 + t2 * dy));

            glColor3d(0.1, 0.6, 0.1);
            foreach (var point in intersectionPoints)
            {
                glPointSize(8);
                glBegin(GL_POINTS);
                glVertex2d(point.x, point.y);
                glEnd();
            }
        }
    }
}

