using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Nikolaiev_task01.OpenGL;

namespace Nikolaiev_task01 
{
    public partial class RenderControl
    {
        internal class Layout
        {
            private readonly int _x1;
            private readonly int _y1;
            private readonly int _x2;
            private readonly int _y2;
            private readonly float _step;

            public Layout(int x1, int y1, int x2, int y2, float step)
            {
                _x1 = x1;
                _y1 = y1;
                _x2 = x2;
                _y2 = y2;
                _step = step;
            }

            public void DrawAxis()
            {
                glLineWidth(3);
                glColor3d(0, 0, 0);
                glBegin(GL_LINES);

                glVertex2d(_x1, _y1-1);
                glVertex2d(_x2, _y1-1);

                glVertex2d(_x1-1, _y1);
                glVertex2d(_x1-1, _y2);
                PaintArrowY();
                PaintArrowX();

                glEnd();
            }

            public void PaintArrowY()
            {
                glLineWidth(3);
                glColor3d(0, 0, 0);
                glBegin(GL_LINES);

                glVertex2d(_x1-1, _y2);
                glVertex2d(_x1-1, _y2+1);

                glVertex2d(_x1-1.2, _y2);
                glVertex2d(_x1-1, _y2+1);

                glVertex2d(_x1-0.8, _y2);
                glVertex2d(_x1-1, _y2+1);

                glEnd();
            }

            public void PaintArrowX()
            {
                glLineWidth(3);
                glColor3d(0, 0, 0);
                glBegin(GL_LINES);

                glVertex2d(_x2, _y1-1);
                glVertex2d(_x2+1, _y1-1);

                glVertex2d(_x2, _y1-0.8);
                glVertex2d(_x2+1, _y1-1);

                glVertex2d(_x2, _y1-1.2);
                glVertex2d(_x2+1, _y1-1);

                glEnd();
            }
            public void PaintGrid()
            {
                glColor3d(0.5, 0.5, 0.5);
                glLineWidth(1);
                glEnable(GL_LINE_STIPPLE);
                glLineStipple(3, 0xAAAA);

                glBegin(GL_LINES);

                for (float x = _x1; x <= _x2; x += _step)
                {
                    glVertex2f(x, _y1-1);
                    glVertex2f(x, _y2+1);
                }

                for (float y = _y1; y <= _y2; y += _step)
                {
                    glVertex2f(_x1-1, y);
                    glVertex2f(_x2+1, y);
                }

                glEnd();

                glDisable(GL_LINE_STIPPLE);
            }

            public void LoadLayout()
            {
                PaintGrid();
                DrawAxis();
            }
        }
    }
}
