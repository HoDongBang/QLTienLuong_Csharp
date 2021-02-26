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
    public partial class frmDSKTKL : Form
    {
        public frmDSKTKL()
        {
            InitializeComponent();
        }



        KetNoiDuLieu c = new KetNoiDuLieu();
        string sql = "select Thang AS N'Tháng',Nam AS N'Năm',KTKL.MaKTKL AS N'Mã khen thưởng - kỉ luật',TenKTKL AS N'Tên khen thưởng - kỉ luật'," +
            " NHANVIEN.MaNV AS N'Mã nhân viên',HoTen AS N'Tên nhân viên',HinhThuc AS N'Hình thức',SoTien AS N'Số tiền'" +
            " from KTKL_NHANVIEN inner join NHANVIEN on KTKL_NHANVIEN.MaNV=NHANVIEN.MaNV inner join KTKL on" +
            " KTKL_NHANVIEN.MaKTKL=KTKL.MaKTKL";
        string sqlkt = "select Thang AS N'Tháng',Nam AS N'Năm',KTKL.MaKTKL AS N'Mã khen thưởng - kỉ luật',TenKTKL AS N'Tên khen thưởng - kỉ luật'," +
            " NHANVIEN.MaNV AS N'Mã nhân viên',HoTen AS N'Tên nhân viên',HinhThuc AS N'Hình thức',SoTien AS N'Số tiền'" +
            " from KTKL_NHANVIEN inner join NHANVIEN on KTKL_NHANVIEN.MaNV=NHANVIEN.MaNV inner join KTKL on" +
            " KTKL_NHANVIEN.MaKTKL=KTKL.MaKTKL where KTKL.MaKTKL like 'KT%' ";
        string sqlkl = "select Thang AS N'Tháng',Nam AS N'Năm',KTKL.MaKTKL AS N'Mã khen thưởng - kỉ luật',TenKTKL AS N'Tên khen thưởng - kỉ luật'," +
            " NHANVIEN.MaNV AS N'Mã nhân viên',HoTen AS N'Tên nhân viên',HinhThuc AS N'Hình thức',SoTien AS N'Số tiền'" +
            " from KTKL_NHANVIEN inner join NHANVIEN on KTKL_NHANVIEN.MaNV=NHANVIEN.MaNV inner join KTKL on" +
            " KTKL_NHANVIEN.MaKTKL=KTKL.MaKTKL where KTKL.MaKTKL like 'KL%'";

        public void Loaddata(string sql)
        {
            try
            {
                c.connect();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, c.conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewDSKTKL.DataSource = tb;
                dataGridViewDSKTKL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewDSKTKL.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb.Dispose();
                adapter.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void FrmDSKTKL_Load(object sender, EventArgs e)
        {
            Loaddata(sql);

            c.connect();
            string sqlKTKL = "select*from KTKL";
            string sqlNHANVIEN = "select*from NHANVIEN";
          
            SqlDataAdapter adapter1 = new SqlDataAdapter(sqlKTKL, c.conn);
            DataTable tb1 = new DataTable();
            adapter1.Fill(tb1);
            adapter1.Dispose();
            comboBoxMaDSKTKL.DataSource = tb1;
            comboBoxMaDSKTKL.DisplayMember = "MaKTKL";
            comboBoxMaDSKTKL.ValueMember = "MaKTKL";

            SqlDataAdapter adapter2 = new SqlDataAdapter(sqlNHANVIEN, c.conn);
            DataTable tb2 = new DataTable();
            adapter2.Fill(tb2);
            adapter2.Dispose();
            comboBoxMaNVDSKTKL.DataSource = tb2;
            comboBoxMaNVDSKTKL.DisplayMember = "MaNV";
            comboBoxMaNVDSKTKL.ValueMember = "MaNV";


            c.disconnect();
        }

        private void DataGridViewDSKTKL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string thang = dataGridViewDSKTKL.CurrentRow.Cells[0].Value.ToString();
            string nam = dataGridViewDSKTKL.CurrentRow.Cells[1].Value.ToString();

            dateTimePickerThoiGian.Value = new DateTime(int.Parse(nam), int.Parse(thang), 1);
            comboBoxMaDSKTKL.Text = dataGridViewDSKTKL.CurrentRow.Cells[2].Value.ToString();
            comboBoxMaNVDSKTKL.Text = dataGridViewDSKTKL.CurrentRow.Cells[4].Value.ToString();               
        }

        private void RadioButtonDSKTKL_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDSKTKL.Checked)
                Loaddata(sql);
        }

        private void RadioButtonDSKT_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDSKT.Checked)
                Loaddata(sqlkt);
        }

        private void RadioButtonDSKL_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDSKL.Checked)
                Loaddata(sqlkl);
        }

        private void BtnThemDSKTKL_Click(object sender, EventArgs e)
        {
            comboBoxMaDSKTKL.ValueMember = "MaKTKL";
            comboBoxMaNVDSKTKL.ValueMember = "MaNV";
            string[] ngaythangnam = dateTimePickerThoiGian.Value.ToString().Split('/');
            c.connect();
            string sql2 = "select *from KTKL_NHANVIEN" +
                        " where MaKTKL='"+comboBoxMaDSKTKL.SelectedValue+ "' AND" +
                        " MaNV='" + comboBoxMaNVDSKTKL.SelectedValue + "' AND" +
                        " Thang='" + ngaythangnam[1] + "' AND Nam='" + ngaythangnam[2].Substring(0, 4) + "'";
            SqlCommand cmd = new SqlCommand(sql2, c.conn);
            SqlDataReader docdata = cmd.ExecuteReader();

            //nếu đọc thành công thì mã đã tồn tại
            if (docdata.Read())
            {
                docdata.Close();
                docdata.Dispose();
                c.disconnect();
                MessageBox.Show("Dữ liệu đã tồn tại không cần thêm nữa!");
            }
            else
            {
                docdata.Close();
                docdata.Dispose();
                string sql3 = "insert into KTKL_NHANVIEN values('" + comboBoxMaDSKTKL.SelectedValue + "','" + comboBoxMaNVDSKTKL.SelectedValue + "','" + ngaythangnam[1] + "','" + ngaythangnam[2].Substring(0, 4) + "')";
                SqlCommand cmd3 = new SqlCommand(sql3, c.conn);
                int kq = (int)cmd3.ExecuteNonQuery();//trả về số cột đc thêm
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    c.disconnect();
                    Loaddata(sql);
                    if (radioButtonDSKL.Checked == true)
                        Loaddata(sql);
                    if (radioButtonDSKT.Checked == true)
                        Loaddata(sqlkt);
                    if (radioButtonDSKL.Checked == true)
                        Loaddata(sqlkl);
                }
                else
                {
                    c.disconnect();
                    MessageBox.Show("Thêm thất bại!");
                }               
                cmd3.Dispose();
            }
        }

        private void BtnXoaDSKTKL_Click(object sender, EventArgs e)
        {
            comboBoxMaDSKTKL.ValueMember = "MaKTKL";
            comboBoxMaNVDSKTKL.ValueMember = "MaNV";
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                c.connect();
                string[] ngaythangnam = dateTimePickerThoiGian.Value.ToString().Split('/');
                string sql2 = "delete from KTKL_NHANVIEN  where MaKTKL='" + comboBoxMaDSKTKL.SelectedValue + "' AND" +
                    " MaNV='" + comboBoxMaNVDSKTKL.SelectedValue + "' AND" +
                    " Thang='" + ngaythangnam[1] + "' AND Nam='" + ngaythangnam[2].Substring(0, 4) + "'";
                SqlCommand cmd = new SqlCommand(sql2, c.conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Xóa thành công!");
                c.disconnect();
                Loaddata(sql);
                if (radioButtonDSKL.Checked==true)
                    Loaddata(sql);
                if (radioButtonDSKT.Checked == true)
                    Loaddata(sqlkt);
                if (radioButtonDSKL.Checked == true)
                    Loaddata(sqlkl);
            }
        }

        private void ComboBoxMaDSKTKL_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaDSKTKL.ValueMember = "TenKTKL";
            lblTenDSKTKL.Text = comboBoxMaDSKTKL.SelectedValue.ToString();
            comboBoxMaDSKTKL.ValueMember = "HinhThuc";
            lblHinhThucDSKTKL.Text = comboBoxMaDSKTKL.SelectedValue.ToString();
            comboBoxMaDSKTKL.ValueMember = "SoTien";
            lblSoTienDSKTKL.Text = comboBoxMaDSKTKL.SelectedValue.ToString();
        }

        private void ComboBoxMaNVDSKTKL_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMaNVDSKTKL.ValueMember = "HoTen";
            lblTenNVDSKTKL.Text = comboBoxMaNVDSKTKL.SelectedValue.ToString();
        }
    }
}
