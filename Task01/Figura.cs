using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikolaiev_task01
{
    public partial class RenderControl
    {
        internal class Figura
        {
            
            private readonly int[] _cordX;
            private readonly int[] __cordY;

            public Figura(int[] coordinatesX, int[] coordinatesY)
            {
                _cordX = coordinatesX;
                __cordY = coordinatesY;
            }

            public void Paint(uint type, int difference = 0, bool complex = false)
            {
                glLineWidth(5);
                glPointSize(10);
                glColor3d(0, 0, 0);
                glBegin(type);
                if (type == GL_LINES)
                {
                    for (int i = 0; i < _cordX.Length; i++)
                    {
                        glVertex2d(_cordX[i]+difference, __cordY[i]);
                        glVertex2d(_cordX[(i + 1) % _cordX.Length]+difference, __cordY[(i + 1) % __cordY.Length]);
                    }
                }
                else
                {
                    for (int i = 0; i < _cordX.Length; i++)
                    {
                        glVertex2d(_cordX[i]+difference, __cordY[i]);
                    }
                }
                glEnd();

                glDisable(type);
            }


            public void Paintall()
            {
               Paint(GL_LINES);
               Paint(GL_POINTS, 5);
            }
        }
    }
}
