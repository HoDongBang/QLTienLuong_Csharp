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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }


        KetNoiDuLieu c = new KetNoiDuLieu();
        string sql = "select MaCV AS N'Mã chức vụ',TenCV AS N'Tên chức vụ',MaML AS N'Mã mức lương',Trocap AS N'Trợ cấp' from CHUCVU";

        public void Loaddata(string sql)
        {
            try
            {
                c.connect();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, c.conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewChucVu.DataSource = tb;
                dataGridViewChucVu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewChucVu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb.Dispose();
                adapter.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void FrmChucVu_Load(object sender, EventArgs e)
        {
            Loaddata(sql);
            btnSuaCV.Enabled = false;
            btnXoaCV.Enabled = false;
            btnThemCV.Enabled = true;

            c.connect();
            string sqlMaMLCV = "select*from MUCLUONG";

            SqlDataAdapter adapter1 = new SqlDataAdapter(sqlMaMLCV, c.conn);
            DataTable tb1 = new DataTable();
            adapter1.Fill(tb1);
            adapter1.Dispose();
            comboBoxMaMLCV.DataSource = tb1;
            comboBoxMaMLCV.DisplayMember = "MaML";
            comboBoxMaMLCV.ValueMember = "MaML";

            c.disconnect();
        }

        private void LblMaCV_TextChanged(object sender, EventArgs e)
        {
            if (lblMaCV.Text == "")
            {
                btnSuaCV.Enabled = false;
                btnXoaCV.Enabled = false;
                btnThemCV.Enabled = true;
            }
            else
            {
                btnSuaCV.Enabled = true;
                btnXoaCV.Enabled = true;
                btnThemCV.Enabled = false;
            }
        }

        private void DataGridViewChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMaCV.Text = dataGridViewChucVu.CurrentRow.Cells[0].Value.ToString();
            txtTenCV.Text = dataGridViewChucVu.CurrentRow.Cells[1].Value.ToString();
            comboBoxMaMLCV.Text = dataGridViewChucVu.CurrentRow.Cells[2].Value.ToString();
            txtTroCapCV.Text = dataGridViewChucVu.CurrentRow.Cells[3].Value.ToString();
        }

        private void BtnXoaDuLieuCV_Click(object sender, EventArgs e)
        {
            lblMaCV.Text = "";
            txtTenCV.Text = "";
            txtTroCapCV.Text = "";
        }

        private void BtnThemCV_Click(object sender, EventArgs e)
        {
            if (txtTenCV.Text != "")
            {
                string truyen = "";
                int n = dataGridViewChucVu.Rows.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    int a = Int16.Parse(dataGridViewChucVu.Rows[i].Cells[0].Value.ToString().Substring(2, 2));
                    if (i + 1 < a)
                    {
                        if (i + 1 < 10)
                            truyen = "CV0" + (i+1).ToString();
                        if (i + 1 > 9)
                            truyen = "CV" + (i + 1).ToString();
                        break;
                    }
                }
                if (truyen == "")
                {
                    if (n < 10)
                        truyen = "CV0" + n.ToString();
                    if (n > 9)
                        truyen = "CV" + n.ToString();
                }

                c.connect();
                string sql2 = "insert into CHUCVU values('" + truyen + "',N'" + txtTenCV.Text + "',N'" + comboBoxMaMLCV.SelectedValue + "',N'" + txtTroCapCV.Text + "')";
                SqlCommand cmd = new SqlCommand(sql2, c.conn);
                int kq = (int)cmd.ExecuteNonQuery();//trả về số cột đc thêm
                c.disconnect();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!\n Mã chức vụ là:'" + truyen + "'");
                    
                    Loaddata(sql);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
               
                cmd.Dispose();

            }
            else
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
        }

        private void BtnSuaCV_Click(object sender, EventArgs e)
        {
            c.connect();
            if (txtTenCV.Text=="")
            {
            MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                string sql3 = "update CHUCVU set TenCV=N'" + txtTenCV.Text + "',MaML=N'" + comboBoxMaMLCV.SelectedValue + "' where MaCV='" + lblMaCV.Text + "'";
                SqlCommand cmd3 = new SqlCommand(sql3, c.conn);
                cmd3.ExecuteNonQuery();
                cmd3.Dispose();
                if (txtTroCapCV.Text != "")
                {
                    string sql2 = "update CHUCVU set Trocap='" + txtTroCapCV.Text + "' where MaCV='" + lblMaCV.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql2, c.conn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }                  
                if (txtTroCapCV.Text == "")
                {
                    string sql2 = "update CHUCVU set Trocap= NULL  where MaCV='" + lblMaCV.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql2, c.conn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }              

                c.disconnect();
                MessageBox.Show("Sửa thành công!");
                Loaddata(sql);
            }
        }

        private void BtnXoaCV_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                c.connect();
                string sql2 = "delete from CHUCVU  where MaCV='" + lblMaCV.Text + "'";
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
