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
    public partial class FormDanhSachLopHoc : Form, IRefreshable
    {
        Filter filter;
        public FormDanhSachLopHoc()
        {
            InitializeComponent();
            filter = new Filter();
        }

        private void FormDanhSachLopHoc_Load(object sender, EventArgs e)
        {
            RefreshData();
            RefreshFilter();
        }

        public void RefreshData()
        {
            SetFilter();
            string selectClause = "SELECT vw_Lop.* FROM vw_Lop, tb_Lop";
            DataTable dt = DataIO.GetData(selectClause + filter.GetWhereClause());
            dgvDSLopHoc.DataSource = dt;
        }

        private void SetFilter()
        {
            filter.Clear();
            filter.AddCondition("[Mã lớp] = MaLop");

            string maHocPhan = cbbHocPhan.SelectedValue as string;
            if (maHocPhan != null)
            {
                filter.AddCondition("MaHocPhan = '" + maHocPhan + "'");
            }

            string maGiangVien = cbbGiangVien.SelectedValue as string;
            if (maGiangVien!=null)
            {
                filter.AddCondition("MaGiangVien = '" + maGiangVien + "'");
            }

            string maTroGiang = cbbTroGiang.SelectedValue as string;
            if (maTroGiang != null)
            {
                filter.AddCondition("MaTroGiang = '" + maTroGiang + "'");
            }
            
            if (radDuKien.Checked)
            {
                filter.AddCondition("TrangThai = N'Dự kiến'");
            } else if (radDangHoc.Checked)
            {
                filter.AddCondition("TrangThai = N'Đang học'");
            } else if (radKetThuc.Checked)
            {
                filter.AddCondition("TrangThai = N'Kết thúc'");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormThongTinLopHoc());
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dgvDSLopHoc.SelectedRows.Count == 1)
            {
                string maLopHoc = dgvDSLopHoc.SelectedRows[0].Cells[0].Value.ToString();
                FormThongTinLopHoc form = new FormThongTinLopHoc();
                form.PutExtra(maLopHoc, false);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một lớp học trong bảng để xem hồ sơ");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSLopHoc.SelectedRows.Count == 1)
            {
                string maLopHoc = dgvDSLopHoc.SelectedRows[0].Cells[0].Value.ToString();
                FormThongTinLopHoc form = new FormThongTinLopHoc();
                form.PutExtra(maLopHoc, true);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một lớp học trong bảng để cập nhật hồ sơ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSLopHoc.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa " + dgvDSLopHoc.SelectedRows.Count + " lớp học?",
                    "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvDSLopHoc.SelectedRows)
                    {
                        string maLop = row.Cells[0].Value.ToString();
                        DataIO.DeleteItem("tb_Lop", "MaLop = '" + maLop + "'");
                    }
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng trong bảng để xóa hồ sơ");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            RefreshFilter();
        }

        private void RefreshFilter()
        {
            string hocPhan = cbbHocPhan.Text;
            DataTable dtHocPhan = DataIO.GetData("SELECT MaHocPHan, TenHocPhan FROM tb_HocPhan");
            cbbHocPhan.DataSource = dtHocPhan;
            cbbHocPhan.DisplayMember = "TenHocPhan";
            cbbHocPhan.ValueMember = "MaHocPhan";
            cbbHocPhan.Text = hocPhan;

            string giangVien = cbbGiangVien.Text;
            DataTable dtGiangVien = DataIO.GetData("SELECT MaNhanVien, HoTen FROM tb_NhanVien WHERE MaChucVu = 'CV01'");
            cbbGiangVien.DataSource = dtGiangVien;
            cbbGiangVien.DisplayMember = "HoTen";
            cbbGiangVien.ValueMember = "MaNhanVien";
            cbbGiangVien.Text = giangVien;

            string troGiang = cbbTroGiang.Text;
            DataTable dtTroGiang = DataIO.GetData("SELECT MaNhanVien, HoTen FROM tb_NhanVien WHERE MaChucVu = 'CV02'");
            cbbTroGiang.DataSource = dtTroGiang;
            cbbTroGiang.DisplayMember = "HoTen";
            cbbTroGiang.ValueMember = "MaNhanVien";
            cbbTroGiang.Text = troGiang;

            cbbHocPhan.SelectedIndex = -1;
            cbbGiangVien.SelectedIndex = -1;
            cbbTroGiang.SelectedIndex = -1;
            radDuKien.Checked = false;
            radDangHoc.Checked = false;
            radKetThuc.Checked = false;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            dgvDSLopHoc.Search(query);
        }
    }
}
