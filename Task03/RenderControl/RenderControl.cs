using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using static Task03Nikolaiev.RenderControl;

namespace Task03Nikolaiev
{
    public partial class RenderControl : OpenGL
    {
        Layout _l = new Layout();
        Paint _dF = new Paint();
        public double points = 1000;
        public bool autoY {  get; set; } = false;
        public double xMin {  get; set; } = -3.0;
        public double xMax { get; set; } = 3.0;
        public double yMin { get; set; } = -3.0;
        public double yMax { get; set; } = 3.0;
        public int func { get; set; } = 0;

        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClearColor(1, 1, 1, 1);
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();
            glViewport(0, 0, Width, Height);

            if (!autoY)
                (yMin, yMax) = _dF.AutoY(xMin, xMax, yMin, yMax, points, func);
            yMax = Math.Min(yMax, 100);
            yMin = Math.Max(yMin, -100);
            gluOrtho2D(xMin, xMax, yMin, yMax);

            _l.DrawGrid(xMin, xMax, yMin, yMax);
            _l.DrawAxis(xMin, xMax, yMin, yMax);
            _dF.DrawFunc(xMin, xMax, yMin, yMax, points, func);
        }
    }
}

