namespace baocaodoan1
{
    partial class frmPhongBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhongBan));
            this.dataGridViewPhongBan = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChiPB = new System.Windows.Forms.TextBox();
            this.btnXoaDuLieuPB = new System.Windows.Forms.Button();
            this.btnXoaPB = new System.Windows.Forms.Button();
            this.btnSuaPB = new System.Windows.Forms.Button();
            this.btnThemPB = new System.Windows.Forms.Button();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenPB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongBan)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPhongBan
            // 
            this.dataGridViewPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhongBan.Location = new System.Drawing.Point(11, 12);
            this.dataGridViewPhongBan.Name = "dataGridViewPhongBan";
            this.dataGridViewPhongBan.Size = new System.Drawing.Size(780, 254);
            this.dataGridViewPhongBan.TabIndex = 30;
            this.dataGridViewPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPhongBan_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDiaChiPB);
            this.groupBox1.Controls.Add(this.btnXoaDuLieuPB);
            this.groupBox1.Controls.Add(this.btnXoaPB);
            this.groupBox1.Controls.Add(this.btnSuaPB);
            this.groupBox1.Controls.Add(this.btnThemPB);
            this.groupBox1.Controls.Add(this.lblMaPB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTenPB);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(11, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 197);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng ban";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(23, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Địa chỉ:";
            // 
            // txtDiaChiPB
            // 
            this.txtDiaChiPB.ForeColor = System.Drawing.Color.Black;
            this.txtDiaChiPB.Location = new System.Drawing.Point(143, 152);
            this.txtDiaChiPB.Name = "txtDiaChiPB";
            this.txtDiaChiPB.Size = new System.Drawing.Size(232, 26);
            this.txtDiaChiPB.TabIndex = 42;
            // 
            // btnXoaDuLieuPB
            // 
            this.btnXoaDuLieuPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaDuLieuPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDuLieuPB.BackgroundImage")));
            this.btnXoaDuLieuPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaDuLieuPB.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDuLieuPB.Location = new System.Drawing.Point(622, 47);
            this.btnXoaDuLieuPB.Name = "btnXoaDuLieuPB";
            this.btnXoaDuLieuPB.Size = new System.Drawing.Size(140, 45);
            this.btnXoaDuLieuPB.TabIndex = 40;
            this.btnXoaDuLieuPB.Text = "Xóa dữ liệu   ";
            this.btnXoaDuLieuPB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDuLieuPB.UseVisualStyleBackColor = false;
            this.btnXoaDuLieuPB.Click += new System.EventHandler(this.BtnXoaDuLieuPB_Click);
            // 
            // btnXoaPB
            // 
            this.btnXoaPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaPB.BackgroundImage")));
            this.btnXoaPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaPB.ForeColor = System.Drawing.Color.Black;
            this.btnXoaPB.Location = new System.Drawing.Point(622, 125);
            this.btnXoaPB.Name = "btnXoaPB";
            this.btnXoaPB.Size = new System.Drawing.Size(140, 45);
            this.btnXoaPB.TabIndex = 27;
            this.btnXoaPB.Text = "Xóa";
            this.btnXoaPB.UseVisualStyleBackColor = false;
            this.btnXoaPB.Click += new System.EventHandler(this.BtnXoaPB_Click);
            // 
            // btnSuaPB
            // 
            this.btnSuaPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSuaPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaPB.BackgroundImage")));
            this.btnSuaPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaPB.ForeColor = System.Drawing.Color.Black;
            this.btnSuaPB.Location = new System.Drawing.Point(423, 125);
            this.btnSuaPB.Name = "btnSuaPB";
            this.btnSuaPB.Size = new System.Drawing.Size(140, 45);
            this.btnSuaPB.TabIndex = 28;
            this.btnSuaPB.Text = "Sửa";
            this.btnSuaPB.UseVisualStyleBackColor = false;
            this.btnSuaPB.Click += new System.EventHandler(this.BtnSuaPB_Click);
            // 
            // btnThemPB
            // 
            this.btnThemPB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThemPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemPB.BackgroundImage")));
            this.btnThemPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemPB.ForeColor = System.Drawing.Color.Black;
            this.btnThemPB.Location = new System.Drawing.Point(423, 47);
            this.btnThemPB.Name = "btnThemPB";
            this.btnThemPB.Size = new System.Drawing.Size(140, 45);
            this.btnThemPB.TabIndex = 29;
            this.btnThemPB.Text = "Thêm";
            this.btnThemPB.UseVisualStyleBackColor = false;
            this.btnThemPB.Click += new System.EventHandler(this.BtnThemPB_Click);
            // 
            // lblMaPB
            // 
            this.lblMaPB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMaPB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaPB.ForeColor = System.Drawing.Color.Black;
            this.lblMaPB.Location = new System.Drawing.Point(144, 44);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(232, 35);
            this.lblMaPB.TabIndex = 26;
            this.lblMaPB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaPB.TextChanged += new System.EventHandler(this.LblMaPB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Mã phòng ban:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên phòng ban:";
            // 
            // txtTenPB
            // 
            this.txtTenPB.ForeColor = System.Drawing.Color.Black;
            this.txtTenPB.Location = new System.Drawing.Point(144, 99);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(232, 26);
            this.txtTenPB.TabIndex = 24;
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 490);
            this.Controls.Add(this.dataGridViewPhongBan);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPhongBan";
            this.Text = "Phòng Ban";
            this.Load += new System.EventHandler(this.FrmPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhongBan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhongBan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaPB;
        private System.Windows.Forms.Button btnSuaPB;
        private System.Windows.Forms.Button btnThemPB;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Button btnXoaDuLieuPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChiPB;
    }
}