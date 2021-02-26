namespace baocaodoan1
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonTTMPB = new System.Windows.Forms.RadioButton();
            this.radioButtonTTMTDHV = new System.Windows.Forms.RadioButton();
            this.radioButtonTTMCV = new System.Windows.Forms.RadioButton();
            this.radioButtonTTMNV = new System.Windows.Forms.RadioButton();
            this.btnTimTheoMaNV = new System.Windows.Forms.Button();
            this.txtTimKiemNV = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnSuaNV = new System.Windows.Forms.Button();
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoaDuLieuNV = new System.Windows.Forms.Button();
            this.comboBoxChucVuNV = new System.Windows.Forms.ComboBox();
            this.comboBoxChuyenMonNV = new System.Windows.Forms.ComboBox();
            this.comboBoxTDHVNV = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxPhongBanNV = new System.Windows.Forms.ComboBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radioButtonNam = new System.Windows.Forms.RadioButton();
            this.radioButtonNu = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(18, 9);
            this.dataGridViewNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(928, 325);
            this.dataGridViewNhanVien.TabIndex = 0;
            this.dataGridViewNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewNhanVien_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Honeydew;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.btnTimTheoMaNV);
            this.groupBox2.Controls.Add(this.txtTimKiemNV);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox2.Location = new System.Drawing.Point(18, 342);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 165);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonTTMPB);
            this.panel2.Controls.Add(this.radioButtonTTMTDHV);
            this.panel2.Controls.Add(this.radioButtonTTMCV);
            this.panel2.Controls.Add(this.radioButtonTTMNV);
            this.panel2.Location = new System.Drawing.Point(6, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 78);
            this.panel2.TabIndex = 37;
            // 
            // radioButtonTTMPB
            // 
            this.radioButtonTTMPB.AutoSize = true;
            this.radioButtonTTMPB.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTTMPB.Location = new System.Drawing.Point(219, 4);
            this.radioButtonTTMPB.Name = "radioButtonTTMPB";
            this.radioButtonTTMPB.Size = new System.Drawing.Size(194, 24);
            this.radioButtonTTMPB.TabIndex = 36;
            this.radioButtonTTMPB.Text = "Tìm theo mã phòng ban";
            this.radioButtonTTMPB.UseVisualStyleBackColor = true;
            // 
            // radioButtonTTMTDHV
            // 
            this.radioButtonTTMTDHV.AutoSize = true;
            this.radioButtonTTMTDHV.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTTMTDHV.Location = new System.Drawing.Point(219, 43);
            this.radioButtonTTMTDHV.Name = "radioButtonTTMTDHV";
            this.radioButtonTTMTDHV.Size = new System.Drawing.Size(230, 24);
            this.radioButtonTTMTDHV.TabIndex = 36;
            this.radioButtonTTMTDHV.Text = "Tìm theo mã trình độ học vấn";
            this.radioButtonTTMTDHV.UseVisualStyleBackColor = true;
            // 
            // radioButtonTTMCV
            // 
            this.radioButtonTTMCV.AutoSize = true;
            this.radioButtonTTMCV.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTTMCV.Location = new System.Drawing.Point(9, 43);
            this.radioButtonTTMCV.Name = "radioButtonTTMCV";
            this.radioButtonTTMCV.Size = new System.Drawing.Size(172, 24);
            this.radioButtonTTMCV.TabIndex = 36;
            this.radioButtonTTMCV.Text = "Tìm theo mã chức vụ";
            this.radioButtonTTMCV.UseVisualStyleBackColor = true;
            // 
            // radioButtonTTMNV
            // 
            this.radioButtonTTMNV.AutoSize = true;
            this.radioButtonTTMNV.Checked = true;
            this.radioButtonTTMNV.ForeColor = System.Drawing.Color.Black;
            this.radioButtonTTMNV.Location = new System.Drawing.Point(9, 5);
            this.radioButtonTTMNV.Name = "radioButtonTTMNV";
            this.radioButtonTTMNV.Size = new System.Drawing.Size(186, 24);
            this.radioButtonTTMNV.TabIndex = 36;
            this.radioButtonTTMNV.TabStop = true;
            this.radioButtonTTMNV.Text = "Tìm theo mã nhân viên";
            this.radioButtonTTMNV.UseVisualStyleBackColor = true;
            // 
            // btnTimTheoMaNV
            // 
            this.btnTimTheoMaNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimTheoMaNV.BackgroundImage")));
            this.btnTimTheoMaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimTheoMaNV.ForeColor = System.Drawing.Color.Black;
            this.btnTimTheoMaNV.ImageKey = "(none)";
            this.btnTimTheoMaNV.Location = new System.Drawing.Point(296, 25);
            this.btnTimTheoMaNV.Name = "btnTimTheoMaNV";
            this.btnTimTheoMaNV.Size = new System.Drawing.Size(146, 46);
            this.btnTimTheoMaNV.TabIndex = 1;
            this.btnTimTheoMaNV.Text = "Tìm kiếm";
            this.btnTimTheoMaNV.UseVisualStyleBackColor = true;
            this.btnTimTheoMaNV.Click += new System.EventHandler(this.BtnTimTheoMaNV_Click);
            // 
            // txtTimKiemNV
            // 
            this.txtTimKiemNV.Location = new System.Drawing.Point(15, 35);
            this.txtTimKiemNV.Name = "txtTimKiemNV";
            this.txtTimKiemNV.Size = new System.Drawing.Size(253, 26);
            this.txtTimKiemNV.TabIndex = 0;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThemNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemNV.BackgroundImage")));
            this.btnThemNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemNV.Location = new System.Drawing.Point(580, 373);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(140, 45);
            this.btnThemNV.TabIndex = 3;
            this.btnThemNV.Text = "Thêm";
            this.btnThemNV.UseVisualStyleBackColor = false;
            this.btnThemNV.Click += new System.EventHandler(this.BtnThemNV_Click);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSuaNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaNV.BackgroundImage")));
            this.btnSuaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaNV.Location = new System.Drawing.Point(580, 446);
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.Size = new System.Drawing.Size(140, 45);
            this.btnSuaNV.TabIndex = 3;
            this.btnSuaNV.Text = "Sửa";
            this.btnSuaNV.UseVisualStyleBackColor = false;
            this.btnSuaNV.Click += new System.EventHandler(this.BtnSuaNV_Click);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaNV.BackgroundImage")));
            this.btnXoaNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaNV.Location = new System.Drawing.Point(777, 373);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(140, 45);
            this.btnXoaNV.TabIndex = 3;
            this.btnXoaNV.Text = "Xóa";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            this.btnXoaNV.Click += new System.EventHandler(this.BtnXoaNV_Click);
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(622, 534);
            this.txtDienThoai.MaxLength = 10;
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(247, 26);
            this.txtDienThoai.TabIndex = 37;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(132, 688);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(250, 26);
            this.txtDiaChi.TabIndex = 32;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(132, 569);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(250, 26);
            this.txtHoTen.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 694);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Trình độ học vấn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 656);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Chuyên môn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "Chức vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Phòng ban:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 694);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 656);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Họ và tên:";
            // 
            // lblMaNV
            // 
            this.lblMaNV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMaNV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaNV.Location = new System.Drawing.Point(132, 526);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(250, 35);
            this.lblMaNV.TabIndex = 29;
            this.lblMaNV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaNV.TextChanged += new System.EventHandler(this.LblMaNV_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 541);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã nhân viên:";
            // 
            // btnXoaDuLieuNV
            // 
            this.btnXoaDuLieuNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaDuLieuNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDuLieuNV.BackgroundImage")));
            this.btnXoaDuLieuNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaDuLieuNV.Location = new System.Drawing.Point(777, 446);
            this.btnXoaDuLieuNV.Name = "btnXoaDuLieuNV";
            this.btnXoaDuLieuNV.Size = new System.Drawing.Size(140, 45);
            this.btnXoaDuLieuNV.TabIndex = 39;
            this.btnXoaDuLieuNV.Text = "Xóa dữ liệu   ";
            this.btnXoaDuLieuNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDuLieuNV.UseVisualStyleBackColor = false;
            this.btnXoaDuLieuNV.Click += new System.EventHandler(this.BtnXoaDuLieuNV_Click);
            // 
            // comboBoxChucVuNV
            // 
            this.comboBoxChucVuNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChucVuNV.FormattingEnabled = true;
            this.comboBoxChucVuNV.Location = new System.Drawing.Point(622, 609);
            this.comboBoxChucVuNV.Name = "comboBoxChucVuNV";
            this.comboBoxChucVuNV.Size = new System.Drawing.Size(247, 28);
            this.comboBoxChucVuNV.TabIndex = 40;
            // 
            // comboBoxChuyenMonNV
            // 
            this.comboBoxChuyenMonNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChuyenMonNV.FormattingEnabled = true;
            this.comboBoxChuyenMonNV.Location = new System.Drawing.Point(622, 648);
            this.comboBoxChuyenMonNV.Name = "comboBoxChuyenMonNV";
            this.comboBoxChuyenMonNV.Size = new System.Drawing.Size(247, 28);
            this.comboBoxChuyenMonNV.TabIndex = 40;
            // 
            // comboBoxTDHVNV
            // 
            this.comboBoxTDHVNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTDHVNV.FormattingEnabled = true;
            this.comboBoxTDHVNV.Location = new System.Drawing.Point(622, 686);
            this.comboBoxTDHVNV.Name = "comboBoxTDHVNV";
            this.comboBoxTDHVNV.Size = new System.Drawing.Size(247, 28);
            this.comboBoxTDHVNV.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 617);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 41;
            this.label10.Text = "Phái:";
            // 
            // comboBoxPhongBanNV
            // 
            this.comboBoxPhongBanNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhongBanNV.FormattingEnabled = true;
            this.comboBoxPhongBanNV.Location = new System.Drawing.Point(622, 567);
            this.comboBoxPhongBanNV.Name = "comboBoxPhongBanNV";
            this.comboBoxPhongBanNV.Size = new System.Drawing.Size(247, 28);
            this.comboBoxPhongBanNV.TabIndex = 43;
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(132, 650);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(250, 26);
            this.dateTimePickerNgaySinh.TabIndex = 44;
            // 
            // radioButtonNam
            // 
            this.radioButtonNam.AutoSize = true;
            this.radioButtonNam.Checked = true;
            this.radioButtonNam.Location = new System.Drawing.Point(14, 5);
            this.radioButtonNam.Name = "radioButtonNam";
            this.radioButtonNam.Size = new System.Drawing.Size(60, 24);
            this.radioButtonNam.TabIndex = 45;
            this.radioButtonNam.TabStop = true;
            this.radioButtonNam.Text = "Nam";
            this.radioButtonNam.UseVisualStyleBackColor = true;
            // 
            // radioButtonNu
            // 
            this.radioButtonNu.AutoSize = true;
            this.radioButtonNu.Location = new System.Drawing.Point(128, 5);
            this.radioButtonNu.Name = "radioButtonNu";
            this.radioButtonNu.Size = new System.Drawing.Size(47, 24);
            this.radioButtonNu.TabIndex = 45;
            this.radioButtonNu.Text = "Nữ";
            this.radioButtonNu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonNu);
            this.panel1.Controls.Add(this.radioButtonNam);
            this.panel1.Location = new System.Drawing.Point(132, 603);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 36);
            this.panel1.TabIndex = 46;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePickerNgaySinh);
            this.Controls.Add(this.comboBoxPhongBanNV);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxTDHVNV);
            this.Controls.Add(this.comboBoxChuyenMonNV);
            this.Controls.Add(this.comboBoxChucVuNV);
            this.Controls.Add(this.btnXoaDuLieuNV);
            this.Controls.Add(this.txtDienThoai);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.btnSuaNV);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridViewNhanVien);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmNhanVien";
            this.Text = "NHÂN VIÊN";
            this.Load += new System.EventHandler(this.FrmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTimTheoMaNV;
        private System.Windows.Forms.TextBox txtTimKiemNV;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnSuaNV;
        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaDuLieuNV;
        private System.Windows.Forms.ComboBox comboBoxChucVuNV;
        private System.Windows.Forms.ComboBox comboBoxChuyenMonNV;
        private System.Windows.Forms.ComboBox comboBoxTDHVNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxPhongBanNV;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.RadioButton radioButtonTTMTDHV;
        private System.Windows.Forms.RadioButton radioButtonTTMPB;
        private System.Windows.Forms.RadioButton radioButtonTTMCV;
        private System.Windows.Forms.RadioButton radioButtonTTMNV;
        private System.Windows.Forms.RadioButton radioButtonNam;
        private System.Windows.Forms.RadioButton radioButtonNu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}