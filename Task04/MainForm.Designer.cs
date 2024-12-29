
namespace Task04Nikolaiev
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            gbFigure = new System.Windows.Forms.GroupBox();
            rbPar = new System.Windows.Forms.RadioButton();
            rbHyp = new System.Windows.Forms.RadioButton();
            gbParameters = new System.Windows.Forms.GroupBox();
            lblC = new System.Windows.Forms.Label();
            lblB = new System.Windows.Forms.Label();
            lblA = new System.Windows.Forms.Label();
            nudC = new System.Windows.Forms.NumericUpDown();
            nudB = new System.Windows.Forms.NumericUpDown();
            nudA = new System.Windows.Forms.NumericUpDown();
            gbFigure.SuspendLayout();
            gbParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudA).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.func = 0;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.margin = 3D;
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(300, 300);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            // 
            // gbFigure
            // 
            gbFigure.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbFigure.Controls.Add(rbPar);
            gbFigure.Controls.Add(rbHyp);
            gbFigure.Location = new System.Drawing.Point(325, 12);
            gbFigure.Name = "gbFigure";
            gbFigure.Size = new System.Drawing.Size(139, 78);
            gbFigure.TabIndex = 1;
            gbFigure.TabStop = false;
            gbFigure.Text = "Settings";
            // 
            // rbPar
            // 
            rbPar.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbPar.AutoSize = true;
            rbPar.Location = new System.Drawing.Point(6, 53);
            rbPar.Name = "rbPar";
            rbPar.Size = new System.Drawing.Size(71, 19);
            rbPar.TabIndex = 3;
            rbPar.Text = "Parabola";
            rbPar.UseVisualStyleBackColor = true;
            rbPar.CheckedChanged += rbPar_CheckedChanged;
            // 
            // rbHyp
            // 
            rbHyp.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbHyp.AutoSize = true;
            rbHyp.Checked = true;
            rbHyp.Location = new System.Drawing.Point(6, 30);
            rbHyp.Name = "rbHyp";
            rbHyp.Size = new System.Drawing.Size(80, 19);
            rbHyp.TabIndex = 2;
            rbHyp.TabStop = true;
            rbHyp.Text = "Hyperbola";
            rbHyp.UseVisualStyleBackColor = true;
            rbHyp.CheckedChanged += rbHyp_CheckedChanged;
            // 
            // gbParameters
            // 
            gbParameters.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbParameters.Controls.Add(lblC);
            gbParameters.Controls.Add(lblB);
            gbParameters.Controls.Add(lblA);
            gbParameters.Controls.Add(nudC);
            gbParameters.Controls.Add(nudB);
            gbParameters.Controls.Add(nudA);
            gbParameters.Location = new System.Drawing.Point(325, 118);
            gbParameters.Name = "gbParameters";
            gbParameters.Size = new System.Drawing.Size(139, 108);
            gbParameters.TabIndex = 2;
            gbParameters.TabStop = false;
            gbParameters.Text = "Parameters";
            // 
            // lblC
            // 
            lblC.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblC.AutoSize = true;
            lblC.Location = new System.Drawing.Point(71, 84);
            lblC.Name = "lblC";
            lblC.Size = new System.Drawing.Size(15, 15);
            lblC.TabIndex = 5;
            lblC.Text = "C";
            lblC.Visible = false;
            // 
            // lblB
            // 
            lblB.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblB.AutoSize = true;
            lblB.Location = new System.Drawing.Point(71, 55);
            lblB.Name = "lblB";
            lblB.Size = new System.Drawing.Size(14, 15);
            lblB.TabIndex = 4;
            lblB.Text = "B";
            // 
            // lblA
            // 
            lblA.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblA.AutoSize = true;
            lblA.Location = new System.Drawing.Point(71, 26);
            lblA.Name = "lblA";
            lblA.Size = new System.Drawing.Size(15, 15);
            lblA.TabIndex = 3;
            lblA.Text = "A";
            // 
            // nudC
            // 
            nudC.Anchor = System.Windows.Forms.AnchorStyles.None;
            nudC.DecimalPlaces = 1;
            nudC.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudC.Location = new System.Drawing.Point(11, 82);
            nudC.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudC.Name = "nudC";
            nudC.Size = new System.Drawing.Size(54, 23);
            nudC.TabIndex = 2;
            nudC.Visible = false;
            nudC.ValueChanged += nudC_ValueChanged;
            // 
            // nudB
            // 
            nudB.Anchor = System.Windows.Forms.AnchorStyles.None;
            nudB.DecimalPlaces = 1;
            nudB.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudB.Location = new System.Drawing.Point(11, 53);
            nudB.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudB.Name = "nudB";
            nudB.Size = new System.Drawing.Size(54, 23);
            nudB.TabIndex = 1;
            nudB.ValueChanged += nudB_ValueChanged;
            // 
            // nudA
            // 
            nudA.Anchor = System.Windows.Forms.AnchorStyles.None;
            nudA.DecimalPlaces = 1;
            nudA.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudA.Location = new System.Drawing.Point(11, 24);
            nudA.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nudA.Name = "nudA";
            nudA.Size = new System.Drawing.Size(54, 23);
            nudA.TabIndex = 0;
            nudA.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudA.ValueChanged += nudA_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(476, 329);
            Controls.Add(gbParameters);
            Controls.Add(gbFigure);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            gbFigure.ResumeLayout(false);
            gbFigure.PerformLayout();
            gbParameters.ResumeLayout(false);
            gbParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudC).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudB).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.GroupBox gbFigure;
        private System.Windows.Forms.RadioButton rbPar;
        private System.Windows.Forms.RadioButton rbHyp;
        private System.Windows.Forms.GroupBox gbParameters;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.NumericUpDown nudC;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.NumericUpDown nudA;
    }
}

