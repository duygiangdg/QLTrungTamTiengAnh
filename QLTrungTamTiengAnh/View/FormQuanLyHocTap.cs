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
    public partial class FormQuanLyHocTap : Form
    {
        public FormQuanLyHocTap()
        {
            InitializeComponent();
        }

        private void FormQuanLyHocTap_Load(object sender, EventArgs e)
        {
            DataTable dt = DataIO.GetData("SELECT vw_KhachHang.* FROM vw_KhachHang, tb_KhachHang WHERE vw_KhachHang.[Mã KH] = tb_KhachHang.[MaKhachHang] AND TrangThai != N'Chưa học'");
            dgvDSHocVien.DataSource = dt;
        }

        private void btnDangKyHoc_Click(object sender, EventArgs e)
        {
            if (dgvDSHocVien.SelectedRows.Count == 1)
            {
                string maKhachHang = dgvDSHocVien.SelectedRows[0].Cells[0].Value.ToString();
                FormThongTinHocTap form = new FormThongTinHocTap();
                form.PutExtra(maKhachHang, true);
                form.Text = "Đăng ký học tập";
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một học viên trong bảng để đăng ký học");
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvDSHocVien.SelectedRows.Count == 1)
            {
                string maKhachHang = dgvDSHocVien.SelectedRows[0].Cells[0].Value.ToString();
                FormThongTinHocTap form = new FormThongTinHocTap();
                form.PutExtra(maKhachHang, false);
                form.Text = "Thông tin học tập";
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một học viên trong bảng để xem thông tin học tập");
            }
        }

        private void btnGuiEmail_Click(object sender, EventArgs e)
        {
            (new FormGuiEmail()).ShowDialog();
        }
    }
}
