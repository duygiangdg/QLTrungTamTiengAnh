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
            DataTable khachHangTable = DBHelper.GetData("tb_KhachHang");
            dgvDSKhachHang.DataSource = khachHangTable;

            DataTable hocVienTable = DBHelper.GetData("tb_HocVien");
            dgvDSHocVien.DataSource = hocVienTable;

            DataTable troGiangTable = DBHelper.GetData("tb_TroGiang");
            dgvDSTroGiang.DataSource = troGiangTable;

            DataTable lopTable = DBHelper.GetData("vw_Lop");
            dgvDSLop.DataSource = lopTable;
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            (new FormThongTinKhachHang()).PutExtra("test").SetMode(FormDetail.MODE_EDIT).ShowDialog();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            (new FormThongTinKhachHang()).ShowDialog();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            (new FormThongTinKhachHang()).PutExtra("test").SetMode(FormDetail.MODE_VIEW).ShowDialog();
        }

        private void ribDieuHuong_SelectedRibbonTabChanged(object sender, EventArgs e)
        {
            int index = 0;
            if (this.ribMenu.SelectedRibbonTabItem == ribbonTabItem0)
            {
                index = 0;
            }
            else if (this.ribMenu.SelectedRibbonTabItem == ribbonTabItem1)
            {
                index = 1;
            }
            else if (this.ribMenu.SelectedRibbonTabItem == ribbonTabItem2)
            {
                index = 2;
            }
            else if (this.ribMenu.SelectedRibbonTabItem == ribbonTabItem3)
            {
                index = 3;
            }
            else if (this.ribMenu.SelectedRibbonTabItem == ribbonTabItem4)
            {
                index = 4;
            }
            else if (this.ribMenu.SelectedRibbonTabItem == ribbonTabItem5)
            {
                index = 5;
            }
            else if (this.ribMenu.SelectedRibbonTabItem == ribbonTabItem6)
            {
                index = 6;
            }
            else if (this.ribMenu.SelectedRibbonTabItem == ribbonTabItem7)
            {
                index = 7;
            }
            else if (this.ribMenu.SelectedRibbonTabItem == ribbonTabItem8)
            {
                index = 8;
            }
            else if (this.ribMenu.SelectedRibbonTabItem == ribbonTabItem9)
            {
                index = 9;
            }

            if (this.tabDanhSach.SelectedTabIndex > -1)
            {
                while (this.tabDanhSach.SelectedTabIndex < index)
                {
                    this.tabDanhSach.SelectNextTab();
                }
                while (this.tabDanhSach.SelectedTabIndex > index)
                {
                    this.tabDanhSach.SelectPreviousTab();
                }
            }
        }

        private void applicationButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
