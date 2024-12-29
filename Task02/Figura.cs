using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public partial class RenderControl
    {
        public class Figura
        {
            readonly double cursorCenterX = -3;
            readonly double cursorCenterY = 0;

            public void PaintCursor()
            {
                glPointSize(5);
                glColor3d(0, 0, 1);
                glBegin(GL_POINTS);
                glVertex2d(cursorCenterX, cursorCenterY);

                glEnd();
                glDisable(GL_POINTS);
            }

            public void PaintComplexFigure(int sideSize = 5, uint DrawMode = GL_FILL, double offsetX = 0, double offsetY = 0)
            {

                glPointSize(5);
                glPolygonMode(GL_FRONT_AND_BACK, DrawMode);
                glShadeModel(GL_FLAT);

                glBegin(GL_TRIANGLE_FAN);
                glColor3d(1, 1, 0);
                glVertex2d(cursorCenterX + offsetX, cursorCenterY + offsetY);
                glVertex2d((cursorCenterX + sideSize / 2 + 1) + offsetX, (cursorCenterY + sideSize / 2.5) + offsetY);
                glVertex2d((cursorCenterX + sideSize / 2 + 1) + offsetX, (cursorCenterY - sideSize / 2.5) + offsetY);

                glEnd();

                glBegin(GL_POLYGON);
                glColor3d(1, 0, 0);
                glVertex2d(cursorCenterX + sideSize / 2 + 1 + offsetX, cursorCenterY + sideSize / 2.5 + offsetY);   
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY + sideSize / 2.5 + offsetY);       
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY - sideSize / 2.5 + offsetY);       
                glVertex2d(cursorCenterX + sideSize / 2 + 1 + offsetX, cursorCenterY - sideSize / 2.5 + offsetY);   
                glEnd();
                glBegin(GL_POLYGON);
                glColor3d(0, 0.5, 0);
                glVertex2d(cursorCenterX + sideSize / 2 + 1 + offsetX, cursorCenterY - sideSize / 2.5 + offsetY);   
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY - sideSize / 2.5 + offsetY);       
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY - sideSize - 1 + offsetY);        
                glVertex2d(cursorCenterX + sideSize / 2 + 1 + offsetX, cursorCenterY - sideSize - 1 + offsetY);     
                glEnd();

                glBegin(GL_TRIANGLE_FAN);
                glColor3d(1, 1, 0);
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY - sideSize / 2.5 + offsetY); 
                glColor3d(1, 0, 0);
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY - sideSize - 1 + offsetY); 
                glVertex2d(cursorCenterX + 2 * sideSize + offsetX, cursorCenterY - sideSize + 1 + offsetY); 
                glColor3d(1, 1, 0);
                glVertex2d(cursorCenterX + 2 * sideSize + offsetX, cursorCenterY + offsetY); 
                glColor3d(0, 0.5, 0);
                glVertex2d(cursorCenterX + sideSize + 2 + offsetX, cursorCenterY + sideSize / 2.5 + offsetY); 
                glEnd();
            }

            public void PaintTile(uint DrawMode, double offsetX, double offsetY)
            {
                PaintComplexFigure(5, DrawMode, offsetX, offsetY);
            }
        }
    }
}
