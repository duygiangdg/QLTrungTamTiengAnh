using QLTrungTamTiengAnh.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.View
{
    public partial class FormDanhSachKhachHang : Form, IRefreshable
    {
        private Filter filter;
        public FormDanhSachKhachHang()
        {
            InitializeComponent();
            filter = new Filter();
        }

        private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnThemHoSo_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormHoSoKhachHang());
        }

        private void btnXemHoSo_Click(object sender, EventArgs e)
        {       
            if (dgvDSKhachHang.SelectedRows.Count == 1)
            {
                string maKhachHang = dgvDSKhachHang.SelectedRows[0].Cells[0].Value.ToString();
                FormHoSoKhachHang form = new FormHoSoKhachHang();
                form.PutExtra(maKhachHang, false);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng trong bảng để xem hồ sơ");
            }
        }

        private void btnSuaHoSo_Click(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count == 1)
            {
                string maKhachHang = dgvDSKhachHang.SelectedRows[0].Cells[0].Value.ToString();
                FormHoSoKhachHang form = new FormHoSoKhachHang();
                form.PutExtra(maKhachHang, true);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng trong bảng để cập nhật hồ sơ");
            }
        }

        private void btnXoaHoSo_Click(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa " + dgvDSKhachHang.SelectedRows.Count + " hồ sơ khách hàng?", 
                    "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach(DataGridViewRow row in dgvDSKhachHang.SelectedRows)
                    {
                        string maKhachHang = row.Cells[0].Value.ToString();
                        DataIO.DeleteItem("tb_KhachHang", "MaKhachHang = '" + maKhachHang + "'");
                    }
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng trong bảng để xóa hồ sơ");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            dgvDSKhachHang.Search(query);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbbNhanVien.Text = "";
            cbbTinhThanh.Text = "";
            cbbQuanHuyen.Text = "";
            cbbXaPhuong.Text = "";
            cbbTruong.Text = "";
            cbbNamSinh.Text = "";
            radNam.Checked = false;
            radNu.Checked = false;
            dtpNgayTaoTu.Text = "";
            dtpNgayTaoDen.Text = "";
        }

        private void SetFilter()
        {
            filter.Clear();
            filter.AddCondition("[Mã KH] = MaKhachHang");

            string tinhThanh = cbbTinhThanh.Text;
            if (!tinhThanh.Equals(""))
            {
                filter.AddCondition("TinhThanh = N'" + tinhThanh + "'");
            }

            string quanHuyen = cbbQuanHuyen.Text;
            if (!quanHuyen.Equals(""))
            {
                filter.AddCondition("QuanHuyen = N'" + quanHuyen + "'");
            }

            string xaPhuong = cbbXaPhuong.Text;
            if (!xaPhuong.Equals(""))
            {
                filter.AddCondition("XaPhuong = N'" + xaPhuong + "'");
            }

            string truong = cbbTruong.Text;
            if (!truong.Equals(""))
            {
                filter.AddCondition("Truong = N'" + truong + "'");
            }

            if (radNam.Checked)
            {
                filter.AddCondition("GioiTinh = 1");
            }
            else if (radNu.Checked)
            {
                filter.AddCondition("GioiTinh = 0");
            }

            /*
            string namSinh = cbbNamSinh.Text;
            if (!namSinh.Equals(""))
            {
                filter.AddCondition("NamSinh = '" + namSinh + "'");
            }*/
        }

        private void GetFilterOptions()
        {
            string tinhThanh = cbbTinhThanh.Text;
            DataTable dtTinhThanh = DataIO.GetData("SELECT DISTINCT TinhThanh FROM tb_KhachHang WHERE TinhThanh IS NOT NULL");
            cbbTinhThanh.DataSource = dtTinhThanh;
            cbbTinhThanh.DisplayMember = "TinhThanh";
            cbbTinhThanh.Text = tinhThanh;

            string quanHuyen = cbbQuanHuyen.Text;
            DataTable dtQuanHuyen = DataIO.GetData("SELECT DISTINCT QuanHuyen FROM tb_KhachHang WHERE QuanHuyen IS NOT NULL");
            cbbQuanHuyen.DataSource = dtQuanHuyen;
            cbbQuanHuyen.DisplayMember = "QuanHuyen";
            cbbQuanHuyen.Text = quanHuyen;

            string xaPhuong = cbbXaPhuong.Text;
            DataTable dtXaPhuong = DataIO.GetData("SELECT DISTINCT XaPhuong FROM tb_KhachHang WHERE XaPhuong IS NOT NULL");
            cbbXaPhuong.DataSource = dtXaPhuong;
            cbbXaPhuong.DisplayMember = "XaPhuong";
            cbbXaPhuong.Text = xaPhuong;

            string truong = cbbTruong.Text;
            DataTable dtTruong = DataIO.GetData("SELECT DISTINCT Truong FROM tb_KhachHang WHERE Truong IS NOT NULL");
            cbbTruong.DataSource = dtTruong;
            cbbTruong.DisplayMember = "Truong";
            cbbTruong.Text = truong;

            /*DataTable dtNamSinh = DataIO.GetData("SELECT DISTINCT NamSinh FROM tb_KhachHang WHERE NamSinh IS NOT NULL");
            cbbNamSinh.DataSource = dtNamSinh;
            cbbNamSinh.DisplayMember = "NamSinh";
            cbbNamSinh.SelectedIndex = -1;*/
        }

        public void RefreshData()
        {
            SetFilter();
            string selectClause = "SELECT vw_KhachHang.* FROM vw_KhachHang, tb_KhachHang";
            DataTable dt = DataIO.GetData(selectClause + filter.GetWhereClause());
            dgvDSKhachHang.DataSource = dt;
            GetFilterOptions();
        }
    }
}
