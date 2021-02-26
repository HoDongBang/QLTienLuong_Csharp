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
    public partial class frmTDHV : Form
    {
        public frmTDHV()
        {
            InitializeComponent();
        }

        KetNoiDuLieu c = new KetNoiDuLieu();
        string sql = "select MaTDHV AS N'Mã trình độ học vấn',TenTDHV AS N'Tên trình độ học vấn' from TRINHDOHV";

        public void Loaddata(string sql)
        {
            try
            {
                c.connect();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, c.conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewTDHV.DataSource = tb;
                dataGridViewTDHV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewTDHV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb.Dispose();
                adapter.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void FrmTDHV_Load(object sender, EventArgs e)
        {
            Loaddata(sql);
            btnSuaTDHV.Enabled = false;
            btnXoaTDHV.Enabled = false;
            btnThemTDHV.Enabled = true;
        }

        private void LblMaTDHV_TextChanged(object sender, EventArgs e)
        {
            if (lblMaTDHV.Text == "")
            {
                btnSuaTDHV.Enabled = false;
                btnXoaTDHV.Enabled = false;
                btnThemTDHV.Enabled = true;
            }
            else
            {
                btnSuaTDHV.Enabled = true;
                btnXoaTDHV.Enabled = true;
                btnThemTDHV.Enabled = false;
            }
        }

        private void DataGridViewTDHV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMaTDHV.Text = dataGridViewTDHV.CurrentRow.Cells[0].Value.ToString();
            txtTenTDHV.Text = dataGridViewTDHV.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnXoaDuLieuTDHV_Click(object sender, EventArgs e)
        {
            lblMaTDHV.Text = "";
            txtTenTDHV.Text = "";
        }

        private void BtnThemTDHV_Click(object sender, EventArgs e)
        {
            if (txtTenTDHV.Text != "")
            {
                string truyen = "";
                int n = dataGridViewTDHV.Rows.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    int a = Int16.Parse(dataGridViewTDHV.Rows[i].Cells[0].Value.ToString());
                    if (i + 1 < a)
                    {
                        if (i + 1 < 10)
                            truyen = "HV0" + (i + 1).ToString();
                        if ((i + 1 > 9) && (i + 1 < 100))
                            truyen = "HV" + (i + 1).ToString();
                        break;
                    }
                }
                if (truyen == "")
                {
                    if (n < 10)
                        truyen = "HV0" + n.ToString();
                    if (n > 9 && n < 100)
                        truyen = "HV" + n.ToString();
                }

                c.connect();
                string sql2 = "insert into TRINHDOHV values('" + truyen + "',N'" + txtTenTDHV.Text + "')";
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

        private void BtnSuaTDHV_Click(object sender, EventArgs e)
        {
            if (txtTenTDHV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
            else
            {
                c.connect();
                string sql2 = "update TRINHDOHV set TenTDHV=N'" + txtTenTDHV.Text + "' where MaTDHV='" + lblMaTDHV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql2, c.conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                c.disconnect();
                MessageBox.Show("Sửa thành công!");
                Loaddata(sql);
            }
        }

        private void BtnXoaTDHV_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                c.connect();
                string sql2 = "delete from TRINHDOHV  where MaTDHV='" + lblMaTDHV.Text + "'";
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
