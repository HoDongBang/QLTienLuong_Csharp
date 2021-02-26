using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace baocaodoan1
{
    public partial class frmXuatPL : Form
    {
        public frmXuatPL()
        {
            InitializeComponent();
        }

        private void FrmXuatPL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyNhanVienDataSet3.PHIEULUONG' table. You can move, or remove it, as needed.
            this.PHIEULUONGTableAdapter.Fill(this.QuanLyNhanVienDataSet3.PHIEULUONG);
            DateTime today = DateTime.Now;
            dateTimePickerThoiGianXPL.Value = new DateTime(today.Year, today.Month, 1);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        KetNoiDuLieu c = new KetNoiDuLieu();
        private void BtnXuatPL_Click(object sender, EventArgs e)
        {
            string[] ngaythangnam = dateTimePickerThoiGianXPL.Value.ToString().Split('/');
            //Khai báo câu lệnh SQL
            String sql = "SELECT MaNV,MaPL,TongSTien,NgayPhat,Thang,Nam from PHIEULUONG" +
                        " where Thang='"+ngaythangnam[1]+ "' AND Nam='" + ngaythangnam[2].Substring(0, 4) + "'";
            //Truyền vào chuỗi kết nối tới cơ sở dữ liệu
            //Gọi Application.StartupPath để lấy đường dẫn tới thư mục chứa file chạy chương trình 
            c.connect();
            SqlDataAdapter adp = new SqlDataAdapter(sql, c.conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);          
            //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            //Đường dẫn báo cáo
            reportViewer1.LocalReport.ReportPath = "Report3.rdlc";
            //Nếu có dữ liệu
            if (ds.Tables[0].Rows.Count > 0)
            {
                //Tạo nguồn dữ liệu cho báo cáo
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "DataSet3";
                rds.Value = ds.Tables[0];
                //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                reportViewer1.LocalReport.DataSources.Clear();
                //Add dữ liệu vào báo cáo
                reportViewer1.LocalReport.DataSources.Add(rds);
                //Refresh lại báo cáo
                reportViewer1.RefreshReport();
            }
            c.disconnect();
        }
    }
}
