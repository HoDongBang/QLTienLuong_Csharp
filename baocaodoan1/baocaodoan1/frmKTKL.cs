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
    public partial class frmKTKL : Form
    {
        public frmKTKL()
        {
            InitializeComponent();
        }


        KetNoiDuLieu c = new KetNoiDuLieu();
        string sql = "select MaKTKL AS N'Mã khen thưởng - kỉ luật',TenKTKL AS N'Tên khen thưởng - kỉ luật',HinhThuc AS N'Hình thức',SoTien AS N'Số tiền' from KTKL";

        public void Loaddata(string sql)
        {
            try
            {
                c.connect();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, c.conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewKTKL.DataSource = tb;
                dataGridViewKTKL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewKTKL.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb.Dispose();
                adapter.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void FrmKTKL_Load(object sender, EventArgs e)
        {
            Loaddata(sql);
        }

        private void DataGridViewKTKL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKTKL.Text = dataGridViewKTKL.CurrentRow.Cells[0].Value.ToString();
            txtTenKTKL.Text = dataGridViewKTKL.CurrentRow.Cells[1].Value.ToString();
            txtHinhThuc.Text = dataGridViewKTKL.CurrentRow.Cells[2].Value.ToString();
            txtSoTienKTKL.Text = dataGridViewKTKL.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnXoaDuLieuTDHV_Click(object sender, EventArgs e)
        {
            txtMaKTKL.Text = "";
            txtTenKTKL.Text = "";
            txtHinhThuc.Text = "";
            txtSoTienKTKL.Text = "";
        }

        public bool ktmaktkl(string txt)
        {
            c.connect();
            string sql = "select MaKTKL from KTKL where MaKTKL ='" + txt + "'";
            SqlCommand cmd = new SqlCommand(sql, c.conn);
            SqlDataReader docdata = cmd.ExecuteReader();

            //nếu đọc thành công thì mã đã tồn tại
            if (docdata.Read())
            {
                docdata.Close();
                docdata.Dispose();
                c.disconnect();
                return false;
            }
            else
            {
                c.disconnect();
                return true;
            }  
        }

        private void BtnThemKTKL_Click(object sender, EventArgs e)
        {
            if (txtMaKTKL.Text!=""|| txtTenKTKL.Text != ""||txtHinhThuc.Text!="")
            {
                if (txtMaKTKL.TextLength > 0 && txtMaKTKL.TextLength < 4)
                    MessageBox.Show("Mã khen thưởng kĩ luật phải có bốn kí tự!");
                if(txtMaKTKL.TextLength==4)
                {
                    if(txtMaKTKL.Text.Substring(0,2)=="KL"|| txtMaKTKL.Text.Substring(0, 2) == "KT")
                    {
                        if(ktmaktkl(txtMaKTKL.Text)==false)
                            MessageBox.Show("Mã khen thưởng kỉ luật đã tồn tại!");
                        if(ktmaktkl(txtMaKTKL.Text) == true)
                        {
                            c.connect();
                            string sql2 = "";
                            if (txtSoTienKTKL.Text=="")
                                sql2="insert into KTKL values('" + txtMaKTKL.Text + "',N'" + txtTenKTKL.Text + "',N'" + txtHinhThuc.Text + "',0)";
                            else sql2 = "insert into KTKL values('" + txtMaKTKL.Text + "',N'" + txtTenKTKL.Text + "',N'" + txtHinhThuc.Text + "',N'"+txtSoTienKTKL+"')";
                            SqlCommand cmd = new SqlCommand(sql2, c.conn);
                            int kq = (int)cmd.ExecuteNonQuery();//trả về số cột đc thêm
                            c.disconnect();
                            if (kq > 0)
                            {
                                MessageBox.Show("Thêm thành công!");
                                
                                Loaddata(sql);
                            }
                            else
                            {
                                MessageBox.Show("Thêm thất bại!");
                            }
                           
                            cmd.Dispose();
                        }                       
                    }
                    else MessageBox.Show("Mã khen thưởng kĩ luật phải bắt đầu bằng 'KT' nếu đó là khen thưởng, 'KL' nếu đó là kỉ luật!");
                }              
            }
            else
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
        }

        private void BtnSuaKTKL_Click(object sender, EventArgs e)
        {
            if (txtMaKTKL.Text == "" || txtTenKTKL.Text == "" || txtHinhThuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                if (ktmaktkl(txtMaKTKL.Text) == true)
                        MessageBox.Show("Nếu mã sai thì xóa mã và tiến hành thêm mã khác, chứ không thể sửa mã!");
                if (ktmaktkl(txtMaKTKL.Text) == false)
                {
                    c.connect();
                    string sql2 = "";
                    if (txtSoTienKTKL.Text == "")
                        sql2 = "update KTKL set TenKTHL=N'" + txtTenKTKL.Text + "',HinhThuc=N'" + txtHinhThuc + "',SoTien=0 where MaKTKL='" + txtMaKTKL.Text + "'";
                    else sql2 = "update KTKL set TenKTHL=N'" + txtTenKTKL.Text + "',HinhThuc=N'" + txtHinhThuc + "',SoTien=N'" + txtSoTienKTKL + "' where MaKTKL='" + txtMaKTKL.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql2, c.conn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();

                    c.disconnect();
                    MessageBox.Show("Sửa thành công!");
                    Loaddata(sql);
                }       
            }
        }

        private void BtnXoaKTKL_Click(object sender, EventArgs e)
        {
            if (txtMaKTKL.Text == "")
            {
                MessageBox.Show("Bạn muốn xóa mã nào?");
            }
            else
            {
                if (ktmaktkl(txtMaKTKL.Text) == true)
                    MessageBox.Show("Mã không tồn tại, bạn muốn xóa mã nào?");
                if (ktmaktkl(txtMaKTKL.Text) == false)
                {
                    DialogResult thongbao;
                    thongbao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (thongbao == DialogResult.OK)
                    {
                        c.connect();
                        string sql2 = "delete from KTKL  where MaKTKL='" + txtMaKTKL.Text + "'";
                        SqlCommand cmd = new SqlCommand(sql2, c.conn);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        MessageBox.Show("Xóa thành công!");
                        c.disconnect();
                        Loaddata(sql);
                    }
                }
            }
        }
    }
}
