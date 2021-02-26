namespace baocaodoan1
{
    partial class frmChucVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChucVu));
            this.txtTroCapCV = new System.Windows.Forms.TextBox();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaCV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMaMLCV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoaDuLieuCV = new System.Windows.Forms.Button();
            this.btnXoaCV = new System.Windows.Forms.Button();
            this.btnSuaCV = new System.Windows.Forms.Button();
            this.btnThemCV = new System.Windows.Forms.Button();
            this.dataGridViewChucVu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTroCapCV
            // 
            this.txtTroCapCV.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTroCapCV.Location = new System.Drawing.Point(144, 191);
            this.txtTroCapCV.Name = "txtTroCapCV";
            this.txtTroCapCV.Size = new System.Drawing.Size(232, 26);
            this.txtTroCapCV.TabIndex = 25;
            // 
            // txtTenCV
            // 
            this.txtTenCV.ForeColor = System.Drawing.Color.Black;
            this.txtTenCV.Location = new System.Drawing.Point(144, 97);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(232, 26);
            this.txtTenCV.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Trợ cấp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(27, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên chức vụ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã chức vụ:";
            // 
            // lblMaCV
            // 
            this.lblMaCV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMaCV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaCV.ForeColor = System.Drawing.Color.Black;
            this.lblMaCV.Location = new System.Drawing.Point(144, 49);
            this.lblMaCV.Name = "lblMaCV";
            this.lblMaCV.Size = new System.Drawing.Size(232, 28);
            this.lblMaCV.TabIndex = 26;
            this.lblMaCV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaCV.TextChanged += new System.EventHandler(this.LblMaCV_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.comboBoxMaMLCV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnXoaDuLieuCV);
            this.groupBox1.Controls.Add(this.btnXoaCV);
            this.groupBox1.Controls.Add(this.btnSuaCV);
            this.groupBox1.Controls.Add(this.btnThemCV);
            this.groupBox1.Controls.Add(this.lblMaCV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTroCapCV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenCV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(545, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 374);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chức vụ";
            // 
            // comboBoxMaMLCV
            // 
            this.comboBoxMaMLCV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaMLCV.FormattingEnabled = true;
            this.comboBoxMaMLCV.Location = new System.Drawing.Point(144, 143);
            this.comboBoxMaMLCV.Name = "comboBoxMaMLCV";
            this.comboBoxMaMLCV.Size = new System.Drawing.Size(232, 28);
            this.comboBoxMaMLCV.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(27, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 44;
            this.label6.Text = "Mã mức lương:";
            // 
            // btnXoaDuLieuCV
            // 
            this.btnXoaDuLieuCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaDuLieuCV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDuLieuCV.BackgroundImage")));
            this.btnXoaDuLieuCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaDuLieuCV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDuLieuCV.Location = new System.Drawing.Point(219, 308);
            this.btnXoaDuLieuCV.Name = "btnXoaDuLieuCV";
            this.btnXoaDuLieuCV.Size = new System.Drawing.Size(141, 52);
            this.btnXoaDuLieuCV.TabIndex = 30;
            this.btnXoaDuLieuCV.Text = "      Xóa dữ liệu";
            this.btnXoaDuLieuCV.UseVisualStyleBackColor = false;
            this.btnXoaDuLieuCV.Click += new System.EventHandler(this.BtnXoaDuLieuCV_Click);
            // 
            // btnXoaCV
            // 
            this.btnXoaCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaCV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaCV.BackgroundImage")));
            this.btnXoaCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaCV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaCV.Location = new System.Drawing.Point(219, 237);
            this.btnXoaCV.Name = "btnXoaCV";
            this.btnXoaCV.Size = new System.Drawing.Size(141, 52);
            this.btnXoaCV.TabIndex = 27;
            this.btnXoaCV.Text = "Xóa";
            this.btnXoaCV.UseVisualStyleBackColor = false;
            this.btnXoaCV.Click += new System.EventHandler(this.BtnXoaCV_Click);
            // 
            // btnSuaCV
            // 
            this.btnSuaCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSuaCV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaCV.BackgroundImage")));
            this.btnSuaCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaCV.ForeColor = System.Drawing.Color.Black;
            this.btnSuaCV.Location = new System.Drawing.Point(35, 308);
            this.btnSuaCV.Name = "btnSuaCV";
            this.btnSuaCV.Size = new System.Drawing.Size(141, 52);
            this.btnSuaCV.TabIndex = 28;
            this.btnSuaCV.Text = "Sửa";
            this.btnSuaCV.UseVisualStyleBackColor = false;
            this.btnSuaCV.Click += new System.EventHandler(this.BtnSuaCV_Click);
            // 
            // btnThemCV
            // 
            this.btnThemCV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThemCV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemCV.BackgroundImage")));
            this.btnThemCV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemCV.ForeColor = System.Drawing.Color.Black;
            this.btnThemCV.Location = new System.Drawing.Point(35, 237);
            this.btnThemCV.Name = "btnThemCV";
            this.btnThemCV.Size = new System.Drawing.Size(141, 52);
            this.btnThemCV.TabIndex = 29;
            this.btnThemCV.Text = "Thêm";
            this.btnThemCV.UseVisualStyleBackColor = false;
            this.btnThemCV.Click += new System.EventHandler(this.BtnThemCV_Click);
            // 
            // dataGridViewChucVu
            // 
            this.dataGridViewChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChucVu.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewChucVu.Name = "dataGridViewChucVu";
            this.dataGridViewChucVu.Size = new System.Drawing.Size(513, 374);
            this.dataGridViewChucVu.TabIndex = 28;
            this.dataGridViewChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewChucVu_CellClick);
            // 
            // frmChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 407);
            this.Controls.Add(this.dataGridViewChucVu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmChucVu";
            this.Text = "CHỨC VỤ";
            this.Load += new System.EventHandler(this.FrmChucVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTroCapCV;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaCV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewChucVu;
        private System.Windows.Forms.Button btnXoaCV;
        private System.Windows.Forms.Button btnSuaCV;
        private System.Windows.Forms.Button btnThemCV;
        private System.Windows.Forms.Button btnXoaDuLieuCV;
        private System.Windows.Forms.ComboBox comboBoxMaMLCV;
        private System.Windows.Forms.Label label6;
    }
}