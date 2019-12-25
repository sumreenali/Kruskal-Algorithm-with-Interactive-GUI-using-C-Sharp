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
            this.SuspendLayout();
            // 
            // panelKruskal
            // 
            this.panelKruskal.Location = new System.Drawing.Point(36, 37);
            this.panelKruskal.Name = "panelKruskal";
            this.panelKruskal.Size = new System.Drawing.Size(372, 330);
            this.panelKruskal.TabIndex = 0;
            this.panelKruskal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelKruskal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick); 

            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(453, 37);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(75, 23);
            this.Solve.TabIndex = 1;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(453, 87);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 2;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Kruskal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 423);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.panelKruskal);
            this.Name = "Kruskal";
            this.Text = "Kruskal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKruskal;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.Button Clear;
    }
}

