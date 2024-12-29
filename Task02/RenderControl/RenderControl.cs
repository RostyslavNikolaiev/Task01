using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using static Task_02.OpenGL;

namespace Task_02
{
    public partial class RenderControl : OpenGL
    {
        public uint DrawMode { get; set; } = GL_FILL;
        public int TilesVertical { get; set; } = 1;
        public int TilesHorizontal { get; set; } = 1;

        Figura _f = new Figura();
        
        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            int ortho = 10;

            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            if (Width > Height)
                glViewport((Width - Height)/2, 0, Height, Height);
            else
                glViewport(0, (Height - Width)/2, Width, Width);
            double max = Math.Max(TilesHorizontal, TilesVertical);
            glOrtho(-ortho, +ortho * max, -ortho, +ortho * max, -1, +1);

            for (int row = 0; row < TilesVertical; row++)
            {
                for (int col = 0; col < TilesHorizontal; col++)
                {
                    double offsetX = col * 5 * 1.4;
                    double offsetY = row * 5 * 1.6;
                    
                    if (col > 0)
                        offsetY += col * 2;

                    _f.PaintTile(DrawMode, offsetX, offsetY);
                }
            }


            //_f.DrawYellowTriangle(5, DrawMode);
            //_f.DrawTile(DrawMode, 0, 0);
            _f.PaintCursor();

            glDisable(GL_LINES);
        }
    }
}

