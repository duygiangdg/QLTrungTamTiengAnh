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
    public partial class FormChamSocKhachHang : Form
    {
        private Filter filter;
        public FormChamSocKhachHang()
        {
            InitializeComponent();
            filter = new Filter();
        }

        private void btnGuiEmail_Click(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count > 0)
            {
                List<string> receivers = new List<string>();
                FormGuiEmail form = new FormGuiEmail();
                foreach(DataGridViewRow row in dgvDSKhachHang.SelectedRows)
                {
                    receivers.Add(row.Cells["Email"].Value.ToString());
                }
                form.putExtra(receivers);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hãy chọn các khách hàng bạn muốn gửi email");
            }
        }

        private void btnDangKyHoc_Click(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count == 1)
            {
                string maKhachHang = dgvDSKhachHang.SelectedRows[0].Cells[0].Value.ToString();
                FormThongTinHocTap form = new FormThongTinHocTap();
                form.PutExtra(maKhachHang, true);
                form.Text = "Đăng ký học tập";
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng trong bảng để đăng ký học");
            }     
        }

        private void btnXemNhatKy_Click(object sender, EventArgs e)
        {

        }

        private void FormChamSocKhachHang_Load(object sender, EventArgs e)
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

        private void btnLoc_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            dgvDSKhachHang.Search(query);
        }

        private void RefreshData()
        {
            SetFilter();
            string selectClause = "SELECT vw_KhachHang.* FROM vw_KhachHang, tb_KhachHang";
            DataTable dt = DataIO.GetData(selectClause + filter.GetWhereClause());
            dgvDSKhachHang.DataSource = dt;
            GetFilterOptions();
        }

        private void SetFilter()
        {
            filter.Clear();
            filter.AddCondition("[Mã KH] = MaKhachHang");
            filter.AddCondition("TrangThai = N'Chưa học'");

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
            DataTable dtTinhThanh = DataIO.GetData("SELECT DISTINCT TinhThanh FROM tb_KhachHang WHERE TinhThanh IS NOT NULL AND TrangThai = N'Chưa học'");
            cbbTinhThanh.DataSource = dtTinhThanh;
            cbbTinhThanh.DisplayMember = "TinhThanh";
            cbbTinhThanh.Text = tinhThanh;

            string quanHuyen = cbbQuanHuyen.Text;
            DataTable dtQuanHuyen = DataIO.GetData("SELECT DISTINCT QuanHuyen FROM tb_KhachHang WHERE QuanHuyen IS NOT NULL AND TrangThai = N'Chưa học'");
            cbbQuanHuyen.DataSource = dtQuanHuyen;
            cbbQuanHuyen.DisplayMember = "QuanHuyen";
            cbbQuanHuyen.Text = quanHuyen;

            string xaPhuong = cbbXaPhuong.Text;
            DataTable dtXaPhuong = DataIO.GetData("SELECT DISTINCT XaPhuong FROM tb_KhachHang WHERE XaPhuong IS NOT NULL AND TrangThai = N'Chưa học'");
            cbbXaPhuong.DataSource = dtXaPhuong;
            cbbXaPhuong.DisplayMember = "XaPhuong";
            cbbXaPhuong.Text = xaPhuong;

            string truong = cbbTruong.Text;
            DataTable dtTruong = DataIO.GetData("SELECT DISTINCT Truong FROM tb_KhachHang WHERE Truong IS NOT NULL AND TrangThai = N'Chưa học'");
            cbbTruong.DataSource = dtTruong;
            cbbTruong.DisplayMember = "Truong";
            cbbTruong.Text = truong;

            /*DataTable dtNamSinh = DataIO.GetData("SELECT DISTINCT NamSinh FROM tb_KhachHang WHERE NamSinh IS NOT NULL AND TrangThai = N'Chưa học'");
            cbbNamSinh.DataSource = dtNamSinh;
            cbbNamSinh.DisplayMember = "NamSinh";
            cbbNamSinh.SelectedIndex = -1;*/
        }
    }
}
