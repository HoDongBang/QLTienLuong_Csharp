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
    public partial class frmChuyenMon : Form
    {
        public frmChuyenMon()
        {
            InitializeComponent();
        }

        KetNoiDuLieu c = new KetNoiDuLieu();
        string sql = "select MaCM AS N'Mã chuyên môn',TenCM AS N'Tên chuyên môn' from CHUYENMON";

        public void Loaddata(string sql)
        {
            try
            {
                c.connect();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, c.conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewChuyenMon.DataSource = tb;
                dataGridViewChuyenMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewChuyenMon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb.Dispose();
                adapter.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void FrmChuyenMon_Load(object sender, EventArgs e)
        {
            Loaddata(sql);
            btnSuaCM.Enabled = false;
            btnXoaCM.Enabled = false;
            btnThemCM.Enabled = true;
        }

        private void LblMaCM_TextChanged(object sender, EventArgs e)
        {
            if (lblMaCM.Text == "")
            {
                btnSuaCM.Enabled = false;
                btnXoaCM.Enabled = false;
                btnThemCM.Enabled = true;
            }
            else
            {
                btnSuaCM.Enabled = true;
                btnXoaCM.Enabled = true;
                btnThemCM.Enabled = false;
            }
        }

        private void DataGridViewChuyenMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMaCM.Text = dataGridViewChuyenMon.CurrentRow.Cells[0].Value.ToString();
            txtTenCM.Text = dataGridViewChuyenMon.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnXoaDuLieuCM_Click(object sender, EventArgs e)
        {
            lblMaCM.Text = "";
            txtTenCM.Text = "";
        }

        private void BtnThemCM_Click(object sender, EventArgs e)
        {
            if (txtTenCM.Text != "")
            {
                string truyen = "";
                int n = dataGridViewChuyenMon.Rows.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    int a = Int16.Parse(dataGridViewChuyenMon.Rows[i].Cells[0].Value.ToString().Substring(2, 2));
                    if (i + 1 < a)
                    {
                        if (i + 1 < 10)
                            truyen = "CM0" + (i + 1).ToString();
                        if (i + 1 > 9)
                            truyen = "CM" + (i + 1).ToString();
                        break;
                    }
                }
                if (truyen == "")
                {
                    if (n < 10)
                        truyen = "CM0" + n.ToString();
                    if (n > 9)
                        truyen = "CM" + n.ToString();
                }

                c.connect();
                string sql2 = "insert into CHUYENMON values('" + truyen + "',N'" + txtTenCM.Text + "')";
                SqlCommand cmd = new SqlCommand(sql2, c.conn);
                int kq = (int)cmd.ExecuteNonQuery();//trả về số cột đc thêm
                c.disconnect();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!\n Mã chuyên môn là:'" + truyen + "'");
                    
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

        private void BtnSuaCM_Click(object sender, EventArgs e)
        {
            if (txtTenCM.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                c.connect();
                string sql2 = "update CHUYENMON set TenCM=N'" + txtTenCM.Text + "' where MaCM='" + lblMaCM.Text + "'";
                SqlCommand cmd = new SqlCommand(sql2, c.conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                c.disconnect();
                MessageBox.Show("Sửa thành công!");
                Loaddata(sql);
            }
        }

        private void BtnXoaCM_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                c.connect();
                string sql2 = "delete from CHUYENMON  where MaCM='" + lblMaCM.Text + "'";
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
