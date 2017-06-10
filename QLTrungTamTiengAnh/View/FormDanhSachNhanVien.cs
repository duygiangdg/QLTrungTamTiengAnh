using QLTrungTamTiengAnh.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.View
{
    public partial class FormDanhSachNhanVien : Form
    {
        private Filter filter;
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
            filter = new Filter();
        }

        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormHoSoNhanVien());
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dgvDSNhanVien.SelectedRows.Count == 1)
            {
                string maNhanVien = dgvDSNhanVien.SelectedRows[0].Cells[0].Value.ToString();
                FormHoSoNhanVien form = new FormHoSoNhanVien();
                form.PutExtra(maNhanVien, false);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một nhân viên trong bảng để xem hồ sơ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSNhanVien.SelectedRows.Count == 1)
            {
                string maNhanVien = dgvDSNhanVien.SelectedRows[0].Cells[0].Value.ToString();
                FormHoSoNhanVien form = new FormHoSoNhanVien();
                form.PutExtra(maNhanVien, true);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một nhân viên trong bảng để cập nhật hồ sơ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSNhanVien.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa " + dgvDSNhanVien.SelectedRows.Count + " hồ sơ nhân viên?",
                    "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvDSNhanVien.SelectedRows)
                    {
                        string maNhanVien = row.Cells[0].Value.ToString();
                        DataIO.DeleteItem("tb_NhanVien", "MaNhanVien = '" + maNhanVien + "'");
                    }
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Hãy chọn nhân viên trong bảng để xóa hồ sơ");
            }
        }

        private void RefreshData()
        {
            SetFilter();
            string selectClause = "SELECT vw_NhanVien.* FROM vw_NhanVien, tb_NhanVien";
            DataTable dt = DataIO.GetData(selectClause + filter.GetWhereClause());
            dgvDSNhanVien.DataSource = dt;
            GetFilterOptions();
        }

        private void SetFilter()
        {
            filter.Clear();
            filter.AddCondition("[Mã NV] = MaNhanVien");

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
            DataTable dtTinhThanh = DataIO.GetData("SELECT DISTINCT TinhThanh FROM tb_NhanVien WHERE TinhThanh IS NOT NULL");
            cbbTinhThanh.DataSource = dtTinhThanh;
            cbbTinhThanh.DisplayMember = "TinhThanh";
            cbbTinhThanh.Text = tinhThanh;

            string quanHuyen = cbbQuanHuyen.Text;
            DataTable dtQuanHuyen = DataIO.GetData("SELECT DISTINCT QuanHuyen FROM tb_NhanVien WHERE QuanHuyen IS NOT NULL");
            cbbQuanHuyen.DataSource = dtQuanHuyen;
            cbbQuanHuyen.DisplayMember = "QuanHuyen";
            cbbQuanHuyen.Text = quanHuyen;

            string xaPhuong = cbbXaPhuong.Text;
            DataTable dtXaPhuong = DataIO.GetData("SELECT DISTINCT XaPhuong FROM tb_NhanVien WHERE XaPhuong IS NOT NULL");
            cbbXaPhuong.DataSource = dtXaPhuong;
            cbbXaPhuong.DisplayMember = "XaPhuong";
            cbbXaPhuong.Text = xaPhuong;

            string truong = cbbTruong.Text;
            DataTable dtTruong = DataIO.GetData("SELECT DISTINCT Truong FROM tb_NhanVien WHERE Truong IS NOT NULL");
            cbbTruong.DataSource = dtTruong;
            cbbTruong.DisplayMember = "Truong";
            cbbTruong.Text = truong;

            /*DataTable dtNamSinh = DataIO.GetData("SELECT DISTINCT NamSinh FROM tb_KhachHang WHERE NamSinh IS NOT NULL");
            cbbNamSinh.DataSource = dtNamSinh;
            cbbNamSinh.DisplayMember = "NamSinh";
            cbbNamSinh.SelectedIndex = -1;*/
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
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
    }
}
