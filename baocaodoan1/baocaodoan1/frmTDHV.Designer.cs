namespace baocaodoan1
{
    partial class frmTDHV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTDHV));
            this.dataGridViewTDHV = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaDuLieuTDHV = new System.Windows.Forms.Button();
            this.btnSuaTDHV = new System.Windows.Forms.Button();
            this.btnThemTDHV = new System.Windows.Forms.Button();
            this.txtTenTDHV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaTDHV = new System.Windows.Forms.Button();
            this.lblMaTDHV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTDHV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTDHV
            // 
            this.dataGridViewTDHV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTDHV.Location = new System.Drawing.Point(12, 10);
            this.dataGridViewTDHV.Name = "dataGridViewTDHV";
            this.dataGridViewTDHV.Size = new System.Drawing.Size(389, 330);
            this.dataGridViewTDHV.TabIndex = 34;
            this.dataGridViewTDHV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTDHV_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblMaTDHV);
            this.groupBox1.Controls.Add(this.btnXoaTDHV);
            this.groupBox1.Controls.Add(this.btnXoaDuLieuTDHV);
            this.groupBox1.Controls.Add(this.btnSuaTDHV);
            this.groupBox1.Controls.Add(this.btnThemTDHV);
            this.groupBox1.Controls.Add(this.txtTenTDHV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(417, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 330);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin trình độ học vấn";
            // 
            // btnXoaDuLieuTDHV
            // 
            this.btnXoaDuLieuTDHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaDuLieuTDHV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaDuLieuTDHV.BackgroundImage")));
            this.btnXoaDuLieuTDHV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaDuLieuTDHV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDuLieuTDHV.Location = new System.Drawing.Point(168, 207);
            this.btnXoaDuLieuTDHV.Name = "btnXoaDuLieuTDHV";
            this.btnXoaDuLieuTDHV.Size = new System.Drawing.Size(135, 45);
            this.btnXoaDuLieuTDHV.TabIndex = 27;
            this.btnXoaDuLieuTDHV.Text = "     Xóa dữ liệu";
            this.btnXoaDuLieuTDHV.UseVisualStyleBackColor = false;
            this.btnXoaDuLieuTDHV.Click += new System.EventHandler(this.BtnXoaDuLieuTDHV_Click);
            // 
            // btnSuaTDHV
            // 
            this.btnSuaTDHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSuaTDHV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaTDHV.BackgroundImage")));
            this.btnSuaTDHV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuaTDHV.ForeColor = System.Drawing.Color.Black;
            this.btnSuaTDHV.Location = new System.Drawing.Point(14, 269);
            this.btnSuaTDHV.Name = "btnSuaTDHV";
            this.btnSuaTDHV.Size = new System.Drawing.Size(135, 45);
            this.btnSuaTDHV.TabIndex = 28;
            this.btnSuaTDHV.Text = "Sửa";
            this.btnSuaTDHV.UseVisualStyleBackColor = false;
            this.btnSuaTDHV.Click += new System.EventHandler(this.BtnSuaTDHV_Click);
            // 
            // btnThemTDHV
            // 
            this.btnThemTDHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThemTDHV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemTDHV.BackgroundImage")));
            this.btnThemTDHV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThemTDHV.ForeColor = System.Drawing.Color.Black;
            this.btnThemTDHV.Location = new System.Drawing.Point(14, 207);
            this.btnThemTDHV.Name = "btnThemTDHV";
            this.btnThemTDHV.Size = new System.Drawing.Size(135, 45);
            this.btnThemTDHV.TabIndex = 29;
            this.btnThemTDHV.Text = "Thêm";
            this.btnThemTDHV.UseVisualStyleBackColor = false;
            this.btnThemTDHV.Click += new System.EventHandler(this.BtnThemTDHV_Click);
            // 
            // txtTenTDHV
            // 
            this.txtTenTDHV.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtTenTDHV.Location = new System.Drawing.Point(35, 160);
            this.txtTenTDHV.Name = "txtTenTDHV";
            this.txtTenTDHV.Size = new System.Drawing.Size(249, 26);
            this.txtTenTDHV.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Mã trình độ học vấn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tên trình độ học vấn:";
            // 
            // btnXoaTDHV
            // 
            this.btnXoaTDHV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoaTDHV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaTDHV.BackgroundImage")));
            this.btnXoaTDHV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoaTDHV.ForeColor = System.Drawing.Color.Black;
            this.btnXoaTDHV.Location = new System.Drawing.Point(168, 269);
            this.btnXoaTDHV.Name = "btnXoaTDHV";
            this.btnXoaTDHV.Size = new System.Drawing.Size(135, 45);
            this.btnXoaTDHV.TabIndex = 30;
            this.btnXoaTDHV.Text = "Xóa";
            this.btnXoaTDHV.UseVisualStyleBackColor = false;
            this.btnXoaTDHV.Click += new System.EventHandler(this.BtnXoaTDHV_Click);
            // 
            // lblMaTDHV
            // 
            this.lblMaTDHV.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMaTDHV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMaTDHV.ForeColor = System.Drawing.Color.Black;
            this.lblMaTDHV.Location = new System.Drawing.Point(35, 75);
            this.lblMaTDHV.Name = "lblMaTDHV";
            this.lblMaTDHV.Size = new System.Drawing.Size(249, 35);
            this.lblMaTDHV.TabIndex = 43;
            this.lblMaTDHV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaTDHV.TextChanged += new System.EventHandler(this.LblMaTDHV_TextChanged);
            // 
            // frmTDHV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 352);
            this.Controls.Add(this.dataGridViewTDHV);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTDHV";
            this.Text = "TRÌNH ĐỘ HỌC VẤN";
            this.Load += new System.EventHandler(this.FrmTDHV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTDHV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTDHV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoaDuLieuTDHV;
        private System.Windows.Forms.Button btnSuaTDHV;
        private System.Windows.Forms.Button btnThemTDHV;
        private System.Windows.Forms.TextBox txtTenTDHV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnXoaTDHV;
        private System.Windows.Forms.Label lblMaTDHV;
    }
}