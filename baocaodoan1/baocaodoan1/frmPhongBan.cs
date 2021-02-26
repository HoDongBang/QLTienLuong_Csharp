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
    public partial class frmPhongBan : Form
    {
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            Loaddata(sql);
            btnSuaPB.Enabled = false;
            btnXoaPB.Enabled = false;
            btnThemPB.Enabled = true;
        }

        KetNoiDuLieu c = new KetNoiDuLieu();
        string sql = "select MaPB AS N'Mã phòng ban',TenPB AS N'Tên phòng ban',DiaChi AS N'Địa chỉ' from PHONGBAN";

        public void Loaddata(string sql)
        {
            try
            {
                c.connect();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, c.conn);
                DataTable tb = new DataTable();
                adapter.Fill(tb);
                dataGridViewPhongBan.DataSource = tb;
                dataGridViewPhongBan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewPhongBan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                tb.Dispose();
                adapter.Dispose();
                c.disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối!");
            }
        }

        private void BtnXoaDuLieuPB_Click(object sender, EventArgs e)
        {
            lblMaPB.Text = "";
            txtTenPB.Text = "";
            txtDiaChiPB.Text = "";
        }

        private void BtnSuaPB_Click(object sender, EventArgs e)
        {
            if (lblMaPB.Text != "")
            {
                if (txtTenPB.Text == "" || txtDiaChiPB.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!");
                }
                else
                {
                    c.connect();
                    string sql2 = "update PHONGBAN set TenPB=N'" + txtTenPB.Text + "',DiaChi=N'" + txtDiaChiPB.Text + "' where MaPB='" + lblMaPB.Text + "'";
                    SqlCommand cmd = new SqlCommand(sql2, c.conn);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    c.disconnect();
                    MessageBox.Show("Sửa thành công!");
                    Loaddata(sql);
                }               
            }           
        }

        private void LblMaPB_TextChanged(object sender, EventArgs e)
        {
            if (lblMaPB.Text == "")
            {
                btnSuaPB.Enabled = false;
                btnXoaPB.Enabled = false;
                btnThemPB.Enabled = true;
            }               
            else
            {
                btnSuaPB.Enabled = true;
                btnXoaPB.Enabled = true;
                btnThemPB.Enabled = false;
            } 
        }

        private void BtnThemPB_Click(object sender, EventArgs e)
        {
            if (txtTenPB.Text != "" && txtDiaChiPB.Text != "")
            {
                string truyen = "";
                int n = dataGridViewPhongBan.Rows.Count;
                for(int i=0;i<n-1;i++)
                {
                    int a = Int16.Parse(dataGridViewPhongBan.Rows[i].Cells[0].Value.ToString().Substring(2, 2));
                    if (i+1 < a)
                    {
                        if(i+1<10)
                            truyen = "PB0" + (i+1).ToString();
                        if(i+1>9)
                            truyen = "PB" + (i + 1).ToString();
                        break;
                    }
                }
                if(truyen=="")
                {
                    if (n < 10)
                        truyen = "PB0" + n.ToString();
                    if (n > 9)
                        truyen = "PB" + n.ToString();
                }

                c.connect();
                string sql2 = "insert into PHONGBAN values('" + truyen + "',N'" + txtTenPB.Text + "',N'" + txtDiaChiPB.Text + "')";
                SqlCommand cmd = new SqlCommand(sql2, c.conn);
                int kq = (int)cmd.ExecuteNonQuery();//trả về số cột đc thêm
                c.disconnect();
                if (kq > 0)
                {
                    MessageBox.Show("Thêm thành công!\n Mã phòng ban là:'" + truyen + "'");
                    
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

        private void BtnXoaPB_Click(object sender, EventArgs e)
        {
               
            DialogResult thongbao;
            thongbao = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                c.connect();
                string sql2 = "delete from PHONGBAN  where MaPB='" + lblMaPB.Text + "'";
                SqlCommand cmd = new SqlCommand(sql2, c.conn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                MessageBox.Show("Xóa thành công!");
                c.disconnect();
                Loaddata(sql);                
            }
        }

        private void DataGridViewPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblMaPB.Text = dataGridViewPhongBan.CurrentRow.Cells[0].Value.ToString();
            txtTenPB.Text = dataGridViewPhongBan.CurrentRow.Cells[1].Value.ToString();
            txtDiaChiPB.Text = dataGridViewPhongBan.CurrentRow.Cells[2].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
