
namespace Task03Nikolaiev
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
            lblXMin = new System.Windows.Forms.Label();
            lblXMax = new System.Windows.Forms.Label();
            lblYMin = new System.Windows.Forms.Label();
            lblYMax = new System.Windows.Forms.Label();
            rbF1X = new System.Windows.Forms.RadioButton();
            rbF2X = new System.Windows.Forms.RadioButton();
            nUDXmin = new System.Windows.Forms.NumericUpDown();
            nUDXmax = new System.Windows.Forms.NumericUpDown();
            nUDYmin = new System.Windows.Forms.NumericUpDown();
            nUDYmax = new System.Windows.Forms.NumericUpDown();
            gbX = new System.Windows.Forms.GroupBox();
            btnShowY = new System.Windows.Forms.Button();
            gbY = new System.Windows.Forms.GroupBox();
            gbF = new System.Windows.Forms.GroupBox();
            lblFunc2 = new System.Windows.Forms.Label();
            lblFunc1 = new System.Windows.Forms.Label();
            gbPoints = new System.Windows.Forms.GroupBox();
            nUDPoints = new System.Windows.Forms.NumericUpDown();
            lblPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)nUDXmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDXmax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDYmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDYmax).BeginInit();
            gbX.SuspendLayout();
            gbY.SuspendLayout();
            gbF.SuspendLayout();
            gbPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUDPoints).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.autoY = true;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.func = 0;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(302, 387);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.xMax = 1.2D;
            renderControl1.xMin = -1.2D;
            renderControl1.yMax = 1.447986489289727D;
            renderControl1.yMin = -0.82709044347999816D;
            // 
            // lblXMin
            // 
            lblXMin.AutoSize = true;
            lblXMin.Location = new System.Drawing.Point(6, 19);
            lblXMin.Name = "lblXMin";
            lblXMin.Size = new System.Drawing.Size(38, 15);
            lblXMin.TabIndex = 1;
            lblXMin.Text = "X Min";
            // 
            // lblXMax
            // 
            lblXMax.AutoSize = true;
            lblXMax.Location = new System.Drawing.Point(6, 48);
            lblXMax.Name = "lblXMax";
            lblXMax.Size = new System.Drawing.Size(40, 15);
            lblXMax.TabIndex = 2;
            lblXMax.Text = "X Max";
            // 
            // lblYMin
            // 
            lblYMin.AutoSize = true;
            lblYMin.Location = new System.Drawing.Point(6, 14);
            lblYMin.Name = "lblYMin";
            lblYMin.Size = new System.Drawing.Size(38, 15);
            lblYMin.TabIndex = 3;
            lblYMin.Text = "Y Min";
            // 
            // lblYMax
            // 
            lblYMax.AutoSize = true;
            lblYMax.Location = new System.Drawing.Point(6, 45);
            lblYMax.Name = "lblYMax";
            lblYMax.Size = new System.Drawing.Size(40, 15);
            lblYMax.TabIndex = 4;
            lblYMax.Text = "Y Max";
            // 
            // rbF1X
            // 
            rbF1X.AutoSize = true;
            rbF1X.Checked = true;
            rbF1X.Location = new System.Drawing.Point(15, 19);
            rbF1X.Name = "rbF1X";
            rbF1X.Size = new System.Drawing.Size(14, 13);
            rbF1X.TabIndex = 6;
            rbF1X.TabStop = true;
            rbF1X.UseVisualStyleBackColor = true;
            rbF1X.CheckedChanged += rbF1X_CheckedChanged;
            // 
            // rbF2X
            // 
            rbF2X.AutoSize = true;
            rbF2X.Location = new System.Drawing.Point(15, 47);
            rbF2X.Name = "rbF2X";
            rbF2X.Size = new System.Drawing.Size(14, 13);
            rbF2X.TabIndex = 7;
            rbF2X.UseVisualStyleBackColor = true;
            rbF2X.CheckedChanged += rbF2X_CheckedChanged;
            // 
            // nUDXmin
            // 
            nUDXmin.DecimalPlaces = 1;
            nUDXmin.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUDXmin.Location = new System.Drawing.Point(50, 17);
            nUDXmin.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nUDXmin.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            nUDXmin.Name = "nUDXmin";
            nUDXmin.Size = new System.Drawing.Size(66, 23);
            nUDXmin.TabIndex = 8;
            nUDXmin.Value = new decimal(new int[] { 30, 0, 0, -2147418112 });
            nUDXmin.ValueChanged += nUDXmin_ValueChanged;
            // 
            // nUDXmax
            // 
            nUDXmax.DecimalPlaces = 1;
            nUDXmax.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUDXmax.Location = new System.Drawing.Point(50, 46);
            nUDXmax.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nUDXmax.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            nUDXmax.Name = "nUDXmax";
            nUDXmax.Size = new System.Drawing.Size(66, 23);
            nUDXmax.TabIndex = 9;
            nUDXmax.Value = new decimal(new int[] { 30, 0, 0, 65536 });
            nUDXmax.ValueChanged += nUDXmax_ValueChanged;
            // 
            // nUDYmin
            // 
            nUDYmin.DecimalPlaces = 1;
            nUDYmin.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUDYmin.Location = new System.Drawing.Point(50, 12);
            nUDYmin.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nUDYmin.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            nUDYmin.Name = "nUDYmin";
            nUDYmin.Size = new System.Drawing.Size(66, 23);
            nUDYmin.TabIndex = 10;
            nUDYmin.Value = new decimal(new int[] { 30, 0, 0, -2147418112 });
            nUDYmin.ValueChanged += nUDYmin_ValueChanged;
            // 
            // nUDYmax
            // 
            nUDYmax.DecimalPlaces = 1;
            nUDYmax.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUDYmax.Location = new System.Drawing.Point(50, 45);
            nUDYmax.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            nUDYmax.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            nUDYmax.Name = "nUDYmax";
            nUDYmax.Size = new System.Drawing.Size(66, 23);
            nUDYmax.TabIndex = 11;
            nUDYmax.Value = new decimal(new int[] { 30, 0, 0, 65536 });
            nUDYmax.ValueChanged += nUDYmax_ValueChanged;
            // 
            // gbX
            // 
            gbX.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbX.Controls.Add(btnShowY);
            gbX.Controls.Add(lblXMin);
            gbX.Controls.Add(lblXMax);
            gbX.Controls.Add(nUDXmin);
            gbX.Controls.Add(nUDXmax);
            gbX.Location = new System.Drawing.Point(341, 59);
            gbX.Name = "gbX";
            gbX.Size = new System.Drawing.Size(131, 105);
            gbX.TabIndex = 12;
            gbX.TabStop = false;
            // 
            // btnShowY
            // 
            btnShowY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            btnShowY.Location = new System.Drawing.Point(0, 77);
            btnShowY.Name = "btnShowY";
            btnShowY.Size = new System.Drawing.Size(131, 23);
            btnShowY.TabIndex = 18;
            btnShowY.Text = "Y's menu";
            btnShowY.UseVisualStyleBackColor = true;
            btnShowY.Click += btnShowY_Click;
            // 
            // gbY
            // 
            gbY.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbY.Controls.Add(lblYMin);
            gbY.Controls.Add(nUDYmax);
            gbY.Controls.Add(lblYMax);
            gbY.Controls.Add(nUDYmin);
            gbY.Location = new System.Drawing.Point(341, 193);
            gbY.Name = "gbY";
            gbY.Size = new System.Drawing.Size(131, 83);
            gbY.TabIndex = 13;
            gbY.TabStop = false;
            gbY.Visible = false;
            // 
            // gbF
            // 
            gbF.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbF.Controls.Add(lblFunc2);
            gbF.Controls.Add(lblFunc1);
            gbF.Controls.Add(rbF1X);
            gbF.Controls.Add(rbF2X);
            gbF.Location = new System.Drawing.Point(341, 305);
            gbF.Name = "gbF";
            gbF.Size = new System.Drawing.Size(131, 76);
            gbF.TabIndex = 16;
            gbF.TabStop = false;
            // 
            // lblFunc2
            // 
            lblFunc2.AutoSize = true;
            lblFunc2.Location = new System.Drawing.Point(35, 46);
            lblFunc2.Name = "lblFunc2";
            lblFunc2.Size = new System.Drawing.Size(63, 15);
            lblFunc2.TabIndex = 9;
            lblFunc2.Text = "Function 2";
            // 
            // lblFunc1
            // 
            lblFunc1.AutoSize = true;
            lblFunc1.Location = new System.Drawing.Point(35, 19);
            lblFunc1.Name = "lblFunc1";
            lblFunc1.Size = new System.Drawing.Size(63, 15);
            lblFunc1.TabIndex = 8;
            lblFunc1.Text = "Function 1";
            // 
            // gbPoints
            // 
            gbPoints.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            gbPoints.Controls.Add(nUDPoints);
            gbPoints.Controls.Add(lblPoints);
            gbPoints.Location = new System.Drawing.Point(341, 12);
            gbPoints.Name = "gbPoints";
            gbPoints.Size = new System.Drawing.Size(131, 41);
            gbPoints.TabIndex = 17;
            gbPoints.TabStop = false;
            // 
            // nUDPoints
            // 
            nUDPoints.Location = new System.Drawing.Point(50, 11);
            nUDPoints.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nUDPoints.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nUDPoints.Name = "nUDPoints";
            nUDPoints.Size = new System.Drawing.Size(66, 23);
            nUDPoints.TabIndex = 1;
            nUDPoints.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            nUDPoints.ValueChanged += nUDPoints_ValueChanged;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Location = new System.Drawing.Point(6, 13);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new System.Drawing.Size(40, 15);
            lblPoints.TabIndex = 0;
            lblPoints.Text = "Points";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 411);
            Controls.Add(gbPoints);
            Controls.Add(gbF);
            Controls.Add(gbY);
            Controls.Add(gbX);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)nUDXmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDXmax).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDYmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDYmax).EndInit();
            gbX.ResumeLayout(false);
            gbX.PerformLayout();
            gbY.ResumeLayout(false);
            gbY.PerformLayout();
            gbF.ResumeLayout(false);
            gbF.PerformLayout();
            gbPoints.ResumeLayout(false);
            gbPoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUDPoints).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Label lblXMin;
        private System.Windows.Forms.Label lblXMax;
        private System.Windows.Forms.Label lblYMin;
        private System.Windows.Forms.Label lblYMax;
        private System.Windows.Forms.RadioButton rbF1X;
        private System.Windows.Forms.RadioButton rbF2X;
        private System.Windows.Forms.NumericUpDown nUDXmin;
        private System.Windows.Forms.NumericUpDown nUDXmax;
        private System.Windows.Forms.NumericUpDown nUDYmin;
        private System.Windows.Forms.NumericUpDown nUDYmax;
        private System.Windows.Forms.GroupBox gbX;
        private System.Windows.Forms.GroupBox gbY;
        private System.Windows.Forms.GroupBox gbF;
        private System.Windows.Forms.GroupBox gbPoints;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.NumericUpDown nUDPoints;
        private System.Windows.Forms.Button btnShowY;
        private System.Windows.Forms.Label lblFunc2;
        private System.Windows.Forms.Label lblFunc1;
    }
}

