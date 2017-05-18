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
        public FormChamSocKhachHang()
        {
            InitializeComponent();
        }

        private void btnGuiEmail_Click(object sender, EventArgs e)
        {
            (new FormGuiEmail()).ShowDialog();
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
            DataTable dt = DataIO.GetData("SELECT vw_KhachHang.* FROM vw_KhachHang, tb_KhachHang WHERE vw_KhachHang.[Mã KH] = tb_KhachHang.[MaKhachHang] AND TrangThai = N'Chưa học'");
            dgvDSKhachHang.DataSource = dt;
        }
    }
}
