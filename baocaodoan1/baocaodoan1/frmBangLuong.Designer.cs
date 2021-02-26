namespace baocaodoan1
{
    partial class frmBangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBangLuong));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonTTMCVBLCB = new System.Windows.Forms.RadioButton();
            this.radioButtonTTMPBBLCB = new System.Windows.Forms.RadioButton();
            this.radioButtonTTMNVBLCB = new System.Windows.Forms.RadioButton();
            this.btnTimBLCB = new System.Windows.Forms.Button();
            this.txtTimBLCB = new System.Windows.Forms.TextBox();
            this.dataGridViewBLCB = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBLCB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.radioButtonTTMCVBLCB);
            this.groupBox2.Controls.Add(this.radioButtonTTMPBBLCB);
            this.groupBox2.Controls.Add(this.radioButtonTTMNVBLCB);
            this.groupBox2.Controls.Add(this.btnTimBLCB);
            this.groupBox2.Controls.Add(this.txtTimBLCB);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox2.Location = new System.Drawing.Point(779, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 305);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // radioButtonTTMCVBLCB
            // 
            this.radioButtonTTMCVBLCB.AutoSize = true;
            this.radioButtonTTMCVBLCB.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTTMCVBLCB.Location = new System.Drawing.Point(25, 175);
            this.radioButtonTTMCVBLCB.Name = "radioButtonTTMCVBLCB";
            this.radioButtonTTMCVBLCB.Size = new System.Drawing.Size(172, 24);
            this.radioButtonTTMCVBLCB.TabIndex = 39;
            this.radioButtonTTMCVBLCB.Text = "Tìm theo mã chức vụ";
            this.radioButtonTTMCVBLCB.UseVisualStyleBackColor = true;
            // 
            // radioButtonTTMPBBLCB
            // 
            this.radioButtonTTMPBBLCB.AutoSize = true;
            this.radioButtonTTMPBBLCB.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTTMPBBLCB.Location = new System.Drawing.Point(26, 134);
            this.radioButtonTTMPBBLCB.Name = "radioButtonTTMPBBLCB";
            this.radioButtonTTMPBBLCB.Size = new System.Drawing.Size(194, 24);
            this.radioButtonTTMPBBLCB.TabIndex = 38;
            this.radioButtonTTMPBBLCB.Text = "Tìm theo mã phòng ban";
            this.radioButtonTTMPBBLCB.UseVisualStyleBackColor = true;
            // 
            // radioButtonTTMNVBLCB
            // 
            this.radioButtonTTMNVBLCB.AutoSize = true;
            this.radioButtonTTMNVBLCB.Checked = true;
            this.radioButtonTTMNVBLCB.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTTMNVBLCB.Location = new System.Drawing.Point(26, 95);
            this.radioButtonTTMNVBLCB.Name = "radioButtonTTMNVBLCB";
            this.radioButtonTTMNVBLCB.Size = new System.Drawing.Size(186, 24);
            this.radioButtonTTMNVBLCB.TabIndex = 37;
            this.radioButtonTTMNVBLCB.TabStop = true;
            this.radioButtonTTMNVBLCB.Text = "Tìm theo mã nhân viên";
            this.radioButtonTTMNVBLCB.UseVisualStyleBackColor = true;
            // 
            // btnTimBLCB
            // 
            this.btnTimBLCB.BackColor = System.Drawing.Color.White;
            this.btnTimBLCB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimBLCB.BackgroundImage")));
            this.btnTimBLCB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimBLCB.ForeColor = System.Drawing.Color.Black;
            this.btnTimBLCB.ImageKey = "(none)";
            this.btnTimBLCB.Location = new System.Drawing.Point(36, 237);
            this.btnTimBLCB.Name = "btnTimBLCB";
            this.btnTimBLCB.Size = new System.Drawing.Size(161, 48);
            this.btnTimBLCB.TabIndex = 1;
            this.btnTimBLCB.Text = "Tìm kiếm";
            this.btnTimBLCB.UseVisualStyleBackColor = false;
            this.btnTimBLCB.Click += new System.EventHandler(this.BtnTimBLCB_Click);
            // 
            // txtTimBLCB
            // 
            this.txtTimBLCB.Location = new System.Drawing.Point(26, 51);
            this.txtTimBLCB.Name = "txtTimBLCB";
            this.txtTimBLCB.Size = new System.Drawing.Size(194, 26);
            this.txtTimBLCB.TabIndex = 0;
            // 
            // dataGridViewBLCB
            // 
            this.dataGridViewBLCB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBLCB.Location = new System.Drawing.Point(16, 14);
            this.dataGridViewBLCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewBLCB.Name = "dataGridViewBLCB";
            this.dataGridViewBLCB.Size = new System.Drawing.Size(744, 543);
            this.dataGridViewBLCB.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(806, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmBangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 569);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewBLCB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBangLuong";
            this.Text = "BẢNG LƯƠNG CƠ BẢN";
            this.Load += new System.EventHandler(this.FrmBangLuong_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBLCB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimBLCB;
        private System.Windows.Forms.TextBox txtTimBLCB;
        private System.Windows.Forms.DataGridView dataGridViewBLCB;
        private System.Windows.Forms.RadioButton radioButtonTTMNVBLCB;
        private System.Windows.Forms.RadioButton radioButtonTTMPBBLCB;
        private System.Windows.Forms.RadioButton radioButtonTTMCVBLCB;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}