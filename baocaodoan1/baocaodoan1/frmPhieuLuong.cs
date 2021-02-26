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
    public partial class frmPhieuLuong : Form
    {
        public frmPhieuLuong()
        {
            InitializeComponent();
        }
        
        KetNoiDuLieu c = new KetNoiDuLieu();
        string sql = "select MaPL AS N'Mã phiếu lương',TongSTien AS N'Tổng số tiền',NgayPhat AS N'Ngày phát',MaNV AS N'Mã nhân viên',Thang AS N'Tháng',Nam AS N'Năm'" +
            " from PHIEULUONG ORDER BY MaPL DESC";
        

        public void Loaddata(string sql)
        {
            
            try
            {
                c.connect();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, c.conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewPhieuLuong.DataSource = tb;
                dataGridViewPhieuLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewPhieuLuong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb.Dispose();
                adapter.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void FrmPhieuLuong_Load(object sender, EventArgs e)
        {
            
            string sqlttpl = "select NHANVIEN.MaNV AS N'Mã nhân viên',HoTen AS N'Tên nhân viên',MUCLUONG.SoTien AS N'Lương cơ bản'," +
            " Trocap AS N'Trợ cấp'" +
            " from NHANVIEN inner join CHUCVU on NHANVIEN.MaCV=CHUCVU.MaCV inner join MUCLUONG on CHUCVU.MaML=MUCLUONG.MaML";
            try
            {
                c.connect();
                SqlDataAdapter adapter2 = new SqlDataAdapter(sqlttpl, c.conn);
                DataTable tb2 = new DataTable();
                adapter2.Fill(tb2);
                dataGridViewTNPL.DataSource = tb2;
                dataGridViewTNPL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewTNPL.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb2.Dispose();
                adapter2.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }

            string[] ngaythangnam = dateTimePickerTNPL.Value.ToString().Split('/');
            string sqlttt = "select NHANVIEN.MaNV AS N'Mã nhân viên',sum(KTKL.SoTien) AS N'Tổng KTKL'" +
            " from NHANVIEN inner join KTKL_NHANVIEN on NHANVIEN.MaNV= KTKL_NHANVIEN.MaNV inner join KTKL on KTKL_NHANVIEN.MaKTKL= KTKL.MaKTKL" +
            " where Thang='"+ngaythangnam[1]+ "' AND Nam='" + ngaythangnam[2].Substring(0, 4) + "'" +
            " group by NHANVIEN.MaNV,Thang,Nam";
            try
            {
                c.connect();
                SqlDataAdapter adapter3 = new SqlDataAdapter(sqlttt, c.conn);
                DataTable tb3 = new DataTable();
                adapter3.Fill(tb3);
                dataGridViewTTT.DataSource = tb3;
                dataGridViewTTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewTTT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb3.Dispose();
                adapter3.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
            Loaddata(sql);
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            c.connect();
            string[] ngaythangnam = dateTimePickerTNPL.Value.ToString().Split('/');
            string sql2 = "select Thang,Nam from PHIEULUONG where Thang ='" + ngaythangnam[1] + "' AND Nam='" + ngaythangnam[2].Substring(0,4) + "'";
            SqlCommand cmd2 = new SqlCommand(sql2, c.conn);
            SqlDataReader docdata = cmd2.ExecuteReader();

            //nếu đọc thành công thì mã đã tồn tại
            if (docdata.Read())
            {
                docdata.Close();
                docdata.Dispose();
                c.disconnect();
                MessageBox.Show("Tháng này đã cập nhật rồi!");
            }
            else
            {
                docdata.Close();
                docdata.Dispose();
                c.disconnect();
                cmd2.Dispose();
                

                DateTime today = DateTime.Now;
                string hientai = today.Month.ToString() + "-" + today.Day.ToString() + "-" + today.Year.ToString();
                for(int i=0;i< (dataGridViewTNPL.Rows.Count)-1;i++)
                {
                    c.connect();
                    string truyen = "";
                    if (dataGridViewPhieuLuong.Rows.Count == 1)
                        truyen = "PL0001";
                    if (dataGridViewPhieuLuong.Rows.Count > 1)
                    {
                        int a = Int16.Parse(dataGridViewPhieuLuong.Rows[0].Cells[0].Value.ToString().Substring(2, 4));
                        if (a + 1 < 10)
                            truyen = "PL000" + (a + 1).ToString();
                        if (a + 1 > 9 && a < 100)
                            truyen = "PL00" + (a + 1).ToString();
                        if (a + 1 > 99 && a < 1000)
                            truyen = "PL0" + (a + 1).ToString();
                        if (a + 1 > 999)
                            truyen = "PL" + (a + 1).ToString();
                    }
                    int tong = int.Parse(dataGridViewTNPL.Rows[i].Cells[2].Value.ToString()) + int.Parse(dataGridViewTNPL.Rows[i].Cells[3].Value.ToString());
                    for(int j=0;j< dataGridViewTTT.Rows.Count - 1;j++)
                    {
                        if (dataGridViewTNPL.Rows[i].Cells[0].Value.ToString() == dataGridViewTNPL.Rows[j].Cells[0].Value.ToString())
                        {
                            tong = tong + int.Parse(dataGridViewTTT.Rows[j].Cells[1].Value.ToString());
                            break;
                        }        
                    }
                    string sql3 = "insert into PHIEULUONG values('" + truyen + "','" + tong + "','"+hientai+"','" + dataGridViewTNPL.Rows[i].Cells[0].Value.ToString() + "','"+ngaythangnam[1]+ "','" + ngaythangnam[2].Substring(0,4) + "')";
                    SqlCommand cmd3 = new SqlCommand(sql3, c.conn);
                    cmd3.ExecuteNonQuery();
                    c.disconnect();
                    Loaddata(sql);
                    cmd3.Dispose();
                }
                Loaddata(sql);
            }
            
        }

        private void DateTimePickerTNPL_ValueChanged(object sender, EventArgs e)
        {
            string[] ngaythangnam = dateTimePickerTNPL.Value.ToString().Split('/');
            string sqlttt = "select NHANVIEN.MaNV AS N'Mã nhân viên',sum(KTKL.SoTien) AS N'Tổng KTKL'" +
            " from NHANVIEN inner join KTKL_NHANVIEN on NHANVIEN.MaNV= KTKL_NHANVIEN.MaNV inner join KTKL on KTKL_NHANVIEN.MaKTKL= KTKL.MaKTKL" +
            " where Thang='" + ngaythangnam[1] + "' AND Nam='" + ngaythangnam[2].Substring(0, 4) + "'" +
            " group by NHANVIEN.MaNV,Thang,Nam";
            try
            {
                c.connect();
                SqlDataAdapter adapter3 = new SqlDataAdapter(sqlttt, c.conn);
                DataTable tb3 = new DataTable();
                adapter3.Fill(tb3);
                dataGridViewTTT.DataSource = tb3;
                dataGridViewTTT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewTTT.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb3.Dispose();
                adapter3.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }
    }
}
