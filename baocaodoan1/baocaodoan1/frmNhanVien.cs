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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }


        KetNoiDuLieu c = new KetNoiDuLieu();
        string sql = "select MaNV AS N'Mã nhân viên',HoTen AS N'Họ tên',Phai AS N'Phái',NgSinh " +
                     "AS N'Ngày sinh',DC AS N'Địa chỉ',DienThoai AS N'Điện thoại',TenPB AS N'Tên phòng ban'," +
                     "TenCV AS N'Tên chức vụ',TenCM AS N'Tên chuyên môn',TenTDHV AS N'Tên trình độ học vấn' " +
                     "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                     "NHANVIEN.MaCV=CHUCVU.MaCV inner join CHUYENMON on NHANVIEN.MaCM=CHUYENMON.MaCM inner join " +
                     "TRINHDOHV on NHANVIEN.MaTDHV=TRINHDOHV.MaTDHV";

        public void Loaddata(string sql)
        {       
            try
            {
                c.connect();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, c.conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewNhanVien.DataSource = tb;
                dataGridViewNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewNhanVien.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb.Dispose();
                adapter.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }


        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            Loaddata(sql);
            dateTimePickerNgaySinh.Value = new DateTime(2000,1,1);

            btnSuaNV.Enabled = false;
            btnXoaNV.Enabled = false;
            btnThemNV.Enabled = true;

            c.connect();
            string sqlPhongBanNV = "select*from PHONGBAN";
            string sqlChucVuNV = "select*from CHUCVU";
            string sqlChuyenMonNV = "select*from CHUYENMON";
            string sqlTDHVNV = "select*from TRINHDOHV";

            SqlDataAdapter adapter1 = new SqlDataAdapter(sqlPhongBanNV, c.conn);
            DataTable tb1 = new DataTable();
            adapter1.Fill(tb1);
            adapter1.Dispose();
            comboBoxPhongBanNV.DataSource = tb1;
            comboBoxPhongBanNV.DisplayMember = "TenPB";
            comboBoxPhongBanNV.ValueMember = "MaPB";

            SqlDataAdapter adapter2 = new SqlDataAdapter(sqlChucVuNV, c.conn);
            DataTable tb2 = new DataTable();
            adapter2.Fill(tb2);
            adapter2.Dispose();
            comboBoxChucVuNV.DataSource = tb2;
            comboBoxChucVuNV.DisplayMember = "TenCV";
            comboBoxChucVuNV.ValueMember = "MaCV";

            SqlDataAdapter adapter3 = new SqlDataAdapter(sqlChuyenMonNV, c.conn);
            DataTable tb3 = new DataTable();
            adapter3.Fill(tb3);
            adapter3.Dispose();
            comboBoxChuyenMonNV.DataSource = tb3;
            comboBoxChuyenMonNV.DisplayMember = "TenCM";
            comboBoxChuyenMonNV.ValueMember = "MaCM";

            SqlDataAdapter adapter4 = new SqlDataAdapter(sqlTDHVNV, c.conn);
            DataTable tb4 = new DataTable();
            adapter4.Fill(tb4);
            adapter4.Dispose();
            comboBoxTDHVNV.DataSource = tb4;
            comboBoxTDHVNV.DisplayMember = "TenTDHV";
            comboBoxTDHVNV.ValueMember = "MaTDHV";

            c.disconnect();
        }


        public bool ktdienthoai(string txt)
        {
            if (txt.Length != 0 && txt.Length != 10)
                return false;
            else return true;
        }
        private void BtnThemNV_Click(object sender, EventArgs e)
        {
            if(txtTimKiemNV.Text!="")
                MessageBox.Show("Vui lòng hiển thị tất cả dữ liệu để có thể thêm mã tự động!");
            else
            {
                if (txtHoTen.Text != "" && txtDiaChi.Text != "")
                {
                    if (ktdienthoai(txtDienThoai.Text) == false)
                        MessageBox.Show("Số điện thoại phải 10 số hoặc để trống");
                    else
                    {
                        string truyen = "";
                        int n = dataGridViewNhanVien.Rows.Count;
                        for (int i = 0; i < n - 1; i++)
                        {
                            int a = Int16.Parse(dataGridViewNhanVien.Rows[i].Cells[0].Value.ToString().Substring(2, 3));
                            if (i + 1 < a)
                            {
                                if (i + 1 < 10)
                                    truyen = "NV00" + (i + 1).ToString();
                                if ((i + 1 > 9) && (i + 1 < 100))
                                    truyen = "NV0" + (i + 1).ToString();
                                if (i + 1 > 99)
                                    truyen = "NV" + (i + 1).ToString();
                                break;
                            }
                        }
                        if (truyen == "")
                        {
                            if (n < 10)
                                truyen = "NV00" + n.ToString();
                            if (n > 9 && n < 100)
                                truyen = "NV0" + n.ToString();
                            if (n > 99)
                                truyen = "NV" + n.ToString();
                        }
                        c.connect();
                        string sql2 = "";
                        string[] ngaythangnam = dateTimePickerNgaySinh.Value.ToString().Split('/');
                        string d = ngaythangnam[1] + "/" + ngaythangnam[0] + "/" + ngaythangnam[2].Substring(0, 4);
                        if (radioButtonNam.Checked)
                        {
                            if (txtDienThoai.Text == "")
                                sql2 = "insert into NHANVIEN values('" + truyen + "',N'" + txtHoTen.Text + "',1," +
                                      " N'" + d + "',N'" + txtDiaChi.Text + "',NULL," +
                                      " N'" + comboBoxPhongBanNV.SelectedValue + "',N'" + comboBoxChucVuNV.SelectedValue + "'," +
                                      " N'" + comboBoxChuyenMonNV.SelectedValue + "',N'" + comboBoxTDHVNV.SelectedValue + "')";
                            else
                                sql2 = "insert into NHANVIEN values('" + truyen + "',N'" + txtHoTen.Text + "',1," +
                                      " N'" + d + "',N'" + txtDiaChi.Text + "',N'" + txtDienThoai.Text + "'," +
                                      " N'" + comboBoxPhongBanNV.SelectedValue + "',N'" + comboBoxChucVuNV.SelectedValue + "'," +
                                      " N'" + comboBoxChuyenMonNV.SelectedValue + "',N'" + comboBoxTDHVNV.SelectedValue + "')";
                        }
                        if (radioButtonNu.Checked)
                        {
                            if (txtDienThoai.Text == "")
                                sql2 = "insert into NHANVIEN values('" + truyen + "',N'" + txtHoTen.Text + "',0," +
                                      " N'" + d + "',N'" + txtDiaChi.Text + "',NULL," +
                                      " N'" + comboBoxPhongBanNV.SelectedValue + "',N'" + comboBoxChucVuNV.SelectedValue + "'," +
                                      " N'" + comboBoxChuyenMonNV.SelectedValue + "',N'" + comboBoxTDHVNV.SelectedValue + "')";
                            else
                                sql2 = "insert into NHANVIEN values('" + truyen + "',N'" + txtHoTen.Text + "',0," +
                                      " N'" + d + "',N'" + txtDiaChi.Text + "',N'" + txtDienThoai.Text + "'," +
                                      " N'" + comboBoxPhongBanNV.SelectedValue + "',N'" + comboBoxChucVuNV.SelectedValue + "'," +
                                      " N'" + comboBoxChuyenMonNV.SelectedValue + "',N'" + comboBoxTDHVNV.SelectedValue + "')";
                        }
                        SqlCommand cmd = new SqlCommand(sql2, c.conn);
                        int kq = (int)cmd.ExecuteNonQuery();//trả về số cột đc thêm
                        if (kq > 0)
                        {
                            MessageBox.Show("Thêm thành công!\n Mã nhân viên là:'" + truyen + "'");
                            c.disconnect();
                            Loaddata(sql);
                        }
                        else
                        {
                            c.disconnect();
                            MessageBox.Show("Thêm thất bại!");
                        }

                        cmd.Dispose();
                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            
        }

        private void BtnSuaNV_Click(object sender, EventArgs e)
        {
            if (lblMaNV.Text != "")
            {
                c.connect();
                if (ktdienthoai(txtDienThoai.Text) == false)
                    MessageBox.Show("Số điện thoại phải 10 số hoặc để trống");
                else
                {
                    if (txtHoTen.Text == ""||txtDiaChi.Text=="")
                    {
                        MessageBox.Show("Vui lòng nhập đủ thông tin!");
                    }
                    else
                    {
                        string[] ngaythangnam = dateTimePickerNgaySinh.Value.ToString().Split('/');
                        string d = ngaythangnam[1] + "/" + ngaythangnam[0] + "/" + ngaythangnam[2].Substring(0, 4);
                        if (radioButtonNam.Checked)
                        {
                            string sql3 = "update NHANVIEN set HoTen=N'" + txtHoTen.Text + "',Phai=1," +
                                         " NgSinh='" + d + "',DC=N'" + txtDiaChi.Text + "'," +
                                         " MaPB='"+comboBoxPhongBanNV.SelectedValue+ "',MaCV='" + comboBoxChucVuNV.SelectedValue + "'," +
                                         " MaCM='" + comboBoxChuyenMonNV.SelectedValue + "',MaTDHV='" + comboBoxTDHVNV.SelectedValue + "'" +
                                         " where MaNV='" + lblMaNV.Text + "'";
                            SqlCommand cmd3 = new SqlCommand(sql3, c.conn);
                            cmd3.ExecuteNonQuery();
                            cmd3.Dispose();
                        }                           
                        if(radioButtonNu.Checked)
                        {
                            string sql3 = "update NHANVIEN set HoTen=N'" + txtHoTen.Text + "',Phai=0," +
                                         " NgSinh='" + d + "',DC=N'" + txtDiaChi.Text + "'," +
                                         " MaPB='" + comboBoxPhongBanNV.SelectedValue + "',MaCV='" + comboBoxChucVuNV.SelectedValue + "'," +
                                         " MaCM='" + comboBoxChuyenMonNV.SelectedValue + "',MaTDHV='" + comboBoxTDHVNV.SelectedValue + "'" +
                                         " where MaNV='" + lblMaNV.Text + "'";
                            SqlCommand cmd3 = new SqlCommand(sql3, c.conn);
                            cmd3.ExecuteNonQuery();
                            cmd3.Dispose();
                        }
                                               
                        if (txtDienThoai.Text == "")
                        {
                            string sql2 = "update NHANVIEN set DienThoai= NULL  where MaNV='" + lblMaNV.Text + "'";
                            SqlCommand cmd = new SqlCommand(sql2, c.conn);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }
                        if (txtDienThoai.Text != "")
                        {
                            string sql2 = "update NHANVIEN set DienThoai='" + txtDienThoai.Text + "'  where MaNV='" + lblMaNV.Text + "'";
                            SqlCommand cmd = new SqlCommand(sql2, c.conn);
                            cmd.ExecuteNonQuery();
                            cmd.Dispose();
                        }

                        c.disconnect();
                        MessageBox.Show("Sửa thành công!");
                        try
                        {
                            string sql2 = "";
                            if (radioButtonTTMNV.Checked)
                                sql2 = "select MaNV AS N'Mã nhân viên',HoTen AS N'Họ tên',Phai AS N'Phái',NgSinh " +
                                         "AS N'Ngày sinh',DC AS N'Địa chỉ',DienThoai AS N'Điện thoại',TenPB AS N'Tên phòng ban'," +
                                         "TenCV AS N'Tên chức vụ',TenCM AS N'Tên chuyên môn',TenTDHV AS N'Tên trình độ học vấn' " +
                                         "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                                         "NHANVIEN.MaCV=CHUCVU.MaCV inner join CHUYENMON on NHANVIEN.MaCM=CHUYENMON.MaCM inner join " +
                                         "TRINHDOHV on NHANVIEN.MaTDHV=TRINHDOHV.MaTDHV " +
                                         "where MaNV='" + txtTimKiemNV.Text + "'";
                            if (radioButtonTTMPB.Checked)
                                sql2 = "select MaNV AS N'Mã nhân viên',HoTen AS N'Họ tên',Phai AS N'Phái',NgSinh " +
                                         "AS N'Ngày sinh',DC AS N'Địa chỉ',DienThoai AS N'Điện thoại',TenPB AS N'Tên phòng ban'," +
                                         "TenCV AS N'Tên chức vụ',TenCM AS N'Tên chuyên môn',TenTDHV AS N'Tên trình độ học vấn' " +
                                         "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                                         "NHANVIEN.MaCV=CHUCVU.MaCV inner join CHUYENMON on NHANVIEN.MaCM=CHUYENMON.MaCM inner join " +
                                         "TRINHDOHV on NHANVIEN.MaTDHV=TRINHDOHV.MaTDHV " +
                                         "where NHANVIEN.MaPB='" + txtTimKiemNV.Text + "'";
                            if (radioButtonTTMCV.Checked)
                                sql2 = "select MaNV AS N'Mã nhân viên',HoTen AS N'Họ tên',Phai AS N'Phái',NgSinh " +
                                         "AS N'Ngày sinh',DC AS N'Địa chỉ',DienThoai AS N'Điện thoại',TenPB AS N'Tên phòng ban'," +
                                         "TenCV AS N'Tên chức vụ',TenCM AS N'Tên chuyên môn',TenTDHV AS N'Tên trình độ học vấn' " +
                                         "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                                         "NHANVIEN.MaCV=CHUCVU.MaCV inner join CHUYENMON on NHANVIEN.MaCM=CHUYENMON.MaCM inner join " +
                                         "TRINHDOHV on NHANVIEN.MaTDHV=TRINHDOHV.MaTDHV " +
                                         "where NHANVIEN.MaCV='" + txtTimKiemNV.Text + "'";
                            if (radioButtonTTMTDHV.Checked)
                                sql2 = "select MaNV AS N'Mã nhân viên',HoTen AS N'Họ tên',Phai AS N'Phái',NgSinh " +
                                         "AS N'Ngày sinh',DC AS N'Địa chỉ',DienThoai AS N'Điện thoại',TenPB AS N'Tên phòng ban'," +
                                         "TenCV AS N'Tên chức vụ',TenCM AS N'Tên chuyên môn',TenTDHV AS N'Tên trình độ học vấn' " +
                                         "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                                         "NHANVIEN.MaCV=CHUCVU.MaCV inner join CHUYENMON on NHANVIEN.MaCM=CHUYENMON.MaCM inner join " +
                                         "TRINHDOHV on NHANVIEN.MaTDHV=TRINHDOHV.MaTDHV " +
                                         "where NHANVIEN.MaTDHV='" + txtTimKiemNV.Text + "'";
                            Loaddata(sql2);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }                                      
                }
            }
        }
        private void BtnXoaNV_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                c.connect();
                string sql2 = "delete from NHANVIEN  where MaNV='" + lblMaNV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql2, c.conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Xóa thành công!");
                c.disconnect();
                Loaddata(sql);
            }
        }

        private void BtnTimTheoMaNV_Click(object sender, EventArgs e)
        {
            //nếu ô tìm kiếm k rỗng thì tìm kiếm
           if (txtTimKiemNV.Text != "")
            {
                try
                {
                    string sql2 = "";
                    if (radioButtonTTMNV.Checked)
                        sql2 = "select MaNV AS N'Mã nhân viên',HoTen AS N'Họ tên',Phai AS N'Phái',NgSinh " +
                                 "AS N'Ngày sinh',DC AS N'Địa chỉ',DienThoai AS N'Điện thoại',TenPB AS N'Tên phòng ban'," +
                                 "TenCV AS N'Tên chức vụ',TenCM AS N'Tên chuyên môn',TenTDHV AS N'Tên trình độ học vấn' " +
                                 "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                                 "NHANVIEN.MaCV=CHUCVU.MaCV inner join CHUYENMON on NHANVIEN.MaCM=CHUYENMON.MaCM inner join " +
                                 "TRINHDOHV on NHANVIEN.MaTDHV=TRINHDOHV.MaTDHV " +
                                 "where MaNV='" + txtTimKiemNV.Text + "'";
                    if(radioButtonTTMPB.Checked)
                        sql2 = "select MaNV AS N'Mã nhân viên',HoTen AS N'Họ tên',Phai AS N'Phái',NgSinh " +
                                 "AS N'Ngày sinh',DC AS N'Địa chỉ',DienThoai AS N'Điện thoại',TenPB AS N'Tên phòng ban'," +
                                 "TenCV AS N'Tên chức vụ',TenCM AS N'Tên chuyên môn',TenTDHV AS N'Tên trình độ học vấn' " +
                                 "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                                 "NHANVIEN.MaCV=CHUCVU.MaCV inner join CHUYENMON on NHANVIEN.MaCM=CHUYENMON.MaCM inner join " +
                                 "TRINHDOHV on NHANVIEN.MaTDHV=TRINHDOHV.MaTDHV " +
                                 "where NHANVIEN.MaPB='" + txtTimKiemNV.Text + "'";
                    if(radioButtonTTMCV.Checked)
                        sql2 = "select MaNV AS N'Mã nhân viên',HoTen AS N'Họ tên',Phai AS N'Phái',NgSinh " +
                                 "AS N'Ngày sinh',DC AS N'Địa chỉ',DienThoai AS N'Điện thoại',TenPB AS N'Tên phòng ban'," +
                                 "TenCV AS N'Tên chức vụ',TenCM AS N'Tên chuyên môn',TenTDHV AS N'Tên trình độ học vấn' " +
                                 "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                                 "NHANVIEN.MaCV=CHUCVU.MaCV inner join CHUYENMON on NHANVIEN.MaCM=CHUYENMON.MaCM inner join " +
                                 "TRINHDOHV on NHANVIEN.MaTDHV=TRINHDOHV.MaTDHV " +
                                 "where NHANVIEN.MaCV='" + txtTimKiemNV.Text + "'";
                    if(radioButtonTTMTDHV.Checked)
                        sql2 = "select MaNV AS N'Mã nhân viên',HoTen AS N'Họ tên',Phai AS N'Phái',NgSinh " +
                                 "AS N'Ngày sinh',DC AS N'Địa chỉ',DienThoai AS N'Điện thoại',TenPB AS N'Tên phòng ban'," +
                                 "TenCV AS N'Tên chức vụ',TenCM AS N'Tên chuyên môn',TenTDHV AS N'Tên trình độ học vấn' " +
                                 "from NHANVIEN inner join PHONGBAN on NHANVIEN.MaPB=PHONGBAN.MAPB inner join CHUCVU on " +
                                 "NHANVIEN.MaCV=CHUCVU.MaCV inner join CHUYENMON on NHANVIEN.MaCM=CHUYENMON.MaCM inner join " +
                                 "TRINHDOHV on NHANVIEN.MaTDHV=TRINHDOHV.MaTDHV " +
                                 "where NHANVIEN.MaTDHV='" + txtTimKiemNV.Text + "'";
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

        private void BtnXoaDuLieuNV_Click(object sender, EventArgs e)
        {
            lblMaNV.Text = "";
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
        }



       


        private void DataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMaNV.Text = dataGridViewNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = dataGridViewNhanVien.CurrentRow.Cells[1].Value.ToString();

            int phai = Int32.Parse(dataGridViewNhanVien.CurrentRow.Cells[2].Value.ToString());
            if (phai == 0)
                radioButtonNu.Checked = true;
            if (phai == 1)
                radioButtonNam.Checked = true;

            string[] ngaythangnam = dataGridViewNhanVien.CurrentRow.Cells[3].Value.ToString().Split('/');
            
            dateTimePickerNgaySinh.Value = new DateTime(int.Parse(ngaythangnam[2].Substring(0, 4)), int.Parse(ngaythangnam[1]), int.Parse(ngaythangnam[0]));

            txtDiaChi.Text = dataGridViewNhanVien.CurrentRow.Cells[4].Value.ToString();
            txtDienThoai.Text = dataGridViewNhanVien.CurrentRow.Cells[5].Value.ToString();
            comboBoxPhongBanNV.Text= dataGridViewNhanVien.CurrentRow.Cells[6].Value.ToString();
            comboBoxChucVuNV.Text = dataGridViewNhanVien.CurrentRow.Cells[7].Value.ToString();
            comboBoxChuyenMonNV.Text = dataGridViewNhanVien.CurrentRow.Cells[8].Value.ToString();
            comboBoxTDHVNV.Text = dataGridViewNhanVien.CurrentRow.Cells[9].Value.ToString();
        }


        //nếu ô lbl mã nv rỗng thì nút sửa ẩn và ngược lại
        private void LblMaNV_TextChanged_1(object sender, EventArgs e)
        {
            if (lblMaNV.Text == "")
            {
                btnSuaNV.Enabled = false;
                btnXoaNV.Enabled = false;
                btnThemNV.Enabled = true;
            }
            else
            {
                btnSuaNV.Enabled = true;
                btnXoaNV.Enabled = true;
                btnThemNV.Enabled = false;
            }
        }
    }
}
