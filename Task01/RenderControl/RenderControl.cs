using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace Nikolaiev_task01
{
    public partial class RenderControl : OpenGL // Варіант 16
    {
        private Layout _layout;
        private Figura _figure;

        readonly int X1 = -3;
        readonly int Y1 = 0;
        readonly int X2 = 6;
        readonly int Y2 = 4;
        readonly int padding = 3;

        public RenderControl()
        {
            InitializeComponent();

            _layout = new Layout(X1, Y1, X2, Y2, 1);
            _figure = new Figura(new[] { -3, -2, -1, 0, 0, -2 }, new[] { 2, 4, 4, 3, 1, 0 } );
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);
            //glOrtho(X1, X2, Y1, Y2, -1, +1);

            glOrtho(X1 - padding, X2 + padding, Y1 - padding, Y2 + padding, -1, 1);

            _layout.LoadLayout();
            _figure.Paintall();

            glColor3d(0, 0, 0);
            DrawText("X1", X1, -2);
            DrawText("X2", X2, -2);
            DrawText("Y1", X1-2, Y1);
            DrawText("Y2", X1-2, Y2);

            glEnd();
        }
    }
}

