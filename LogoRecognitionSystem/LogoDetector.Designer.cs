namespace LogoRecognitionSystem
{
    partial class LogoDetector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogoDetector));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Predict_btn = new System.Windows.Forms.Button();
            this.current_selected_image = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prdict_tb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.snipd_img = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Train_new_model_Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Models_toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.reload_tsb = new System.Windows.Forms.ToolStripButton();
            this.settings_tsb = new System.Windows.Forms.ToolStripButton();
            this.load_img_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loading_btn = new System.Windows.Forms.Button();
            this.docu_pb = new System.Windows.Forms.PictureBox();
            this.Predict_bgw = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.prdict_value_tb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.snipd_img)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.docu_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.prdict_value_tb);
            this.panel1.Controls.Add(this.Predict_btn);
            this.panel1.Controls.Add(this.current_selected_image);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.prdict_tb);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.load_img_button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1110, 991);
            this.panel1.TabIndex = 0;
            // 
            // Predict_btn
            // 
            this.Predict_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.Predict_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Predict_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Predict_btn.Location = new System.Drawing.Point(496, 930);
            this.Predict_btn.Name = "Predict_btn";
            this.Predict_btn.Size = new System.Drawing.Size(157, 49);
            this.Predict_btn.TabIndex = 16;
            this.Predict_btn.Text = "Predict";
            this.Predict_btn.UseVisualStyleBackColor = false;
            this.Predict_btn.Click += new System.EventHandler(this.Predict_btn_Click);
            // 
            // current_selected_image
            // 
            this.current_selected_image.AutoSize = true;
            this.current_selected_image.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.current_selected_image.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.current_selected_image.Location = new System.Drawing.Point(863, 140);
            this.current_selected_image.Name = "current_selected_image";
            this.current_selected_image.Size = new System.Drawing.Size(39, 25);
            this.current_selected_image.TabIndex = 15;
            this.current_selected_image.Text = "0/0";
            this.current_selected_image.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(813, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Network Say : ";
            // 
            // prdict_tb
            // 
            this.prdict_tb.Location = new System.Drawing.Point(686, 452);
            this.prdict_tb.Name = "prdict_tb";
            this.prdict_tb.Size = new System.Drawing.Size(397, 23);
            this.prdict_tb.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Image = global::LogoRecognitionSystem.Properties.Resources.icons8_eingekreistes_rangabzeichen_rechts_32;
            this.button1.Location = new System.Drawing.Point(1015, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 59);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.next_button_Click);
            // 
            // button2
            // 
            this.button2.Image = global::LogoRecognitionSystem.Properties.Resources.icons8_eingekreistes_rangabzeichen_links_32;
            this.button2.Location = new System.Drawing.Point(688, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 59);
            this.button2.TabIndex = 11;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.back_button_Click);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.snipd_img);
            this.panel4.Location = new System.Drawing.Point(686, 188);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(397, 199);
            this.panel4.TabIndex = 10;
            // 
            // snipd_img
            // 
            this.snipd_img.BackColor = System.Drawing.Color.White;
            this.snipd_img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snipd_img.Location = new System.Drawing.Point(2, 2);
            this.snipd_img.Name = "snipd_img";
            this.snipd_img.Size = new System.Drawing.Size(393, 195);
            this.snipd_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.snipd_img.TabIndex = 0;
            this.snipd_img.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Train_new_model_Button,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.Models_toolStripComboBox,
            this.reload_tsb,
            this.settings_tsb});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1110, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Train_new_model_Button
            // 
            this.Train_new_model_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Train_new_model_Button.Image = ((System.Drawing.Image)(resources.GetObject("Train_new_model_Button.Image")));
            this.Train_new_model_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Train_new_model_Button.Name = "Train_new_model_Button";
            this.Train_new_model_Button.Size = new System.Drawing.Size(100, 22);
            this.Train_new_model_Button.Text = "Train New Model";
            this.Train_new_model_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Train_new_model_Button.Click += new System.EventHandler(this.Train_new_model_Button_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(50, 22);
            this.toolStripLabel1.Text = "Model : ";
            // 
            // Models_toolStripComboBox
            // 
            this.Models_toolStripComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Models_toolStripComboBox.Name = "Models_toolStripComboBox";
            this.Models_toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.Models_toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.Models_toolStripComboBox_SelectedIndexChanged);
            // 
            // reload_tsb
            // 
            this.reload_tsb.Image = global::LogoRecognitionSystem.Properties.Resources.icons8_neustart_32;
            this.reload_tsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.reload_tsb.Name = "reload_tsb";
            this.reload_tsb.Size = new System.Drawing.Size(30, 22);
            this.reload_tsb.Text = " ";
            this.reload_tsb.Click += new System.EventHandler(this.reload_tsb_Click);
            // 
            // settings_tsb
            // 
            this.settings_tsb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settings_tsb.Image = global::LogoRecognitionSystem.Properties.Resources.icons8_einstellungen_32;
            this.settings_tsb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settings_tsb.Name = "settings_tsb";
            this.settings_tsb.Size = new System.Drawing.Size(69, 22);
            this.settings_tsb.Text = "Settings";
            this.settings_tsb.Click += new System.EventHandler(this.settings_tsb_Click);
            // 
            // load_img_button
            // 
            this.load_img_button.BackColor = System.Drawing.Color.DarkCyan;
            this.load_img_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.load_img_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.load_img_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.load_img_button.ForeColor = System.Drawing.Color.White;
            this.load_img_button.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.load_img_button.Location = new System.Drawing.Point(248, 48);
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
            this.panel2.Controls.Add(this.loading_btn);
            this.panel2.Controls.Add(this.docu_pb);
            this.panel2.Location = new System.Drawing.Point(31, 124);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(623, 798);
            this.panel2.TabIndex = 0;
            // 
            // loading_btn
            // 
            this.loading_btn.BackColor = System.Drawing.Color.White;
            this.loading_btn.FlatAppearance.BorderSize = 0;
            this.loading_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.loading_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.loading_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loading_btn.Image = global::LogoRecognitionSystem.Properties.Resources.icons8_dots_loading;
            this.loading_btn.Location = new System.Drawing.Point(265, 17);
            this.loading_btn.Name = "loading_btn";
            this.loading_btn.Size = new System.Drawing.Size(75, 23);
            this.loading_btn.TabIndex = 17;
            this.loading_btn.UseVisualStyleBackColor = false;
            this.loading_btn.Visible = false;
            // 
            // docu_pb
            // 
            this.docu_pb.BackColor = System.Drawing.Color.White;
            this.docu_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.docu_pb.Location = new System.Drawing.Point(1, 1);
            this.docu_pb.Name = "docu_pb";
            this.docu_pb.Size = new System.Drawing.Size(621, 796);
            this.docu_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.docu_pb.TabIndex = 1;
            this.docu_pb.TabStop = false;
            // 
            // Predict_bgw
            // 
            this.Predict_bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Predict_bgw_DoWork);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(839, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Value :";
            // 
            // prdict_value_tb
            // 
            this.prdict_value_tb.Location = new System.Drawing.Point(686, 551);
            this.prdict_value_tb.Name = "prdict_value_tb";
            this.prdict_value_tb.Size = new System.Drawing.Size(397, 23);
            this.prdict_value_tb.TabIndex = 17;
            // 
            // LogoDetector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 991);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogoDetector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logo Detector";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.snipd_img)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.docu_pb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button load_img_button;
        private Panel panel2;
        private ToolStrip toolStrip1;
        private ToolStripButton Train_new_model_Button;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripLabel toolStripLabel1;
        public ToolStripComboBox Models_toolStripComboBox;
        private PictureBox docu_pb;
        private ToolStripButton reload_tsb;
        private Label label1;
        private TextBox prdict_tb;
        private Button button1;
        private Button button2;
        private Panel panel4;
        private PictureBox snipd_img;
        private Label current_selected_image;
        private Button Predict_btn;
        private System.ComponentModel.BackgroundWorker Predict_bgw;
        private Button loading_btn;
        private ToolStripButton settings_tsb;
        private Label label2;
        private TextBox prdict_value_tb;
    }
}