using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04Nikolaiev
{
    public partial class RenderControl
    {
        public class DrawFunction
        {
            const int margins = 1000;
            public void Hyperbola(double a, double b)
            {
                glColor3d(1, 0, 1);
                glBegin(GL_LINE_STRIP);
                for (double t = -margins; t <= margins; t += 0.1)
                {
                    double x = a * Math.Cosh(t);
                    double y = b * Math.Sinh(t);
                    glVertex2d(x, y);
                }
                glEnd();

                glBegin(GL_LINE_STRIP);
                for (double t = -margins; t <= margins; t += 0.1)
                {
                    double x = -a * Math.Cosh(t);
                    double y = -b * Math.Sinh(t);
                    glVertex2d(x, y);
                }
                glEnd();
            }
            public void Parabola(double a, double b, double c)
            {
                glColor3d(1, 0, 1);
                glBegin(GL_LINE_STRIP);
                for (double x = -margins; x <= margins; x += 0.1)
                {
                    double y = a * x * x + b * x + c;
                    glVertex2d(x, y);
                }
                glEnd();
            }
            
        }
    }
}

 