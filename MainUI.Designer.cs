namespace JanselUI_GFN_GUI
{
    partial class MainUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.CoresThreads = new System.Windows.Forms.Label();
            this.SystemInformation = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Programs = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Games = new Guna.UI2.WinForms.Guna2GradientButton();
            this.Schließen = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // CoresThreads
            // 
            this.CoresThreads.AutoSize = true;
            this.CoresThreads.BackColor = System.Drawing.Color.Transparent;
            this.CoresThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CoresThreads.Location = new System.Drawing.Point(12, 9);
            this.CoresThreads.Name = "CoresThreads";
            this.CoresThreads.Size = new System.Drawing.Size(441, 20);
            this.CoresThreads.TabIndex = 4;
            this.CoresThreads.Text = "Donations are accepted over this link: paypal.me/JanselUI";
            // 
            // SystemInformation
            // 
            this.SystemInformation.AutoRoundedCorners = true;
            this.SystemInformation.BackColor = System.Drawing.Color.Transparent;
            this.SystemInformation.BorderRadius = 21;
            this.SystemInformation.CheckedState.Parent = this.SystemInformation;
            this.SystemInformation.CustomImages.Parent = this.SystemInformation;
            this.SystemInformation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SystemInformation.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(80)))), ((int)(((byte)(123)))));
            this.SystemInformation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SystemInformation.ForeColor = System.Drawing.Color.White;
            this.SystemInformation.HoverState.Parent = this.SystemInformation;
            this.SystemInformation.Location = new System.Drawing.Point(16, 32);
            this.SystemInformation.Name = "SystemInformation";
            this.SystemInformation.ShadowDecoration.Parent = this.SystemInformation;
            this.SystemInformation.Size = new System.Drawing.Size(180, 45);
            this.SystemInformation.TabIndex = 6;
            this.SystemInformation.Text = "System Config";
            this.SystemInformation.Click += new System.EventHandler(this.SystemInformation_Click);
            // 
            // Programs
            // 
            this.Programs.AutoRoundedCorners = true;
            this.Programs.BackColor = System.Drawing.Color.Transparent;
            this.Programs.BorderRadius = 21;
            this.Programs.CheckedState.Parent = this.Programs;
            this.Programs.CustomImages.Parent = this.Programs;
            this.Programs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Programs.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(80)))), ((int)(((byte)(123)))));
            this.Programs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Programs.ForeColor = System.Drawing.Color.White;
            this.Programs.HoverState.Parent = this.Programs;
            this.Programs.Location = new System.Drawing.Point(202, 32);
            this.Programs.Name = "Programs";
            this.Programs.ShadowDecoration.Parent = this.Programs;
            this.Programs.Size = new System.Drawing.Size(180, 45);
            this.Programs.TabIndex = 7;
            this.Programs.Text = "Programs";
            this.Programs.Click += new System.EventHandler(this.Programs_Click);
            // 
            // Games
            // 
            this.Games.AutoRoundedCorners = true;
            this.Games.BackColor = System.Drawing.Color.Transparent;
            this.Games.BorderRadius = 21;
            this.Games.CheckedState.Parent = this.Games;
            this.Games.CustomImages.Parent = this.Games;
            this.Games.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Games.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(80)))), ((int)(((byte)(123)))));
            this.Games.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Games.ForeColor = System.Drawing.Color.White;
            this.Games.HoverState.Parent = this.Games;
            this.Games.Location = new System.Drawing.Point(388, 32);
            this.Games.Name = "Games";
            this.Games.ShadowDecoration.Parent = this.Games;
            this.Games.Size = new System.Drawing.Size(180, 45);
            this.Games.TabIndex = 8;
            this.Games.Text = "Games";
            this.Games.Click += new System.EventHandler(this.Games_Click);
            // 
            // Schließen
            // 
            this.Schließen.AutoRoundedCorners = true;
            this.Schließen.BackColor = System.Drawing.Color.Transparent;
            this.Schließen.BorderRadius = 21;
            this.Schließen.CheckedState.Parent = this.Schließen;
            this.Schließen.CustomImages.Parent = this.Schließen;
            this.Schließen.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Schließen.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(80)))), ((int)(((byte)(123)))));
            this.Schließen.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Schließen.ForeColor = System.Drawing.Color.White;
            this.Schließen.HoverState.Parent = this.Schließen;
            this.Schließen.Location = new System.Drawing.Point(572, 32);
            this.Schließen.Name = "Schließen";
            this.Schließen.ShadowDecoration.Parent = this.Schließen;
            this.Schließen.Size = new System.Drawing.Size(180, 45);
            this.Schließen.TabIndex = 9;
            this.Schließen.Text = "Close";
            this.Schließen.Click += new System.EventHandler(this.Schließen_Click);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(764, 311);
            this.Controls.Add(this.Schließen);
            this.Controls.Add(this.Games);
            this.Controls.Add(this.Programs);
            this.Controls.Add(this.SystemInformation);
            this.Controls.Add(this.CoresThreads);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainUI";
            this.ShowIcon = false;
            this.Text = "JanselUI GUI Edition (GFN; V2.0.4)";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label CoresThreads;
        private Guna.UI2.WinForms.Guna2GradientButton SystemInformation;
        private Guna.UI2.WinForms.Guna2GradientButton Programs;
        private Guna.UI2.WinForms.Guna2GradientButton Games;
        private Guna.UI2.WinForms.Guna2GradientButton Schließen;
    }
}

