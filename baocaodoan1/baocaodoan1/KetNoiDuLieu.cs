using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace baocaodoan1
{
    class KetNoiDuLieu
    {
        public SqlConnection conn;
        
        public void connect()
        {
            string strcon = "Data Source=DESKTOP-K0T6RCJ;Initial Catalog=QuanLyNhanVien;Integrated Security=True";
            try
            {
                conn = new SqlConnection(strcon);
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void disconnect()
        {           
            conn.Dispose();
            conn.Close();
            conn = null;
        }      
    }
}
