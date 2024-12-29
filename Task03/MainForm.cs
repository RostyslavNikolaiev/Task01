using System.Drawing;
using System.Windows.Forms;
using static Task03Nikolaiev.OpenGL;


namespace Task03Nikolaiev
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(500, 450);
            renderControl1.xMin = (double)nUDXmin.Value;
            renderControl1.xMax = (double)nUDXmax.Value;
            renderControl1.yMin = (double)nUDYmin.Value;
            renderControl1.yMax = (double)nUDYmax.Value;
            renderControl1.autoY = false;
        }

        private void nUDXmin_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.xMin = (double)nUDXmin.Value;
            renderControl1.Invalidate();
        }

        private void nUDXmax_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.xMax = (double)nUDXmax.Value;
            renderControl1.Invalidate();
        }

        private void nUDYmin_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.yMin = (double)nUDYmin.Value;
            renderControl1.Invalidate();
        }

        private void nUDYmax_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.yMax = (double)nUDYmax.Value;
            renderControl1.Invalidate();
        }

        private void rbF1X_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.func = 0;
            renderControl1.Invalidate();
        }

        private void rbF2X_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.func = 1;
            renderControl1.Invalidate();
        }

        private void nUDPoints_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.points = (double)nUDPoints.Value;
            renderControl1.Invalidate();
        }

        private void btnShowY_Click(object sender, System.EventArgs e)
        {
            if (!renderControl1.autoY)
            {
                gbY.Visible = true;
                renderControl1.yMin = (double)nUDYmin.Value;
                renderControl1.yMax = (double)nUDYmax.Value;
            }
            else
            {
                gbY.Visible = false;
                renderControl1.yMin = -3.0;
                renderControl1.yMax = 3.0;
            }
            renderControl1.autoY = !renderControl1.autoY;
            renderControl1.Invalidate();
        }
    }
}
