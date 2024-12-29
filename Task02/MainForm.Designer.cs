
namespace Task_02
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            rbPointMode = new System.Windows.Forms.RadioButton();
            rbLineMode = new System.Windows.Forms.RadioButton();
            rbFillMode = new System.Windows.Forms.RadioButton();
            gbDrawMode = new System.Windows.Forms.GroupBox();
            timer1 = new System.Windows.Forms.Timer(components);
            nUDVertical = new System.Windows.Forms.NumericUpDown();
            nUDHorizontal = new System.Windows.Forms.NumericUpDown();
            lblVertical = new System.Windows.Forms.Label();
            lblHorizontal = new System.Windows.Forms.Label();
            gbTiles = new System.Windows.Forms.GroupBox();
            gbDrawMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDVertical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDHorizontal).BeginInit();
            gbTiles.SuspendLayout();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.DrawMode = 6913U;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(350, 350);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            // 
            // rbPointMode
            // 
            rbPointMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbPointMode.AutoSize = true;
            rbPointMode.Location = new System.Drawing.Point(6, 72);
            rbPointMode.Name = "rbPointMode";
            rbPointMode.Size = new System.Drawing.Size(84, 19);
            rbPointMode.TabIndex = 2;
            rbPointMode.Text = "GL_POINTS";
            rbPointMode.UseVisualStyleBackColor = true;
            rbPointMode.CheckedChanged += rbPointMode_CheckedChanged;
            // 
            // rbLineMode
            // 
            rbLineMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbLineMode.AutoSize = true;
            rbLineMode.Location = new System.Drawing.Point(6, 47);
            rbLineMode.Name = "rbLineMode";
            rbLineMode.Size = new System.Drawing.Size(68, 19);
            rbLineMode.TabIndex = 1;
            rbLineMode.Text = "GL_LINE";
            rbLineMode.UseVisualStyleBackColor = true;
            rbLineMode.CheckedChanged += rbLineMode_CheckedChanged;
            // 
            // rbFillMode
            // 
            rbFillMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbFillMode.AutoSize = true;
            rbFillMode.Location = new System.Drawing.Point(6, 22);
            rbFillMode.Name = "rbFillMode";
            rbFillMode.Size = new System.Drawing.Size(65, 19);
            rbFillMode.TabIndex = 0;
            rbFillMode.Text = "GL_FILL";
            rbFillMode.UseVisualStyleBackColor = true;
            rbFillMode.CheckedChanged += rbFillMode_CheckedChanged;
            // 
            // gbDrawMode
            // 
            gbDrawMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbDrawMode.Controls.Add(rbFillMode);
            gbDrawMode.Controls.Add(rbLineMode);
            gbDrawMode.Controls.Add(rbPointMode);
            gbDrawMode.Location = new System.Drawing.Point(368, 152);
            gbDrawMode.Name = "gbDrawMode";
            gbDrawMode.Size = new System.Drawing.Size(104, 100);
            gbDrawMode.TabIndex = 2;
            gbDrawMode.TabStop = false;
            gbDrawMode.Text = "DrawMode";
            // 
            // nUDVertical
            // 
            nUDVertical.Anchor = System.Windows.Forms.AnchorStyles.None;
            nUDVertical.Location = new System.Drawing.Point(6, 37);
            nUDVertical.Name = "nUDVertical";
            nUDVertical.Size = new System.Drawing.Size(68, 23);
            nUDVertical.TabIndex = 3;
            nUDVertical.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nUDVertical.ValueChanged += nUDVertical_ValueChanged;
            // 
            // nUDHorizontal
            // 
            nUDHorizontal.Anchor = System.Windows.Forms.AnchorStyles.None;
            nUDHorizontal.Location = new System.Drawing.Point(6, 92);
            nUDHorizontal.Name = "nUDHorizontal";
            nUDHorizontal.Size = new System.Drawing.Size(68, 23);
            nUDHorizontal.TabIndex = 4;
            nUDHorizontal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nUDHorizontal.ValueChanged += nUDHorizontal_ValueChanged;
            // 
            // lblVertical
            // 
            lblVertical.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblVertical.AutoSize = true;
            lblVertical.Location = new System.Drawing.Point(6, 19);
            lblVertical.Name = "lblVertical";
            lblVertical.Size = new System.Drawing.Size(45, 15);
            lblVertical.TabIndex = 5;
            lblVertical.Text = "Vertical";
            // 
            // lblHorizontal
            // 
            lblHorizontal.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblHorizontal.AutoSize = true;
            lblHorizontal.Location = new System.Drawing.Point(6, 74);
            lblHorizontal.Name = "lblHorizontal";
            lblHorizontal.Size = new System.Drawing.Size(62, 15);
            lblHorizontal.TabIndex = 6;
            lblHorizontal.Text = "Horizontal";
            // 
            // gbTiles
            // 
            gbTiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbTiles.Controls.Add(lblVertical);
            gbTiles.Controls.Add(nUDHorizontal);
            gbTiles.Controls.Add(lblHorizontal);
            gbTiles.Controls.Add(nUDVertical);
            gbTiles.Location = new System.Drawing.Point(368, 12);
            gbTiles.Name = "gbTiles";
            gbTiles.Size = new System.Drawing.Size(104, 119);
            gbTiles.TabIndex = 7;
            gbTiles.TabStop = false;
            gbTiles.Text = "Number of tiles";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 411);
            Controls.Add(gbTiles);
            Controls.Add(gbDrawMode);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            gbDrawMode.ResumeLayout(false);
            gbDrawMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDVertical).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDHorizontal).EndInit();
            gbTiles.ResumeLayout(false);
            gbTiles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.RadioButton rbPointMode;
        private System.Windows.Forms.RadioButton rbLineMode;
        private System.Windows.Forms.RadioButton rbFillMode;
        private System.Windows.Forms.GroupBox gbDrawMode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown nUDVertical;
        private System.Windows.Forms.NumericUpDown nUDHorizontal;
        private System.Windows.Forms.Label lblVertical;
        private System.Windows.Forms.Label lblHorizontal;
        private System.Windows.Forms.GroupBox gbTiles;
    }
}

