namespace LogoRecognitionSystem
{
    partial class ZoomableImage
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.ImagePB = new System.Windows.Forms.PictureBox();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagePanel
            // 
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.Controls.Add(this.ImagePB);
            this.ImagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImagePanel.Location = new System.Drawing.Point(0, 0);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(347, 360);
            this.ImagePanel.TabIndex = 0;
            // 
            // ImagePB
            // 
            this.ImagePB.Location = new System.Drawing.Point(15, 48);
            this.ImagePB.Name = "ImagePB";
            this.ImagePB.Size = new System.Drawing.Size(317, 278);
            this.ImagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ImagePB.TabIndex = 0;
            this.ImagePB.TabStop = false;
            this.ImagePB.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.scrollZoom_Scroll);
            // 
            // ZoomableImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ImagePanel);
            this.Name = "ZoomableImage";
            this.Size = new System.Drawing.Size(347, 360);
            this.ImagePanel.ResumeLayout(false);
            this.ImagePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel ImagePanel;
        public PictureBox ImagePB;
    }
}
