namespace LogoRecognitionSystem
{
    partial class Snip_Images
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.posion_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.extract_blobs = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Export_button = new System.Windows.Forms.Button();
            this.ideal_set_cb = new System.Windows.Forms.ComboBox();
            this.Image_name_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.current_selected_image = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.last_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.sniped_img_pictureBox = new System.Windows.Forms.PictureBox();
            this.load_img_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.waiting_for_extract_blobs = new System.Windows.Forms.Button();
            this.docu_pb = new LogoRecognitionSystem.ZoomableImage();
            this.Extract_Blobs_bgw = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sniped_img_pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.extract_blobs);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.current_selected_image);
            this.panel1.Controls.Add(this.next_btn);
            this.panel1.Controls.Add(this.last_btn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.load_img_button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 934);
            this.panel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posion_label});
            this.statusStrip1.Location = new System.Drawing.Point(0, 912);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1105, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // posion_label
            // 
            this.posion_label.BackColor = System.Drawing.Color.White;
            this.posion_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.posion_label.ForeColor = System.Drawing.Color.White;
            this.posion_label.Name = "posion_label";
            this.posion_label.Size = new System.Drawing.Size(1090, 17);
            this.posion_label.Spring = true;
            this.posion_label.Text = "x : 0, y : 0";
            // 
            // extract_blobs
            // 
            this.extract_blobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.extract_blobs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.extract_blobs.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.extract_blobs.Location = new System.Drawing.Point(504, 852);
            this.extract_blobs.Name = "extract_blobs";
            this.extract_blobs.Size = new System.Drawing.Size(157, 49);
            this.extract_blobs.TabIndex = 13;
            this.extract_blobs.Text = "Extract Blobs";
            this.extract_blobs.UseVisualStyleBackColor = false;
            this.extract_blobs.Click += new System.EventHandler(this.Extract_Blobs_button_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Export_button);
            this.panel4.Controls.Add(this.ideal_set_cb);
            this.panel4.Controls.Add(this.Image_name_tb);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(695, 448);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 375);
            this.panel4.TabIndex = 11;
            // 
            // Export_button
            // 
            this.Export_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.Export_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Export_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Export_button.Location = new System.Drawing.Point(203, 304);
            this.Export_button.Name = "Export_button";
            this.Export_button.Size = new System.Drawing.Size(157, 49);
            this.Export_button.TabIndex = 12;
            this.Export_button.Text = "Export";
            this.Export_button.UseVisualStyleBackColor = false;
            this.Export_button.Click += new System.EventHandler(this.Export_button_Click);
            // 
            // ideal_set_cb
            // 
            this.ideal_set_cb.FormattingEnabled = true;
            this.ideal_set_cb.Location = new System.Drawing.Point(174, 114);
            this.ideal_set_cb.Name = "ideal_set_cb";
            this.ideal_set_cb.Size = new System.Drawing.Size(186, 23);
            this.ideal_set_cb.TabIndex = 14;
            // 
            // Image_name_tb
            // 
            this.Image_name_tb.Location = new System.Drawing.Point(174, 37);
            this.Image_name_tb.Name = "Image_name_tb";
            this.Image_name_tb.Size = new System.Drawing.Size(186, 23);
            this.Image_name_tb.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(23, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ideal Set  :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(23, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Image Name  :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(695, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 27);
            this.label2.TabIndex = 10;
            this.label2.Text = "Train Set :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // current_selected_image
            // 
            this.current_selected_image.AutoSize = true;
            this.current_selected_image.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.current_selected_image.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.current_selected_image.Location = new System.Drawing.Point(851, 141);
            this.current_selected_image.Name = "current_selected_image";
            this.current_selected_image.Size = new System.Drawing.Size(39, 25);
            this.current_selected_image.TabIndex = 9;
            this.current_selected_image.Text = "0/0";
            this.current_selected_image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // next_btn
            // 
            this.next_btn.Image = global::LogoRecognitionSystem.Properties.Resources.icons8_eingekreistes_rangabzeichen_rechts_32;
            this.next_btn.Location = new System.Drawing.Point(1015, 126);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(66, 59);
            this.next_btn.TabIndex = 6;
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_button_Click);
            // 
            // last_btn
            // 
            this.last_btn.Image = global::LogoRecognitionSystem.Properties.Resources.icons8_eingekreistes_rangabzeichen_links_32;
            this.last_btn.Location = new System.Drawing.Point(684, 124);
            this.last_btn.Name = "last_btn";
            this.last_btn.Size = new System.Drawing.Size(66, 59);
            this.last_btn.TabIndex = 5;
            this.last_btn.UseVisualStyleBackColor = true;
            this.last_btn.Click += new System.EventHandler(this.back_button_Click);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.AutoSize = true;
            this.panel3.Controls.Add(this.sniped_img_pictureBox);
            this.panel3.Location = new System.Drawing.Point(684, 189);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(399, 199);
            this.panel3.TabIndex = 2;
            // 
            // sniped_img_pictureBox
            // 
            this.sniped_img_pictureBox.BackColor = System.Drawing.Color.White;
            this.sniped_img_pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sniped_img_pictureBox.Location = new System.Drawing.Point(2, 2);
            this.sniped_img_pictureBox.Name = "sniped_img_pictureBox";
            this.sniped_img_pictureBox.Size = new System.Drawing.Size(395, 195);
            this.sniped_img_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.sniped_img_pictureBox.TabIndex = 0;
            this.sniped_img_pictureBox.TabStop = false;
            // 
            // load_img_button
            // 
            this.load_img_button.BackColor = System.Drawing.Color.DarkCyan;
            this.load_img_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.load_img_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.load_img_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.load_img_button.ForeColor = System.Drawing.Color.White;
            this.load_img_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.load_img_button.Location = new System.Drawing.Point(40, 22);
            this.load_img_button.Name = "load_img_button";
            this.load_img_button.Size = new System.Drawing.Size(186, 54);
            this.load_img_button.TabIndex = 1;
            this.load_img_button.Text = "Load Image";
            this.load_img_button.UseVisualStyleBackColor = false;
            this.load_img_button.Click += new System.EventHandler(this.Open_image_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(95)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.waiting_for_extract_blobs);
            this.panel2.Controls.Add(this.docu_pb);
            this.panel2.Location = new System.Drawing.Point(39, 126);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(623, 698);
            this.panel2.TabIndex = 0;
            // 
            // waiting_for_extract_blobs
            // 
            this.waiting_for_extract_blobs.BackColor = System.Drawing.Color.White;
            this.waiting_for_extract_blobs.FlatAppearance.BorderSize = 0;
            this.waiting_for_extract_blobs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.waiting_for_extract_blobs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.waiting_for_extract_blobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waiting_for_extract_blobs.Image = global::LogoRecognitionSystem.Properties.Resources.icons8_dots_loading;
            this.waiting_for_extract_blobs.Location = new System.Drawing.Point(237, 24);
            this.waiting_for_extract_blobs.Name = "waiting_for_extract_blobs";
            this.waiting_for_extract_blobs.Size = new System.Drawing.Size(143, 48);
            this.waiting_for_extract_blobs.TabIndex = 14;
            this.waiting_for_extract_blobs.UseVisualStyleBackColor = false;
            this.waiting_for_extract_blobs.Visible = false;
            // 
            // docu_pb
            // 
            this.docu_pb.BackColor = System.Drawing.Color.White;
            this.docu_pb.Cursor = System.Windows.Forms.Cursors.Cross;
            this.docu_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docu_pb.Location = new System.Drawing.Point(1, 1);
            this.docu_pb.Name = "docu_pb";
            this.docu_pb.Size = new System.Drawing.Size(621, 696);
            this.docu_pb.TabIndex = 0;
            this.docu_pb.Mouse_Up += new System.Windows.Forms.MouseEventHandler(this.Image_pictureBox_MouseUp);
            this.docu_pb.Mouse_Move += new System.Windows.Forms.MouseEventHandler(this.Image_pictureBox_MouseMove);
            this.docu_pb.Mouse_Down += new System.Windows.Forms.MouseEventHandler(this.Image_pictureBox_MouseDown);
            this.docu_pb.PaintPB += new System.Windows.Forms.PaintEventHandler(this.Image_pictureBox_Paint);
            // 
            // Extract_Blobs_bgw
            // 
            this.Extract_Blobs_bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Extract_Blobs_bgw_DoWork);
            // 
            // Snip_Images
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 934);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Snip_Images";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snip_Images";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sniped_img_pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Label current_selected_image;
        private Button next_btn;
        private Button last_btn;
        private Panel panel3;
        private PictureBox sniped_img_pictureBox;
        private Button load_img_button;
        private Panel panel2;
        private ComboBox ideal_set_cb;
        private TextBox Image_name_tb;
        private Label label4;
        private Button Export_button;
        private Button extract_blobs;
        private Button waiting_for_extract_blobs;
        private System.ComponentModel.BackgroundWorker Extract_Blobs_bgw;
        private ZoomableImage docu_pb;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel posion_label;
    }
}