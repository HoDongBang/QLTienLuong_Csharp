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
    public partial class frmMucLuong : Form
    {
        public frmMucLuong()
        {
            InitializeComponent();
        }
        KetNoiDuLieu c = new KetNoiDuLieu();
        string sql = "select MaML AS N'Mã mức lương',SoTien AS N'Số tiền' from MUCLUONG";

        public void Loaddata(string sql)
        {
            try
            {
                c.connect();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, c.conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewMucLuong.DataSource = tb;
                dataGridViewMucLuong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewMucLuong.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb.Dispose();
                adapter.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void FrmMucLuong_Load(object sender, EventArgs e)
        {
            Loaddata(sql);
            btnSuaML.Enabled = false;
            btnXoaML.Enabled = false;
            btnThemML.Enabled = true;
        }

        private void LblMaML_TextChanged(object sender, EventArgs e)
        {
            if (lblMaML.Text == "")
            {
                btnSuaML.Enabled = false;
                btnXoaML.Enabled = false;
                btnThemML.Enabled = true;
            }
            else
            {
                btnSuaML.Enabled = true;
                btnXoaML.Enabled = true;
                btnThemML.Enabled = false;
            }
        }

        private void DataGridViewMucLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMaML.Text = dataGridViewMucLuong.CurrentRow.Cells[0].Value.ToString();
            txtSoTienML.Text = dataGridViewMucLuong.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnXoaDuLieuML_Click(object sender, EventArgs e)
        {
            lblMaML.Text = "";
            txtSoTienML.Text = "";
        }

        private void BtnThemML_Click(object sender, EventArgs e)
        {
            if (txtSoTienML.Text != "")
            {
                string truyen = "";
                int n = dataGridViewMucLuong.Rows.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    int a = Int16.Parse(dataGridViewMucLuong.Rows[i].Cells[0].Value.ToString());
                    if (i + 1 < a)
                    {
                        truyen = (i + 1).ToString();
                        break;
                    }
                }
                if (truyen == "")
                {
                    truyen = n.ToString();
                }

                c.connect();
                string sql2 = "insert into MUCLUONG values('" + truyen + "',N'" + txtSoTienML.Text + "')";
                SqlCommand cmd = new SqlCommand(sql2, c.conn);
                int kq = (int)cmd.ExecuteNonQuery();//trả về số cột đc thêm
                c.disconnect();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!\n Mã mức lương là:'" + truyen + "'");
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

        private void BtnSuaML_Click(object sender, EventArgs e)
        {
            if (txtSoTienML.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                c.connect();
                string sql2 = "update MUCLUONG set SoTien=N'" + txtSoTienML.Text + "' where MaML='" + lblMaML.Text + "'";
                SqlCommand cmd = new SqlCommand(sql2, c.conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                c.disconnect();
                MessageBox.Show("Sửa thành công!");
                Loaddata(sql);
            }
        }

        private void BtnXoaML_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                c.connect();
                string sql2 = "delete from MUCLUONG  where MaML='" + lblMaML.Text + "'";
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
