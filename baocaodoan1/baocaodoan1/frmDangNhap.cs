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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        KetNoiDuLieu c = new KetNoiDuLieu();
        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDN.Focus();
        }

        //Hiện mật khẩu
        private void ChkHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienMK.Checked)
               txtMatKhau.PasswordChar = '\0';
            else txtMatKhau.PasswordChar = '*';  
        }

        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            c.connect();
            string sql = "select *from TAIKHOAN where TenDangNhap ='" + txtTenDN.Text + "'";
            SqlCommand cmd = new SqlCommand(sql,c.conn);
            SqlDataReader docdata = cmd.ExecuteReader();

            //nếu đọc thành công thì tìm thấy tên tài khoản
            if (docdata.Read())
            {
                docdata.Close();
                docdata.Dispose();
                string sql2 = "select *from TAIKHOAN where TenDangNhap ='" + txtTenDN.Text + "' and MatKhau ='" + txtMatKhau.Text + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, c.conn);
                SqlDataReader docdata2 = cmd2.ExecuteReader();
                //nếu đọc thành công thì đăng nhập thành công
                if (docdata2.Read())
                {
                    docdata2.Close();
                    docdata2.Dispose();
                    frmMain a = new frmMain(txtTenDN.Text);
                    //lấy tên tài khoản qua form Main                  
                    a.ShowDialog();
                }
                else MessageBox.Show("Sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else MessageBox.Show("Tài khoản không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            c.disconnect();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}

