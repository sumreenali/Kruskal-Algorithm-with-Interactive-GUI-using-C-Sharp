namespace Kruskal
{
    partial class Kruskal
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
            this.panelKruskal = new System.Windows.Forms.Panel();
            this.Solve = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelKruskal
            // 
            this.panelKruskal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelKruskal.BackgroundImage = global::Kruskal.Properties.Resources.brown_frame;
            this.panelKruskal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelKruskal.Location = new System.Drawing.Point(48, 124);
            this.panelKruskal.Name = "panelKruskal";
            this.panelKruskal.Size = new System.Drawing.Size(549, 392);
            this.panelKruskal.TabIndex = 0;
            this.panelKruskal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelKruskal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // Solve
            // 
            this.Solve.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Solve.Font = new System.Drawing.Font("Snap ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Solve.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Solve.Location = new System.Drawing.Point(615, 239);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(91, 37);
            this.Solve.TabIndex = 1;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Clear.Font = new System.Drawing.Font("Snap ITC", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Clear.ForeColor = System.Drawing.SystemColors.GrayText;
            this.Clear.Location = new System.Drawing.Point(615, 299);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(91, 37);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(82, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kruskal Algorithm ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Kruskal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kruskal.Properties.Resources._5;
            this.ClientSize = new System.Drawing.Size(746, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.panelKruskal);
            this.Name = "Kruskal";
            this.Text = "Kruskal";
            this.Load += new System.EventHandler(this.Kruskal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKruskal;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
    }
}

