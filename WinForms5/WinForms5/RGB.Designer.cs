namespace WinForms5
{
    partial class RGB
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
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.labelR = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(49, 51);
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(104, 45);
            this.trackBarR.TabIndex = 0;
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(49, 102);
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(104, 45);
            this.trackBarG.TabIndex = 1;
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(49, 170);
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(104, 45);
            this.trackBarB.TabIndex = 2;
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(29, 51);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(15, 13);
            this.labelR.TabIndex = 3;
            this.labelR.Text = "R";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Location = new System.Drawing.Point(29, 102);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(15, 13);
            this.labelG.TabIndex = 4;
            this.labelG.Text = "G";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(29, 179);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(14, 13);
            this.labelB.TabIndex = 5;
            this.labelB.Text = "B";
            // 
            // RGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarG);
            this.Controls.Add(this.trackBarR);
            this.Name = "RGB";
            this.Text = "RGB";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.TrackBar trackBarG;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelB;
    }
}