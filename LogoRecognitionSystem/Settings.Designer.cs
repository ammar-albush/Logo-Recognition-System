namespace LogoRecognitionSystem
{
    partial class Settings
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
            this.label7 = new System.Windows.Forms.Label();
            this.save_sss_btn = new System.Windows.Forms.Button();
            this.Filter_Cb = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maxHei_num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.minWid_num = new System.Windows.Forms.NumericUpDown();
            this.minHei_num = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maxWid_num = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.baseK_num = new System.Windows.Forms.NumericUpDown();
            this.incrK_num = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHei_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minWid_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHei_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWid_num)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseK_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incrK_num)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.save_sss_btn);
            this.panel1.Controls.Add(this.Filter_Cb);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 503);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(54, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Image Filter  : ";
            // 
            // save_sss_btn
            // 
            this.save_sss_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.save_sss_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.save_sss_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.save_sss_btn.Location = new System.Drawing.Point(544, 407);
            this.save_sss_btn.Name = "save_sss_btn";
            this.save_sss_btn.Size = new System.Drawing.Size(157, 49);
            this.save_sss_btn.TabIndex = 11;
            this.save_sss_btn.Text = "Save";
            this.save_sss_btn.UseVisualStyleBackColor = false;
            this.save_sss_btn.Click += new System.EventHandler(this.save_sss_btn_Click);
            // 
            // Filter_Cb
            // 
            this.Filter_Cb.FormattingEnabled = true;
            this.Filter_Cb.Location = new System.Drawing.Point(193, 327);
            this.Filter_Cb.Name = "Filter_Cb";
            this.Filter_Cb.Size = new System.Drawing.Size(190, 23);
            this.Filter_Cb.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.maxHei_num);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.minWid_num);
            this.groupBox4.Controls.Add(this.minHei_num);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.maxWid_num);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox4.Location = new System.Drawing.Point(31, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(670, 166);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "To Extract Image Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(375, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Maximal Height : ";
            // 
            // maxHei_num
            // 
            this.maxHei_num.Location = new System.Drawing.Point(539, 109);
            this.maxHei_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxHei_num.Name = "maxHei_num";
            this.maxHei_num.Size = new System.Drawing.Size(108, 23);
            this.maxHei_num.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Minimal Width  : ";
            // 
            // minWid_num
            // 
            this.minWid_num.Location = new System.Drawing.Point(198, 48);
            this.minWid_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minWid_num.Name = "minWid_num";
            this.minWid_num.Size = new System.Drawing.Size(108, 23);
            this.minWid_num.TabIndex = 13;
            // 
            // minHei_num
            // 
            this.minHei_num.Location = new System.Drawing.Point(539, 49);
            this.minHei_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minHei_num.Name = "minHei_num";
            this.minHei_num.Size = new System.Drawing.Size(108, 23);
            this.minHei_num.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Maximal Width  : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(375, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Minimal Height : ";
            // 
            // maxWid_num
            // 
            this.maxWid_num.Location = new System.Drawing.Point(198, 99);
            this.maxWid_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxWid_num.Name = "maxWid_num";
            this.maxWid_num.Size = new System.Drawing.Size(108, 23);
            this.maxWid_num.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.baseK_num);
            this.groupBox1.Controls.Add(this.incrK_num);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 81);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selective Search";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(34, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "base( k ) : ";
            // 
            // baseK_num
            // 
            this.baseK_num.Location = new System.Drawing.Point(198, 33);
            this.baseK_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.baseK_num.Name = "baseK_num";
            this.baseK_num.Size = new System.Drawing.Size(108, 23);
            this.baseK_num.TabIndex = 19;
            // 
            // incrK_num
            // 
            this.incrK_num.Location = new System.Drawing.Point(546, 33);
            this.incrK_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.incrK_num.Name = "incrK_num";
            this.incrK_num.Size = new System.Drawing.Size(108, 23);
            this.incrK_num.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(375, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Increment( k ) : ";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 503);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxHei_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minWid_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minHei_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxWid_num)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseK_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incrK_num)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown minWid_num;
        private NumericUpDown minHei_num;
        private Label label3;
        private NumericUpDown maxWid_num;
        private Label label2;
        private NumericUpDown maxHei_num;
        private Label label4;
        private GroupBox groupBox4;
        private Label label5;
        private NumericUpDown baseK_num;
        private NumericUpDown incrK_num;
        private Label label6;
        private Label label7;
        private Button save_sss_btn;
        private ComboBox Filter_Cb;
    }
}