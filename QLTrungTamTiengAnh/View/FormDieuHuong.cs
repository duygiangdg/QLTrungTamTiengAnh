using DevComponents.DotNetBar;
using DevExpress.XtraReports.UI;
using QLTrungTamTiengAnh.Control;
using System;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.View
{
    public partial class FormDieuHuong : Office2007Form
    {
        private static FormDieuHuong instance;
        public static FormDieuHuong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormDieuHuong();
                }
                return instance;
            }
        }

        private FormDieuHuong()
        {
            InitializeComponent();
        }

        private void FormDieuHuong_Load(object sender, EventArgs e)
        {
            (new FormDangNhap()).ShowDialog();
        }

        public void CreateTab(Form form)
        {
            TabItem tabItem = tabControl.CreateTab(form.Text);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            tabItem.AttachedControl.Controls.Add(form);
            tabControl.SelectedTab = tabItem;
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            CreateTab(new FormDanhSachKhachHang());
        }

        private void btnQLHocVien_Click(object sender, EventArgs e)
        {
            CreateTab(new FormQuanLyHocTap());
        }

        private void btnQLHocPhan_Click(object sender, EventArgs e)
        {
            CreateTab(new FormDanhMucHocPhan());
        }

        private void btnQLGiangVien_Click(object sender, EventArgs e)
        {
            CreateTab(new FormDanhSachNhanVien());
        }

        private void btnQLLopHoc_Click(object sender, EventArgs e)
        {
            CreateTab(new FormDanhSachLopHoc());
        }

        private void btnQLChucVu_Click(object sender, EventArgs e)
        {
            CreateTab(new FormDanhSachChucVu());
        }

        private void btnCSKhachHang_Click(object sender, EventArgs e)
        {
            CreateTab(new FormChamSocKhachHang());
        }

        private void btnQLHocTap_Click(object sender, EventArgs e)
        {
            CreateTab(new FormQuanLyHocTap());
        }

        private void btnXepTKB_Click(object sender, EventArgs e)
        {
            CreateTab(new FormLichTuan());
        }

        private void btnDanhGiaHocTap_Click(object sender, EventArgs e)
        {
            CreateTab(new FormDanhGiaHocTap());
        }

        private void tabControl_SelectedTabChanged(object sender, TabStripTabChangedEventArgs e)
        {
            if (tabControl.SelectedTab.AttachedControl.Controls.Count > 0)
            {
                System.Windows.Forms.Control child = tabControl.SelectedTab.AttachedControl.Controls[0];
                if (typeof(IRefreshable).IsAssignableFrom(child.GetType()))
                {
                    ((IRefreshable)child).RefreshData();
                }
            }
        }

        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            CreateTab(new FormQuanLyNguoiDung());
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            (new FormDoiMatKhau()).ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            (new FormDangNhap()).ShowDialog();
        }

        private void btnThoatChuongTrinh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDieuHuong_Activated(object sender, EventArgs e)
        {
            if (Setting.Authority == Setting.ADMIN)
            {
                DatQuyenAdmin();   
            } else
            {
                DatQuyenStaff();
            }
        }

        private void DatQuyenAdmin()
        {
            txtBaoCaoThongKe.Visible = true;
            btnQuanLyNguoiDung.Visible = true;
            btnDoanhThuTheoThang.Visible = true;
            btnDoanhThuTheoNam.Visible = true;
            btnDoanhSoTheoThang.Visible = true;
            btnChiPhiTheoThang.Visible = true;
            btnTiLeCSKH.Visible = true;
            btnChiTietHocPhi.Visible = true;
            btnDanhSachKhachHang.Visible = true;
            btnThieuHocPhi.Visible = true;
            btnLichHoc.Visible = true;
            btnLuongNhanVien.Visible = true;
            btnNhatKyCSKH.Visible = true;
            btnSiSoLop.Visible = true;
        }

        private void DatQuyenStaff()
        {
            txtBaoCaoThongKe.Visible = false;
            btnQuanLyNguoiDung.Visible = false;
            btnDoanhThuTheoThang.Visible = false;
            btnDoanhThuTheoNam.Visible = false;
            btnDoanhSoTheoThang.Visible = false;
            btnChiPhiTheoThang.Visible = false;
            btnTiLeCSKH.Visible = false;
            btnChiTietHocPhi.Visible = false;
            btnDanhSachKhachHang.Visible = false;
            btnThieuHocPhi.Visible = false;
            btnLichHoc.Visible = false;
            btnLuongNhanVien.Visible = false;
            btnNhatKyCSKH.Visible = false;
            btnSiSoLop.Visible = false;
        }

        private void btnDoanhThuTheoThang_Click(object sender, EventArgs e)
        {
            Report.DoanhThuTheoThang report = new Report.DoanhThuTheoThang();
            report.ShowPreviewDialog();
        }

        private void btnQLKhuyenMai_Click(object sender, EventArgs e)
        {
            CreateTab(new FormQLKhuyenMai());
        }

        private void btnDoanhThuTheoNam_Click(object sender, EventArgs e)
        {
            Report.DoanhThuTheoNam report = new Report.DoanhThuTheoNam();
            report.ShowPreviewDialog();
        }

        private void btnDoanhSoTheoThang_Click(object sender, EventArgs e)
        {
            Report.DoanhSoTheoThang report = new Report.DoanhSoTheoThang();
            report.ShowPreviewDialog();
        }

        private void btnChiPhiTheoThang_Click(object sender, EventArgs e)
        {
            Report.ChiPhiTheoThang report = new Report.ChiPhiTheoThang();
            report.ShowPreviewDialog();
        }

        private void btnChiTietHocPhi_Click(object sender, EventArgs e)
        {
            Report.ChiTietHocPhi report = new Report.ChiTietHocPhi();
            report.ShowPreviewDialog();
        }

        private void btnDanhSachKhachHang_Click(object sender, EventArgs e)
        {
            Report.DanhSachKhachHang report = new Report.DanhSachKhachHang();
            report.ShowPreviewDialog();
        }

        private void btnThieuHocPhi_Click(object sender, EventArgs e)
        {
            Report.HocVienThieuHocPhi report = new Report.HocVienThieuHocPhi();
            report.ShowPreviewDialog();
        }

        private void btnLuongNhanVien_Click(object sender, EventArgs e)
        {
            Report.LuongNhanVien report = new Report.LuongNhanVien();
            report.ShowPreviewDialog();
        }

        private void btnNhatKyCSKH_Click(object sender, EventArgs e)
        {
            Report.NhatKyCSKH report = new Report.NhatKyCSKH();
            report.ShowPreviewDialog();
        }

        private void btnSiSoLop_Click(object sender, EventArgs e)
        {
            Report.SiSoLop report = new Report.SiSoLop();
            report.ShowPreviewDialog();
        }

        private void btnQuanLyThu_Click(object sender, EventArgs e)
        {
            CreateTab(new FormQuanLyThu());
        }

        private void btnQuanLyChi_Click(object sender, EventArgs e)
        {
            CreateTab(new FormQuanLyChi());
        }

        private void btnQuanLyLuong_Click(object sender, EventArgs e)
        {
            CreateTab(new FormQuanLyLuong());
        }

        private void btnQLHocPhi_Click(object sender, EventArgs e)
        {
            CreateTab(new FormChiTietHocPhi());
        }
    }
}
