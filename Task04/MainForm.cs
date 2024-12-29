using System.Drawing;
using System.Windows.Forms;
using static Task04Nikolaiev.OpenGL;


namespace Task04Nikolaiev
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(500, 400);
        }

        private void rbHyp_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.func = 0;
            nudC.Visible = false;
            lblC.Visible = false;
            renderControl1.Invalidate();
        }

        private void rbPar_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.func = 1;
            nudC.Visible = true;
            lblC.Visible = true;
            renderControl1.Invalidate();
        }

        private void nudA_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.A = (double)nudA.Value;
            renderControl1.Invalidate();
        }

        private void nudB_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.B = (double)nudB.Value;
            renderControl1.Invalidate();
        }

        private void nudC_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.C = (double)nudC.Value;
            renderControl1.Invalidate();
        }
    }
}
