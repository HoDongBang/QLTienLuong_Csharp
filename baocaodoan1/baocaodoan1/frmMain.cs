using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baocaodoan1
{
    public partial class frmMain : Form
    {
        string nhan;
        public frmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        //nhận giá trị tên tài khoản từ form1
        public frmMain(string giatrinhan) : this()
        {
            nhan = giatrinhan;
            lblHienTen.Text=nhan ;
        }

        //kiểm tra xem form có hiển thị hay không
        private bool CheckExitsForm(string name)
        {
            bool check = false;
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name==name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        //kiểm tra nếu form mở rồi thì kích hoạt lại
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void ThôngTinNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmNhanVien"))
            {
                frmNhanVien frm = new frmNhanVien();
                frm.MdiParent = this;
                frm.Name = "frmNhanVien";
                frm.Show();
            }
            else ActiveChildForm("frmNhanVien");
        }

        private void ThôngTinPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmPhongBan"))
            {
                frmPhongBan frm = new frmPhongBan();
                frm.MdiParent = this;
                frm.Name = "frmPhongBan";
                frm.Show();
            }
            else ActiveChildForm("frmPhongBan");
        }

        private void ChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmChucVu"))
            {
                frmChucVu frm = new frmChucVu();
                frm.MdiParent = this;
                frm.Name = "frmChucVu";
                frm.Show();
            }
            else ActiveChildForm("frmChucVu");
        }

        private void MứcLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmMucLuong"))
            {
                frmMucLuong frm = new frmMucLuong();
                frm.MdiParent = this;
                frm.Name = "frmMucLuong";
                frm.Show();
            }
            else ActiveChildForm("frmMucLuong");
        }

        private void ChuyênMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmChuyenMon"))
            {
                frmChuyenMon frm = new frmChuyenMon();
                frm.MdiParent = this;
                frm.Name = "frmChuyenMon";
                frm.Show();
            }
            else ActiveChildForm("frmChuyenMon");
        }
        private void TrìnhĐộHọcVấnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmTDHV"))
            {
                frmTDHV frm = new frmTDHV();
                frm.MdiParent = this;
                frm.Name = "frmTDHV";
                frm.Show();
            }
            else ActiveChildForm("frmTDHV");
        }

        private void KhenThưởngKỉLuậtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmKTKL"))
            {
                frmKTKL frm = new frmKTKL();
                frm.MdiParent = this;
                frm.Name = "frmKTKL";
                frm.Show();
            }
            else ActiveChildForm("frmKTKL");
        }

        private void PhiếuLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmXuatPL"))
            {
                frmXuatPL frm = new frmXuatPL();
                frm.MdiParent = this;
                frm.Name = "frmXuatPL";
                frm.Show();
            }
            else ActiveChildForm("frmXuatPL");
        }

        private void ThốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmThongKe"))
            {
                frmThongKe frm = new frmThongKe();
                frm.MdiParent = this;
                frm.Name = "frmThongKe";
                frm.Show();
            }
            else ActiveChildForm("frmThongKe");
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void KhenThưởngKỉLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmDSKTKL"))
            {
                frmDSKTKL frm = new frmDSKTKL();
                frm.MdiParent = this;
                frm.Name = "frmDSKTKL";
                frm.Show();
            }
            else ActiveChildForm("frmDSKTKL");
        }

        private void BảngLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmBangLuong"))
            {
                frmBangLuong frm = new frmBangLuong();
                frm.MdiParent = this;
                frm.Name = "frmBangLuong";
                frm.Show();
            }
            else ActiveChildForm("frmBangLuong");
        }

        private void PhiếuLươngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("frmPhieuLuong"))
            {
                frmPhieuLuong frm = new frmPhieuLuong();
                frm.MdiParent = this;
                frm.Name = "frmPhieuLuong";
                frm.Show();
            }
            else ActiveChildForm("frmPhieuLuong");
        }
    }
}
