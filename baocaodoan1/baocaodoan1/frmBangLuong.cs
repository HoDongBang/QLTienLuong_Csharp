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

namespace baocaodoan1
{
    public partial class frmBangLuong : Form
    {
        public frmBangLuong()
        {
            InitializeComponent();
        }


        KetNoiDuLieu c = new KetNoiDuLieu();
        string sql = "select MaNV AS N'Mã nhân viên',HoTen AS N'Tên nhân viên',TenPB AS N'Tên phòng ban'," +
                     " TenCV AS N'Tên chức vụ',SoTien AS N'Lương cơ bản'"+
                     "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                     "NHANVIEN.MaCV=CHUCVU.MaCV inner join MUCLUONG on CHUCVU.MaML=MUCLUONG.MaML";

        public void Loaddata(string sql)
        {
            try
            {
                c.connect();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, c.conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewBLCB.DataSource = tb;
                dataGridViewBLCB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewBLCB.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb.Dispose();
                adapter.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void FrmBangLuong_Load(object sender, EventArgs e)
        {
            Loaddata(sql);
        }

        private void BtnTimBLCB_Click(object sender, EventArgs e)
        {
            //nếu ô tìm kiếm k rỗng thì tìm kiếm
            if (txtTimBLCB.Text != "")
            {
                try
                {
                    string sql2 = "";
                    if (radioButtonTTMNVBLCB.Checked)
                        sql2 = "select MaNV AS N'Mã nhân viên',HoTen AS N'Tên nhân viên',TenPB AS N'Tên phòng ban'," +
                               " TenCV AS N'Tên chức vụ',SoTien AS N'Lương cơ bản'" +
                               "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                               "NHANVIEN.MaCV=CHUCVU.MaCV inner join MUCLUONG on CHUCVU.MaML=MUCLUONG.MaML" +
                               " where MaNV='"+txtTimBLCB.Text+"'";
                    if (radioButtonTTMPBBLCB.Checked)
                        sql2 = "select MaNV AS N'Mã nhân viên',HoTen AS N'Tên nhân viên',TenPB AS N'Tên phòng ban'," +
                               " TenCV AS N'Tên chức vụ',SoTien AS N'Lương cơ bản'" +
                               "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                               "NHANVIEN.MaCV=CHUCVU.MaCV inner join MUCLUONG on CHUCVU.MaML=MUCLUONG.MaML" +
                               " where NHANVIEN.MaPB='" + txtTimBLCB.Text + "'";
                    if (radioButtonTTMCVBLCB.Checked)
                        sql2 = "select MaNV AS N'Mã nhân viên',HoTen AS N'Tên nhân viên',TenPB AS N'Tên phòng ban'," +
                               " TenCV AS N'Tên chức vụ',SoTien AS N'Lương cơ bản'" +
                               "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                               "NHANVIEN.MaCV=CHUCVU.MaCV inner join MUCLUONG on CHUCVU.MaML=MUCLUONG.MaML" +
                               " where NHANVIEN.MaCV='" + txtTimBLCB.Text + "'";
                    Loaddata(sql2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            //nếu ô tìm kiếm rỗng thì tìm kiếm tất cả
            else
            {
                Loaddata(sql);
            }
        }
    }
}
