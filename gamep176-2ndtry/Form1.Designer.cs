namespace gamep176_2ndtry
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.missedLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.accuracyLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.difficultyProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 108;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(821, 143);
            this.listBox1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 800;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel1,
            this.missedLabel1,
            this.totalLabel1,
            this.accuracyLabel1,
            this.difficultyLabel1,
            this.difficultyProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 121);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(821, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // correctLabel1
            // 
            this.correctLabel1.Name = "correctLabel1";
            this.correctLabel1.Size = new System.Drawing.Size(58, 17);
            this.correctLabel1.Text = "Correct: 0";
            // 
            // missedLabel1
            // 
            this.missedLabel1.Name = "missedLabel1";
            this.missedLabel1.Size = new System.Drawing.Size(56, 17);
            this.missedLabel1.Text = "Missed: 0";
            // 
            // totalLabel1
            // 
            this.totalLabel1.Name = "totalLabel1";
            this.totalLabel1.Size = new System.Drawing.Size(45, 17);
            this.totalLabel1.Text = "Total: 0";
            // 
            // accuracyLabel1
            // 
            this.accuracyLabel1.Name = "accuracyLabel1";
            this.accuracyLabel1.Size = new System.Drawing.Size(72, 17);
            this.accuracyLabel1.Text = "Acuracy: 0%";
            // 
            // difficultyLabel1
            // 
            this.difficultyLabel1.Name = "difficultyLabel1";
            this.difficultyLabel1.Size = new System.Drawing.Size(473, 17);
            this.difficultyLabel1.Spring = true;
            this.difficultyLabel1.Text = "Difficulty";
            this.difficultyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // difficultyProgressBar1
            // 
            this.difficultyProgressBar1.Maximum = 701;
            this.difficultyProgressBar1.Name = "difficultyProgressBar1";
            this.difficultyProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 143);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "typing game!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel1;
        private System.Windows.Forms.ToolStripStatusLabel missedLabel1;
        private System.Windows.Forms.ToolStripStatusLabel totalLabel1;
        private System.Windows.Forms.ToolStripStatusLabel accuracyLabel1;
        private System.Windows.Forms.ToolStripStatusLabel difficultyLabel1;
        private System.Windows.Forms.ToolStripProgressBar difficultyProgressBar1;
    }
}

