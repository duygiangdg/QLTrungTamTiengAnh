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
    }
}
