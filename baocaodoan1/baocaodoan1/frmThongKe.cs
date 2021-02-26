using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baocaodoan1
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyNhanVienDataSet.View_TongTien' table. You can move, or remove it, as needed.
            this.View_TongTienTableAdapter.Fill(this.QuanLyNhanVienDataSet.View_TongTien);
            // TODO: This line of code loads data into the 'QuanLyNhanVienDataSet1.view_KTKLNV' table. You can move, or remove it, as needed.
            this.view_KTKLNVTableAdapter.Fill(this.QuanLyNhanVienDataSet1.view_KTKLNV);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
