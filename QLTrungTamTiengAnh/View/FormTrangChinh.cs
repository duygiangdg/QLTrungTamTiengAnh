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
            DataTable khachHangTable = DatabaseService.GetData("vw_KhachHang");
            dgvDSKhachHang.DataSource = khachHangTable;

            DataTable hocVienTable = DatabaseService.GetData("vw_HocVien");
            dgvDSHocVien.DataSource = hocVienTable;

            DataTable troGiangTable = DatabaseService.GetData("vw_TroGiang");
            dgvDSTroGiang.DataSource = troGiangTable;

            DataTable lopTable = DatabaseService.GetData("vw_Lop");
            dgvDSLop.DataSource = lopTable;

            DataTable phieuDangKyTable = DatabaseService.GetData("vw_PhieuDangKy");
            dgvDSPhieuDangKy.DataSource = phieuDangKyTable;

            DataTable quaTrinhCSKHTable = DatabaseService.GetData("vw_QuaTrinhCSKH");
            dgvQuaTrinhCSKH.DataSource = quaTrinhCSKHTable;

            DataTable ketQuaHocTapTable = DatabaseService.GetData("vw_KetQuaHocTap");
            dgvKetQuaHocTap.DataSource = ketQuaHocTapTable;

            DataTable mucHocPhiTable = DatabaseService.GetData("vw_MucHocPhi");
            dgvMucHocPhi.DataSource = mucHocPhiTable;

            DataTable phieuThuTable = DatabaseService.GetData("vw_PhieuThu");
            dgvDSPhieuThu.DataSource = phieuThuTable;
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            (new FormThongTinKhachHang()).PutExtra(GetMaKhachHang()).SetMode(FormDetail.MODE_EDIT).ShowDialog();
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            (new FormThongTinKhachHang()).ShowDialog();
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            (new FormThongTinKhachHang()).PutExtra(GetMaKhachHang()).SetMode(FormDetail.MODE_VIEW).ShowDialog();
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

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            string maKhachHang = GetMaKhachHang();
            DatabaseService.DeleteItem("tb_KhachHang", "MaKhachHang", maKhachHang);
            capNhatDanhSach();
        }

        private string GetMaKhachHang()
        {
            return dgvDSKhachHang.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void FormTranhChinh_Activated(object sender, EventArgs e)
        {
            capNhatDanhSach();
        }
    }
}
