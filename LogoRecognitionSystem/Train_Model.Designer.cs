namespace LogoRecognitionSystem
{
    partial class Train_Model
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Model_name_textBox = new System.Windows.Forms.TextBox();
            this.Export_Model_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.d_acc_rb = new System.Windows.Forms.RadioButton();
            this.d_lo_rb = new System.Windows.Forms.RadioButton();
            this.d_tex_rb = new System.Windows.Forms.RadioButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.log_textBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.loss_formsPlot = new ScottPlot.FormsPlot();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.acc_formsPlot = new ScottPlot.FormsPlot();
            this.Epoches_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.start_learning_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Add_image_btn = new System.Windows.Forms.Button();
            this.Snip_Image_button = new System.Windows.Forms.Button();
            this.to_Train_Images_dataGridView = new System.Windows.Forms.DataGridView();
            this.Image_name_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image_match_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image_col = new System.Windows.Forms.DataGridViewImageColumn();
            this.image_delet = new System.Windows.Forms.DataGridViewImageColumn();
            this.Load_Prepared_Dataset_button = new System.Windows.Forms.Button();
            this.Save_Dataset_button = new System.Windows.Forms.Button();
            this.Learn_bgw = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Epoches_numericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.to_Train_Images_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 931);
            this.panel1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.Model_name_textBox);
            this.groupBox3.Controls.Add(this.Export_Model_button);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(31, 816);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(846, 96);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Model ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 12;
            this.label2.Text = "Model Name : ";
            // 
            // Model_name_textBox
            // 
            this.Model_name_textBox.Location = new System.Drawing.Point(198, 37);
            this.Model_name_textBox.Name = "Model_name_textBox";
            this.Model_name_textBox.Size = new System.Drawing.Size(182, 23);
            this.Model_name_textBox.TabIndex = 13;
            // 
            // Export_Model_button
            // 
            this.Export_Model_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.Export_Model_button.Enabled = false;
            this.Export_Model_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Export_Model_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Export_Model_button.Location = new System.Drawing.Point(630, 26);
            this.Export_Model_button.Name = "Export_Model_button";
            this.Export_Model_button.Size = new System.Drawing.Size(157, 49);
            this.Export_Model_button.TabIndex = 11;
            this.Export_Model_button.Text = "Export Model";
            this.Export_Model_button.UseVisualStyleBackColor = false;
            this.Export_Model_button.Click += new System.EventHandler(this.Export_Model_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.Epoches_numericUpDown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.start_learning_button);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox2.Location = new System.Drawing.Point(31, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 378);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Learning Process";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(321, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "Progress :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.d_acc_rb);
            this.panel2.Controls.Add(this.d_lo_rb);
            this.panel2.Controls.Add(this.d_tex_rb);
            this.panel2.Location = new System.Drawing.Point(26, 148);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(157, 197);
            this.panel2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Display : ";
            // 
            // d_acc_rb
            // 
            this.d_acc_rb.AutoSize = true;
            this.d_acc_rb.Location = new System.Drawing.Point(28, 150);
            this.d_acc_rb.Name = "d_acc_rb";
            this.d_acc_rb.Size = new System.Drawing.Size(108, 19);
            this.d_acc_rb.TabIndex = 2;
            this.d_acc_rb.TabStop = true;
            this.d_acc_rb.Text = "Accuracy Chart";
            this.d_acc_rb.UseVisualStyleBackColor = true;
            this.d_acc_rb.CheckedChanged += new System.EventHandler(this.d_acc_rb_CheckedChanged);
            // 
            // d_lo_rb
            // 
            this.d_lo_rb.AutoSize = true;
            this.d_lo_rb.Location = new System.Drawing.Point(28, 98);
            this.d_lo_rb.Name = "d_lo_rb";
            this.d_lo_rb.Size = new System.Drawing.Size(81, 19);
            this.d_lo_rb.TabIndex = 1;
            this.d_lo_rb.TabStop = true;
            this.d_lo_rb.Text = "Loss Chart";
            this.d_lo_rb.UseVisualStyleBackColor = true;
            this.d_lo_rb.CheckedChanged += new System.EventHandler(this.d_lo_rb_CheckedChanged);
            // 
            // d_tex_rb
            // 
            this.d_tex_rb.AutoSize = true;
            this.d_tex_rb.Checked = true;
            this.d_tex_rb.Location = new System.Drawing.Point(28, 54);
            this.d_tex_rb.Name = "d_tex_rb";
            this.d_tex_rb.Size = new System.Drawing.Size(50, 19);
            this.d_tex_rb.TabIndex = 0;
            this.d_tex_rb.TabStop = true;
            this.d_tex_rb.Text = "Text";
            this.d_tex_rb.UseVisualStyleBackColor = true;
            this.d_tex_rb.CheckedChanged += new System.EventHandler(this.d_tex_rb_CheckedChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(423, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(375, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl1.Location = new System.Drawing.Point(189, 91);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(613, 254);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.log_textBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(605, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // log_textBox
            // 
            this.log_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_textBox.Location = new System.Drawing.Point(3, 3);
            this.log_textBox.Multiline = true;
            this.log_textBox.Name = "log_textBox";
            this.log_textBox.ReadOnly = true;
            this.log_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.log_textBox.Size = new System.Drawing.Size(599, 239);
            this.log_textBox.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.loss_formsPlot);
            this.tabPage2.Location = new System.Drawing.Point(4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(605, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // loss_formsPlot
            // 
            this.loss_formsPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loss_formsPlot.Location = new System.Drawing.Point(3, 3);
            this.loss_formsPlot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loss_formsPlot.Name = "loss_formsPlot";
            this.loss_formsPlot.Size = new System.Drawing.Size(599, 239);
            this.loss_formsPlot.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.acc_formsPlot);
            this.tabPage3.Location = new System.Drawing.Point(4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(605, 245);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // acc_formsPlot
            // 
            this.acc_formsPlot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acc_formsPlot.Location = new System.Drawing.Point(0, 0);
            this.acc_formsPlot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.acc_formsPlot.Name = "acc_formsPlot";
            this.acc_formsPlot.Size = new System.Drawing.Size(605, 245);
            this.acc_formsPlot.TabIndex = 0;
            // 
            // Epoches_numericUpDown
            // 
            this.Epoches_numericUpDown.Location = new System.Drawing.Point(198, 43);
            this.Epoches_numericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Epoches_numericUpDown.Name = "Epoches_numericUpDown";
            this.Epoches_numericUpDown.Size = new System.Drawing.Size(108, 23);
            this.Epoches_numericUpDown.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Epoches : ";
            // 
            // start_learning_button
            // 
            this.start_learning_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124)))));
            this.start_learning_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.start_learning_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.start_learning_button.Location = new System.Drawing.Point(26, 91);
            this.start_learning_button.Name = "start_learning_button";
            this.start_learning_button.Size = new System.Drawing.Size(157, 49);
            this.start_learning_button.TabIndex = 8;
            this.start_learning_button.Text = "Start Learning";
            this.start_learning_button.UseVisualStyleBackColor = false;
            this.start_learning_button.Click += new System.EventHandler(this.start_learning_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Add_image_btn);
            this.groupBox1.Controls.Add(this.Snip_Image_button);
            this.groupBox1.Controls.Add(this.to_Train_Images_dataGridView);
            this.groupBox1.Controls.Add(this.Load_Prepared_Dataset_button);
            this.groupBox1.Controls.Add(this.Save_Dataset_button);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 389);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dataset";
            // 
            // Add_image_btn
            // 
            this.Add_image_btn.BackColor = System.Drawing.Color.MediumOrchid;
            this.Add_image_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Add_image_btn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Add_image_btn.Location = new System.Drawing.Point(43, 95);
            this.Add_image_btn.Name = "Add_image_btn";
            this.Add_image_btn.Size = new System.Drawing.Size(157, 49);
            this.Add_image_btn.TabIndex = 6;
            this.Add_image_btn.Text = "Add Image";
            this.Add_image_btn.UseVisualStyleBackColor = false;
            this.Add_image_btn.Click += new System.EventHandler(this.Add_image_btn_Click);
            // 
            // Snip_Image_button
            // 
            this.Snip_Image_button.BackColor = System.Drawing.Color.DarkCyan;
            this.Snip_Image_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Snip_Image_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Snip_Image_button.Location = new System.Drawing.Point(43, 27);
            this.Snip_Image_button.Name = "Snip_Image_button";
            this.Snip_Image_button.Size = new System.Drawing.Size(157, 49);
            this.Snip_Image_button.TabIndex = 0;
            this.Snip_Image_button.Text = "Snip Image ";
            this.Snip_Image_button.UseVisualStyleBackColor = false;
            this.Snip_Image_button.Click += new System.EventHandler(this.add_image_button_Click);
            // 
            // to_Train_Images_dataGridView
            // 
            this.to_Train_Images_dataGridView.AllowUserToAddRows = false;
            this.to_Train_Images_dataGridView.AllowUserToDeleteRows = false;
            this.to_Train_Images_dataGridView.AllowUserToOrderColumns = true;
            this.to_Train_Images_dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.to_Train_Images_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.to_Train_Images_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.to_Train_Images_dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.to_Train_Images_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.to_Train_Images_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image_name_col,
            this.Image_match_col,
            this.Image_col,
            this.image_delet});
            this.to_Train_Images_dataGridView.Location = new System.Drawing.Point(222, 27);
            this.to_Train_Images_dataGridView.Name = "to_Train_Images_dataGridView";
            this.to_Train_Images_dataGridView.ReadOnly = true;
            this.to_Train_Images_dataGridView.RowHeadersVisible = false;
            this.to_Train_Images_dataGridView.RowTemplate.Height = 25;
            this.to_Train_Images_dataGridView.Size = new System.Drawing.Size(589, 276);
            this.to_Train_Images_dataGridView.TabIndex = 2;
            this.to_Train_Images_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.to_Train_Images_dataGridView_CellContentClick);
            this.to_Train_Images_dataGridView.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.to_Train_Images_dataGridView_CellMouseMove);
            // 
            // Image_name_col
            // 
            this.Image_name_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image_name_col.HeaderText = "Name";
            this.Image_name_col.Name = "Image_name_col";
            this.Image_name_col.ReadOnly = true;
            // 
            // Image_match_col
            // 
            this.Image_match_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image_match_col.HeaderText = "Match";
            this.Image_match_col.Name = "Image_match_col";
            this.Image_match_col.ReadOnly = true;
            // 
            // Image_col
            // 
            this.Image_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Image_col.HeaderText = "Image";
            this.Image_col.Name = "Image_col";
            this.Image_col.ReadOnly = true;
            // 
            // image_delet
            // 
            this.image_delet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.image_delet.HeaderText = "Delete";
            this.image_delet.Image = global::LogoRecognitionSystem.Properties.Resources.icons8_eingekreistes_x_24;
            this.image_delet.Name = "image_delet";
            this.image_delet.ReadOnly = true;
            // 
            // Load_Prepared_Dataset_button
            // 
            this.Load_Prepared_Dataset_button.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Load_Prepared_Dataset_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Load_Prepared_Dataset_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Load_Prepared_Dataset_button.Location = new System.Drawing.Point(43, 167);
            this.Load_Prepared_Dataset_button.Name = "Load_Prepared_Dataset_button";
            this.Load_Prepared_Dataset_button.Size = new System.Drawing.Size(157, 49);
            this.Load_Prepared_Dataset_button.TabIndex = 4;
            this.Load_Prepared_Dataset_button.Text = "Load Prepared Dataset";
            this.Load_Prepared_Dataset_button.UseVisualStyleBackColor = false;
            this.Load_Prepared_Dataset_button.Click += new System.EventHandler(this.Load_Train_Data_Click);
            // 
            // Save_Dataset_button
            // 
            this.Save_Dataset_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Save_Dataset_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Save_Dataset_button.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Save_Dataset_button.Location = new System.Drawing.Point(654, 319);
            this.Save_Dataset_button.Name = "Save_Dataset_button";
            this.Save_Dataset_button.Size = new System.Drawing.Size(157, 49);
            this.Save_Dataset_button.TabIndex = 5;
            this.Save_Dataset_button.Text = "Save Dataset ";
            this.Save_Dataset_button.UseVisualStyleBackColor = false;
            this.Save_Dataset_button.Click += new System.EventHandler(this.Save_Train_Data_Click);
            // 
            // Learn_bgw
            // 
            this.Learn_bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Learn_bgw_DoWork);
            // 
            // Train_Model
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 931);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Train_Model";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "´´";
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Epoches_numericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.to_Train_Images_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox Model_name_textBox;
        private Button Export_Model_button;
        private GroupBox groupBox2;
        private NumericUpDown Epoches_numericUpDown;
        private Label label1;
        private Button start_learning_button;
        private GroupBox groupBox1;
        private Button Snip_Image_button;
        public DataGridView to_Train_Images_dataGridView;
        private Button Load_Prepared_Dataset_button;
        private Button Save_Dataset_button;
        private DataGridViewTextBoxColumn Image_name_col;
        private DataGridViewTextBoxColumn Image_match_col;
        private DataGridViewImageColumn Image_col;
        private DataGridViewImageColumn image_delet;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox log_textBox;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ProgressBar progressBar1;
        private Panel panel2;
        private Label label3;
        private RadioButton d_acc_rb;
        private RadioButton d_lo_rb;
        private RadioButton d_tex_rb;
        private Label label4;
        private System.ComponentModel.BackgroundWorker Learn_bgw;
        private ScottPlot.FormsPlot loss_formsPlot;
        private ScottPlot.FormsPlot acc_formsPlot;
        private Button Add_image_btn;
    }
}