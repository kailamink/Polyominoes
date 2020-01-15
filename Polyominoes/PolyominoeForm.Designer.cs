namespace Polyominoes
{
    partial class PolyominoeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.status = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSize = new System.Windows.Forms.NumericUpDown();
            this.pnlBoard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).BeginInit();
            this.SuspendLayout();
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(12, 514);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(83, 20);
            this.status.TabIndex = 0;
            this.status.Text = "statusText";
            this.status.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "size:";
            // 
            // nudSize
            // 
            this.nudSize.Location = new System.Drawing.Point(59, 7);
            this.nudSize.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSize.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSize.Name = "nudSize";
            this.nudSize.Size = new System.Drawing.Size(120, 26);
            this.nudSize.TabIndex = 2;
            this.nudSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudSize.ValueChanged += new System.EventHandler(this.nudSize_ValueChanged);
            // 
            // pnlBoard
            // 
            this.pnlBoard.BackColor = System.Drawing.Color.White;
            this.pnlBoard.Location = new System.Drawing.Point(135, 74);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(400, 400);
            this.pnlBoard.TabIndex = 3;
            // 
            // PolyominoeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 543);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.nudSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.status);
            this.Name = "PolyominoeForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudSize;
        private System.Windows.Forms.Panel pnlBoard;
    }
}

