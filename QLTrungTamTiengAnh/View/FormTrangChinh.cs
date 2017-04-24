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
            foreach (DataRow row in khachHangTable.Rows)
            {
                dgvDSKhachHang.Rows.Add(row.ItemArray);
            }
        }

        private void btnThemKhachHang_ItemClick(object sender, EventArgs e)
        {
            FormThongTinKhachHang form = new FormThongTinKhachHang();
            form.ShowDialog();
        }

        private void btnSuaKhachHang_ItemClick(object sender, EventArgs e)
        {
            FormThongTinKhachHang form = new FormThongTinKhachHang();
            form.ShowDialog();
        }

        private void btnXoaKhachHang_ItemClick(object sender, EventArgs e)
        {
            FormThongTinKhachHang form = new FormThongTinKhachHang();
            form.ShowDialog();
        }

        private void btnXemChiTiet_ItemClick(object sender, EventArgs e)
        {
            FormThongTinKhachHang form = new FormThongTinKhachHang();
            form.ShowDialog();
        }
    }
}
