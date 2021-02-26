namespace baocaodoan1
{
    partial class frmPhieuLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuLuong));
            this.dataGridViewPhieuLuong = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.dataGridViewTNPL = new System.Windows.Forms.DataGridView();
            this.dataGridViewTTT = new System.Windows.Forms.DataGridView();
            this.dateTimePickerTNPL = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuLuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTNPL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTT)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhieuLuong
            // 
            this.dataGridViewPhieuLuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhieuLuong.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewPhieuLuong.Name = "dataGridViewPhieuLuong";
            this.dataGridViewPhieuLuong.Size = new System.Drawing.Size(736, 443);
            this.dataGridViewPhieuLuong.TabIndex = 35;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhat.Location = new System.Drawing.Point(624, 12);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(124, 41);
            this.btnCapNhat.TabIndex = 36;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);
            // 
            // dataGridViewTNPL
            // 
            this.dataGridViewTNPL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTNPL.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewTNPL.Name = "dataGridViewTNPL";
            this.dataGridViewTNPL.Size = new System.Drawing.Size(429, 331);
            this.dataGridViewTNPL.TabIndex = 37;
            this.dataGridViewTNPL.Visible = false;
            // 
            // dataGridViewTTT
            // 
            this.dataGridViewTTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTTT.Location = new System.Drawing.Point(478, 57);
            this.dataGridViewTTT.Name = "dataGridViewTTT";
            this.dataGridViewTTT.Size = new System.Drawing.Size(270, 331);
            this.dataGridViewTTT.TabIndex = 38;
            this.dataGridViewTTT.Visible = false;
            // 
            // dateTimePickerTNPL
            // 
            this.dateTimePickerTNPL.CustomFormat = "MM/yyyy";
            this.dateTimePickerTNPL.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTNPL.Location = new System.Drawing.Point(498, 25);
            this.dateTimePickerTNPL.Name = "dateTimePickerTNPL";
            this.dateTimePickerTNPL.Size = new System.Drawing.Size(120, 26);
            this.dateTimePickerTNPL.TabIndex = 46;
            this.dateTimePickerTNPL.ValueChanged += new System.EventHandler(this.DateTimePickerTNPL_ValueChanged);
            // 
            // frmPhieuLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 512);
            this.Controls.Add(this.dateTimePickerTNPL);
            this.Controls.Add(this.dataGridViewTTT);
            this.Controls.Add(this.dataGridViewTNPL);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.dataGridViewPhieuLuong);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPhieuLuong";
            this.Text = "PHIẾU LƯƠNG";
            this.Load += new System.EventHandler(this.FrmPhieuLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhieuLuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTNPL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTTT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhieuLuong;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridView dataGridViewTNPL;
        private System.Windows.Forms.DataGridView dataGridViewTTT;
        private System.Windows.Forms.DateTimePicker dateTimePickerTNPL;
    }
}