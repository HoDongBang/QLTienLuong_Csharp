namespace baocaodoan1
{
    partial class frmChuyenMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenMon));
            this.dataGridViewChuyenMon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaCM = new System.Windows.Forms.Button();
            this.btnSuaCM = new System.Windows.Forms.Button();
            this.btnThemCM = new System.Windows.Forms.Button();
            this.txtTenCM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaDuLieuCM = new System.Windows.Forms.Button();
            this.lblMaCM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChuyenMon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewChuyenMon
            // 
            this.dataGridViewChuyenMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChuyenMon.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewChuyenMon.Name = "dataGridViewChuyenMon";
            this.dataGridViewChuyenMon.Size = new System.Drawing.Size(324, 393);
            this.dataGridViewChuyenMon.TabIndex = 32;
            this.dataGridViewChuyenMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewChuyenMon_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblMaCM);
            this.groupBox1.Controls.Add(this.btnXoaDuLieuCM);
            this.groupBox1.Controls.Add(this.btnXoaCM);
            this.groupBox1.Controls.Add(this.btnSuaCM);
            this.groupBox1.Controls.Add(this.btnThemCM);
            this.groupBox1.Controls.Add(this.txtTenCM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(366, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 393);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chuyên môn";
            // 
            // btnXoaCM
            // 
            this.btnXoaCM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaCM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaCM.BackgroundImage")));
            this.btnXoaCM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaCM.ForeColor = System.Drawing.Color.Black;
            this.btnXoaCM.Location = new System.Drawing.Point(235, 316);
            this.btnXoaCM.Name = "btnXoaCM";
            this.btnXoaCM.Size = new System.Drawing.Size(138, 45);
            this.btnXoaCM.TabIndex = 27;
            this.btnXoaCM.Text = "Xóa";
            this.btnXoaCM.UseVisualStyleBackColor = false;
            this.btnXoaCM.Click += new System.EventHandler(this.BtnXoaCM_Click);
            // 
            // btnSuaCM
            // 
            this.btnSuaCM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSuaCM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaCM.BackgroundImage")));
            this.btnSuaCM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaCM.ForeColor = System.Drawing.Color.Black;
            this.btnSuaCM.Location = new System.Drawing.Point(62, 316);
            this.btnSuaCM.Name = "btnSuaCM";
            this.btnSuaCM.Size = new System.Drawing.Size(138, 45);
            this.btnSuaCM.TabIndex = 28;
            this.btnSuaCM.Text = "Sửa";
            this.btnSuaCM.UseVisualStyleBackColor = false;
            this.btnSuaCM.Click += new System.EventHandler(this.BtnSuaCM_Click);
            // 
            // btnThemCM
            // 
            this.btnThemCM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThemCM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemCM.BackgroundImage")));
            this.btnThemCM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemCM.ForeColor = System.Drawing.Color.Black;
            this.btnThemCM.Location = new System.Drawing.Point(62, 237);
            this.btnThemCM.Name = "btnThemCM";
            this.btnThemCM.Size = new System.Drawing.Size(138, 45);
            this.btnThemCM.TabIndex = 29;
            this.btnThemCM.Text = "Thêm";
            this.btnThemCM.UseVisualStyleBackColor = false;
            this.btnThemCM.Click += new System.EventHandler(this.BtnThemCM_Click);
            // 
            // txtTenCM
            // 
            this.txtTenCM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTenCM.Location = new System.Drawing.Point(154, 140);
            this.txtTenCM.Name = "txtTenCM";
            this.txtTenCM.Size = new System.Drawing.Size(259, 26);
            this.txtTenCM.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã chuyên môn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tên chuyên môn:";
            // 
            // btnXoaDuLieuCM
            // 
            this.btnXoaDuLieuCM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaDuLieuCM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDuLieuCM.BackgroundImage")));
            this.btnXoaDuLieuCM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaDuLieuCM.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDuLieuCM.Location = new System.Drawing.Point(235, 237);
            this.btnXoaDuLieuCM.Name = "btnXoaDuLieuCM";
            this.btnXoaDuLieuCM.Size = new System.Drawing.Size(140, 45);
            this.btnXoaDuLieuCM.TabIndex = 42;
            this.btnXoaDuLieuCM.Text = "Xóa dữ liệu   ";
            this.btnXoaDuLieuCM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDuLieuCM.UseVisualStyleBackColor = false;
            this.btnXoaDuLieuCM.Click += new System.EventHandler(this.BtnXoaDuLieuCM_Click);
            // 
            // lblMaCM
            // 
            this.lblMaCM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMaCM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaCM.ForeColor = System.Drawing.Color.Black;
            this.lblMaCM.Location = new System.Drawing.Point(154, 83);
            this.lblMaCM.Name = "lblMaCM";
            this.lblMaCM.Size = new System.Drawing.Size(259, 35);
            this.lblMaCM.TabIndex = 43;
            this.lblMaCM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaCM.TextChanged += new System.EventHandler(this.LblMaCM_TextChanged);
            // 
            // frmChuyenMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 417);
            this.Controls.Add(this.dataGridViewChuyenMon);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChuyenMon";
            this.Text = "CHUYÊN MÔN";
            this.Load += new System.EventHandler(this.FrmChuyenMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChuyenMon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewChuyenMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaCM;
        private System.Windows.Forms.Button btnSuaCM;
        private System.Windows.Forms.Button btnThemCM;
        private System.Windows.Forms.TextBox txtTenCM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaDuLieuCM;
        private System.Windows.Forms.Label lblMaCM;
    }
}