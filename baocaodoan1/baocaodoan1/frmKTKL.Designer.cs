namespace baocaodoan1
{
    partial class frmKTKL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKTKL));
            this.dataGridViewKTKL = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaKTKL = new System.Windows.Forms.TextBox();
            this.btnXoaDuLieuTDHV = new System.Windows.Forms.Button();
            this.txtSoTienKTKL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHinhThuc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoaKTKL = new System.Windows.Forms.Button();
            this.btnSuaKTKL = new System.Windows.Forms.Button();
            this.btnThemKTKL = new System.Windows.Forms.Button();
            this.txtTenKTKL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKTKL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewKTKL
            // 
            this.dataGridViewKTKL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKTKL.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewKTKL.Name = "dataGridViewKTKL";
            this.dataGridViewKTKL.Size = new System.Drawing.Size(603, 360);
            this.dataGridViewKTKL.TabIndex = 32;
            this.dataGridViewKTKL.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewKTKL_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtMaKTKL);
            this.groupBox1.Controls.Add(this.btnXoaDuLieuTDHV);
            this.groupBox1.Controls.Add(this.txtSoTienKTKL);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtHinhThuc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnXoaKTKL);
            this.groupBox1.Controls.Add(this.btnSuaKTKL);
            this.groupBox1.Controls.Add(this.btnThemKTKL);
            this.groupBox1.Controls.Add(this.txtTenKTKL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(634, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 360);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khen thưởng - kỉ luật";
            // 
            // txtMaKTKL
            // 
            this.txtMaKTKL.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMaKTKL.Location = new System.Drawing.Point(111, 49);
            this.txtMaKTKL.MaxLength = 4;
            this.txtMaKTKL.Name = "txtMaKTKL";
            this.txtMaKTKL.Size = new System.Drawing.Size(232, 26);
            this.txtMaKTKL.TabIndex = 35;
            // 
            // btnXoaDuLieuTDHV
            // 
            this.btnXoaDuLieuTDHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaDuLieuTDHV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDuLieuTDHV.BackgroundImage")));
            this.btnXoaDuLieuTDHV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaDuLieuTDHV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDuLieuTDHV.Location = new System.Drawing.Point(206, 239);
            this.btnXoaDuLieuTDHV.Name = "btnXoaDuLieuTDHV";
            this.btnXoaDuLieuTDHV.Size = new System.Drawing.Size(135, 45);
            this.btnXoaDuLieuTDHV.TabIndex = 34;
            this.btnXoaDuLieuTDHV.Text = "     Xóa dữ liệu";
            this.btnXoaDuLieuTDHV.UseVisualStyleBackColor = false;
            this.btnXoaDuLieuTDHV.Click += new System.EventHandler(this.BtnXoaDuLieuTDHV_Click);
            // 
            // txtSoTienKTKL
            // 
            this.txtSoTienKTKL.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSoTienKTKL.Location = new System.Drawing.Point(111, 179);
            this.txtSoTienKTKL.Name = "txtSoTienKTKL";
            this.txtSoTienKTKL.Size = new System.Drawing.Size(232, 26);
            this.txtSoTienKTKL.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Hình thức:";
            // 
            // txtHinhThuc
            // 
            this.txtHinhThuc.ForeColor = System.Drawing.Color.Black;
            this.txtHinhThuc.Location = new System.Drawing.Point(111, 134);
            this.txtHinhThuc.Name = "txtHinhThuc";
            this.txtHinhThuc.Size = new System.Drawing.Size(232, 26);
            this.txtHinhThuc.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(18, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Số tiền:";
            // 
            // btnXoaKTKL
            // 
            this.btnXoaKTKL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaKTKL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaKTKL.BackgroundImage")));
            this.btnXoaKTKL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaKTKL.ForeColor = System.Drawing.Color.Black;
            this.btnXoaKTKL.Location = new System.Drawing.Point(206, 300);
            this.btnXoaKTKL.Name = "btnXoaKTKL";
            this.btnXoaKTKL.Size = new System.Drawing.Size(135, 45);
            this.btnXoaKTKL.TabIndex = 27;
            this.btnXoaKTKL.Text = "Xóa";
            this.btnXoaKTKL.UseVisualStyleBackColor = false;
            this.btnXoaKTKL.Click += new System.EventHandler(this.BtnXoaKTKL_Click);
            // 
            // btnSuaKTKL
            // 
            this.btnSuaKTKL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSuaKTKL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaKTKL.BackgroundImage")));
            this.btnSuaKTKL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaKTKL.ForeColor = System.Drawing.Color.Black;
            this.btnSuaKTKL.Location = new System.Drawing.Point(34, 300);
            this.btnSuaKTKL.Name = "btnSuaKTKL";
            this.btnSuaKTKL.Size = new System.Drawing.Size(135, 45);
            this.btnSuaKTKL.TabIndex = 28;
            this.btnSuaKTKL.Text = "Sửa";
            this.btnSuaKTKL.UseVisualStyleBackColor = false;
            this.btnSuaKTKL.Click += new System.EventHandler(this.BtnSuaKTKL_Click);
            // 
            // btnThemKTKL
            // 
            this.btnThemKTKL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThemKTKL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemKTKL.BackgroundImage")));
            this.btnThemKTKL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemKTKL.ForeColor = System.Drawing.Color.Black;
            this.btnThemKTKL.Location = new System.Drawing.Point(34, 239);
            this.btnThemKTKL.Name = "btnThemKTKL";
            this.btnThemKTKL.Size = new System.Drawing.Size(135, 45);
            this.btnThemKTKL.TabIndex = 29;
            this.btnThemKTKL.Text = "Thêm";
            this.btnThemKTKL.UseVisualStyleBackColor = false;
            this.btnThemKTKL.Click += new System.EventHandler(this.BtnThemKTKL_Click);
            // 
            // txtTenKTKL
            // 
            this.txtTenKTKL.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTenKTKL.Location = new System.Drawing.Point(111, 89);
            this.txtTenKTKL.Name = "txtTenKTKL";
            this.txtTenKTKL.Size = new System.Drawing.Size(232, 26);
            this.txtTenKTKL.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã KTKL:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tên KTKL:";
            // 
            // frmKTKL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 389);
            this.Controls.Add(this.dataGridViewKTKL);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmKTKL";
            this.Text = "KHEN THƯỞNG - KỈ LUẬT";
            this.Load += new System.EventHandler(this.FrmKTKL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKTKL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKTKL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoTienKTKL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHinhThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoaKTKL;
        private System.Windows.Forms.Button btnSuaKTKL;
        private System.Windows.Forms.Button btnThemKTKL;
        private System.Windows.Forms.TextBox txtTenKTKL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaDuLieuTDHV;
        private System.Windows.Forms.TextBox txtMaKTKL;
    }
}