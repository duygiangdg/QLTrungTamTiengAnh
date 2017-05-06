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
    public partial class FormQLKhachHang : Form
    {
        public FormQLKhachHang()
        {
            InitializeComponent();
        }

        private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            dgvDSKhachHang.BindData("vw_KhachHang");
        }

        private void expandablePanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnThemHoSo_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormCTKhachHang());
        }

        private void btnXemHoSo_Click(object sender, EventArgs e)
        {       
            if (dgvDSKhachHang.SelectedRows.Count>0)
            {
                string extra = dgvDSKhachHang.SelectedRows[0].Cells[0].Value.ToString();
                FormCTKhachHang form = new FormCTKhachHang();
                form.PutExtra(extra, FormInput.MODE_VIEW);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng trong bảng để xem hồ sơ");
            }
        }

        private void btnSuaHoSo_Click(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count > 0)
            {
                string extra = dgvDSKhachHang.SelectedRows[0].Cells[0].Value.ToString();
                FormCTKhachHang form = new FormCTKhachHang();
                form.PutExtra(extra, FormInput.MODE_EDIT);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng trong bảng để cập nhật hồ sơ");
            }
        }

        private void btnDangKyHoc_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormDangKyHoc());
        }
    }
}
