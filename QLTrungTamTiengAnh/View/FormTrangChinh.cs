using System;
using System.Data;
using QLTrungTamTiengAnh.Model;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.View
{
    public partial class FormTranhChinh : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public FormTranhChinh()
        {
            InitializeComponent();
        }

        private void FormTrangChinh_Load(object sender, EventArgs e)
        {
            capNhatDanhSach();
        }

        private void capNhatDanhSach()
        {
            DataTable khachHangTable = KhachHangMod.Instance.GetData();
            dgvDSKhachHang.DataSource = khachHangTable;
        }

        private void btnThemKhachHang_MouseClick(object sender, MouseEventArgs e)
        {
            (new FormThongTinKhachHang()).ShowDialog();
        }

        private void btnSuaKhachHang_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnXemChiTiet_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
