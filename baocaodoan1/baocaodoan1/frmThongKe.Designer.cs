namespace baocaodoan1
{
    partial class frmThongKe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyNhanVienDataSet1 = new baocaodoan1.QuanLyNhanVienDataSet1();
            this.view_KTKLNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_KTKLNVTableAdapter = new baocaodoan1.QuanLyNhanVienDataSet1TableAdapters.view_KTKLNVTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyNhanVienDataSet = new baocaodoan1.QuanLyNhanVienDataSet();
            this.View_TongTienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_TongTienTableAdapter = new baocaodoan1.QuanLyNhanVienDataSetTableAdapters.View_TongTienTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNhanVienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_KTKLNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNhanVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_TongTienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(842, 882);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(834, 849);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khen thưởng kỉ luật";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(834, 849);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tổng tiền";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_KTKLNVBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "baocaodoan1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(828, 843);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanLyNhanVienDataSet1
            // 
            this.QuanLyNhanVienDataSet1.DataSetName = "QuanLyNhanVienDataSet1";
            this.QuanLyNhanVienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_KTKLNVBindingSource
            // 
            this.view_KTKLNVBindingSource.DataMember = "view_KTKLNV";
            this.view_KTKLNVBindingSource.DataSource = this.QuanLyNhanVienDataSet1;
            // 
            // view_KTKLNVTableAdapter
            // 
            this.view_KTKLNVTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet";
            reportDataSource2.Value = this.View_TongTienBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "baocaodoan1.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(828, 843);
            this.reportViewer2.TabIndex = 0;
            // 
            // QuanLyNhanVienDataSet
            // 
            this.QuanLyNhanVienDataSet.DataSetName = "QuanLyNhanVienDataSet";
            this.QuanLyNhanVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_TongTienBindingSource
            // 
            this.View_TongTienBindingSource.DataMember = "View_TongTien";
            this.View_TongTienBindingSource.DataSource = this.QuanLyNhanVienDataSet;
            // 
            // View_TongTienTableAdapter
            // 
            this.View_TongTienTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 881);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThongKe";
            this.Text = "THỐNG KÊ";
            this.Load += new System.EventHandler(this.FrmThongKe_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNhanVienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_KTKLNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyNhanVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_TongTienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.BindingSource view_KTKLNVBindingSource;
        private QuanLyNhanVienDataSet1 QuanLyNhanVienDataSet1;
        private QuanLyNhanVienDataSet1TableAdapters.view_KTKLNVTableAdapter view_KTKLNVTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource View_TongTienBindingSource;
        private QuanLyNhanVienDataSet QuanLyNhanVienDataSet;
        private QuanLyNhanVienDataSetTableAdapters.View_TongTienTableAdapter View_TongTienTableAdapter;
    }
}