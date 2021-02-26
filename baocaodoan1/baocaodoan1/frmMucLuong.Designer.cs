namespace baocaodoan1
{
    partial class frmMucLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMucLuong));
            this.dataGridViewMucLuong = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaDuLieuML = new System.Windows.Forms.Button();
            this.btnXoaML = new System.Windows.Forms.Button();
            this.btnSuaML = new System.Windows.Forms.Button();
            this.btnThemML = new System.Windows.Forms.Button();
            this.txtSoTienML = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaML = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMucLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMucLuong
            // 
            this.dataGridViewMucLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMucLuong.Location = new System.Drawing.Point(9, 12);
            this.dataGridViewMucLuong.Name = "dataGridViewMucLuong";
            this.dataGridViewMucLuong.Size = new System.Drawing.Size(266, 348);
            this.dataGridViewMucLuong.TabIndex = 30;
            this.dataGridViewMucLuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMucLuong_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblMaML);
            this.groupBox1.Controls.Add(this.btnXoaDuLieuML);
            this.groupBox1.Controls.Add(this.btnXoaML);
            this.groupBox1.Controls.Add(this.btnSuaML);
            this.groupBox1.Controls.Add(this.btnThemML);
            this.groupBox1.Controls.Add(this.txtSoTienML);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(290, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 348);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin mức lương";
            // 
            // btnXoaDuLieuML
            // 
            this.btnXoaDuLieuML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaDuLieuML.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDuLieuML.BackgroundImage")));
            this.btnXoaDuLieuML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaDuLieuML.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDuLieuML.Location = new System.Drawing.Point(209, 204);
            this.btnXoaDuLieuML.Name = "btnXoaDuLieuML";
            this.btnXoaDuLieuML.Size = new System.Drawing.Size(140, 45);
            this.btnXoaDuLieuML.TabIndex = 41;
            this.btnXoaDuLieuML.Text = "Xóa dữ liệu   ";
            this.btnXoaDuLieuML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaDuLieuML.UseVisualStyleBackColor = false;
            this.btnXoaDuLieuML.Click += new System.EventHandler(this.BtnXoaDuLieuML_Click);
            // 
            // btnXoaML
            // 
            this.btnXoaML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaML.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaML.BackgroundImage")));
            this.btnXoaML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaML.ForeColor = System.Drawing.Color.Black;
            this.btnXoaML.Location = new System.Drawing.Point(211, 280);
            this.btnXoaML.Name = "btnXoaML";
            this.btnXoaML.Size = new System.Drawing.Size(138, 48);
            this.btnXoaML.TabIndex = 27;
            this.btnXoaML.Text = "Xóa";
            this.btnXoaML.UseVisualStyleBackColor = false;
            this.btnXoaML.Click += new System.EventHandler(this.BtnXoaML_Click);
            // 
            // btnSuaML
            // 
            this.btnSuaML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSuaML.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaML.BackgroundImage")));
            this.btnSuaML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaML.ForeColor = System.Drawing.Color.Black;
            this.btnSuaML.Location = new System.Drawing.Point(35, 280);
            this.btnSuaML.Name = "btnSuaML";
            this.btnSuaML.Size = new System.Drawing.Size(138, 48);
            this.btnSuaML.TabIndex = 28;
            this.btnSuaML.Text = "Sửa";
            this.btnSuaML.UseVisualStyleBackColor = false;
            this.btnSuaML.Click += new System.EventHandler(this.BtnSuaML_Click);
            // 
            // btnThemML
            // 
            this.btnThemML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThemML.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemML.BackgroundImage")));
            this.btnThemML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemML.ForeColor = System.Drawing.Color.Black;
            this.btnThemML.Location = new System.Drawing.Point(35, 204);
            this.btnThemML.Name = "btnThemML";
            this.btnThemML.Size = new System.Drawing.Size(138, 48);
            this.btnThemML.TabIndex = 29;
            this.btnThemML.Text = "Thêm";
            this.btnThemML.UseVisualStyleBackColor = false;
            this.btnThemML.Click += new System.EventHandler(this.BtnThemML_Click);
            // 
            // txtSoTienML
            // 
            this.txtSoTienML.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtSoTienML.Location = new System.Drawing.Point(144, 120);
            this.txtSoTienML.Name = "txtSoTienML";
            this.txtSoTienML.Size = new System.Drawing.Size(232, 26);
            this.txtSoTienML.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã mức lương:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Số tiền:";
            // 
            // lblMaML
            // 
            this.lblMaML.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMaML.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaML.ForeColor = System.Drawing.Color.Black;
            this.lblMaML.Location = new System.Drawing.Point(144, 51);
            this.lblMaML.Name = "lblMaML";
            this.lblMaML.Size = new System.Drawing.Size(232, 35);
            this.lblMaML.TabIndex = 42;
            this.lblMaML.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaML.TextChanged += new System.EventHandler(this.LblMaML_TextChanged);
            // 
            // frmMucLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 378);
            this.Controls.Add(this.dataGridViewMucLuong);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMucLuong";
            this.Text = "MỨC LƯƠNG";
            this.Load += new System.EventHandler(this.FrmMucLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMucLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMucLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaML;
        private System.Windows.Forms.Button btnSuaML;
        private System.Windows.Forms.Button btnThemML;
        private System.Windows.Forms.TextBox txtSoTienML;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaDuLieuML;
        private System.Windows.Forms.Label lblMaML;
    }
}