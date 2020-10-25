namespace JanselUI_GFN_GUI
{
    partial class SysInfo
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
            this.CPUInformation = new System.Windows.Forms.Label();
            this.GPUInformation = new System.Windows.Forms.Label();
            this.CoresThreads = new System.Windows.Forms.Label();
            this.Schließen = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // CPUInformation
            // 
            this.CPUInformation.AutoSize = true;
            this.CPUInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CPUInformation.Location = new System.Drawing.Point(12, 29);
            this.CPUInformation.Name = "CPUInformation";
            this.CPUInformation.Size = new System.Drawing.Size(137, 20);
            this.CPUInformation.TabIndex = 0;
            this.CPUInformation.Text = "CPU stands here";
            // 
            // GPUInformation
            // 
            this.GPUInformation.AutoSize = true;
            this.GPUInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.GPUInformation.Location = new System.Drawing.Point(12, 9);
            this.GPUInformation.Name = "GPUInformation";
            this.GPUInformation.Size = new System.Drawing.Size(138, 20);
            this.GPUInformation.TabIndex = 1;
            this.GPUInformation.Text = "GPU stands here";
            // 
            // CoresThreads
            // 
            this.CoresThreads.AutoSize = true;
            this.CoresThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CoresThreads.Location = new System.Drawing.Point(13, 49);
            this.CoresThreads.Name = "CoresThreads";
            this.CoresThreads.Size = new System.Drawing.Size(245, 20);
            this.CoresThreads.TabIndex = 2;
            this.CoresThreads.Text = "Cores and Threads stands here";
            // 
            // Schließen
            // 
            this.Schließen.AutoRoundedCorners = true;
            this.Schließen.BackColor = System.Drawing.Color.Transparent;
            this.Schließen.BorderRadius = 11;
            this.Schließen.CheckedState.Parent = this.Schließen;
            this.Schließen.CustomImages.Parent = this.Schließen;
            this.Schließen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Schließen.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(80)))), ((int)(((byte)(123)))));
            this.Schließen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Schließen.ForeColor = System.Drawing.Color.White;
            this.Schließen.HoverState.Parent = this.Schließen;
            this.Schließen.Location = new System.Drawing.Point(663, 44);
            this.Schließen.Name = "Schließen";
            this.Schließen.ShadowDecoration.Parent = this.Schließen;
            this.Schließen.Size = new System.Drawing.Size(125, 25);
            this.Schließen.TabIndex = 10;
            this.Schließen.Text = "Close";
            this.Schließen.Click += new System.EventHandler(this.Schließen_Click);
            // 
            // SysInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 81);
            this.Controls.Add(this.Schließen);
            this.Controls.Add(this.CoresThreads);
            this.Controls.Add(this.GPUInformation);
            this.Controls.Add(this.CPUInformation);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SysInfo";
            this.ShowIcon = false;
            this.Text = "JanselUI GUI Edition (GFN; System Information; V2.0.4)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CPUInformation;
        private System.Windows.Forms.Label GPUInformation;
        private System.Windows.Forms.Label CoresThreads;
        private Guna.UI2.WinForms.Guna2GradientButton Schließen;
    }
}