namespace baocaodoan1
{
    partial class frmXuatPL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatPL));
            this.PHIEULUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyNhanVienDataSet3 = new baocaodoan1.QuanLyNhanVienDataSet3();
            this.btnXuatPL = new System.Windows.Forms.Button();
            this.dateTimePickerThoiGianXPL = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PHIEULUONGTableAdapter = new baocaodoan1.QuanLyNhanVienDataSet3TableAdapters.PHIEULUONGTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.PHIEULUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNhanVienDataSet3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PHIEULUONGBindingSource
            // 
            this.PHIEULUONGBindingSource.DataMember = "PHIEULUONG";
            this.PHIEULUONGBindingSource.DataSource = this.QuanLyNhanVienDataSet3;
            // 
            // QuanLyNhanVienDataSet3
            // 
            this.QuanLyNhanVienDataSet3.DataSetName = "QuanLyNhanVienDataSet3";
            this.QuanLyNhanVienDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnXuatPL
            // 
            this.btnXuatPL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXuatPL.Location = new System.Drawing.Point(435, 17);
            this.btnXuatPL.Name = "btnXuatPL";
            this.btnXuatPL.Size = new System.Drawing.Size(126, 39);
            this.btnXuatPL.TabIndex = 0;
            this.btnXuatPL.Text = "Xuất";
            this.btnXuatPL.UseVisualStyleBackColor = false;
            this.btnXuatPL.Click += new System.EventHandler(this.BtnXuatPL_Click);
            // 
            // dateTimePickerThoiGianXPL
            // 
            this.dateTimePickerThoiGianXPL.CustomFormat = "MM/yyyy";
            this.dateTimePickerThoiGianXPL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerThoiGianXPL.Location = new System.Drawing.Point(287, 30);
            this.dateTimePickerThoiGianXPL.Name = "dateTimePickerThoiGianXPL";
            this.dateTimePickerThoiGianXPL.Size = new System.Drawing.Size(120, 26);
            this.dateTimePickerThoiGianXPL.TabIndex = 46;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewer1);
            this.groupBox1.Location = new System.Drawing.Point(2, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 361);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hiển thị";
            // 
            // PHIEULUONGTableAdapter
            // 
            this.PHIEULUONGTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 22);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(772, 336);
            this.reportViewer1.TabIndex = 0;
            // 
            // frmXuatPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 437);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerThoiGianXPL);
            this.Controls.Add(this.btnXuatPL);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmXuatPL";
            this.Text = "XUẤT PHIẾU LƯƠNG";
            this.Load += new System.EventHandler(this.FrmXuatPL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PHIEULUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNhanVienDataSet3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXuatPL;
        private System.Windows.Forms.DateTimePicker dateTimePickerThoiGianXPL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource PHIEULUONGBindingSource;
        private QuanLyNhanVienDataSet3 QuanLyNhanVienDataSet3;
        private QuanLyNhanVienDataSet3TableAdapters.PHIEULUONGTableAdapter PHIEULUONGTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}