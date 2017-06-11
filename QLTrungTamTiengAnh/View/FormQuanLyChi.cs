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
    public partial class FormQuanLyChi : Form
    {
        public FormQuanLyChi()
        {
            InitializeComponent();
        }
        private void FormQuanLyChi_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void btnThemPhieuChi_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormPhieuChiTietLuong());
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietKhoanChi.SelectedRows.Count == 1)
            {
                string soPhieuChi = dgvChiTietKhoanChi.SelectedRows[0].Cells[0].Value.ToString();
                FormPhieuChiTietLuong form = new FormPhieuChiTietLuong();
                form.PutExtra(soPhieuChi, false);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng trong bảng để xem chi tiết khoản chi");
            }

        }
        private void btnSuaPhieuChi_Click(object sender, EventArgs e)
        {
            if (dgvChiTietKhoanChi.SelectedRows.Count == 1)
            {
                string soPhieuChi = dgvChiTietKhoanChi.SelectedRows[0].Cells[0].Value.ToString();
                FormPhieuChiTietLuong form = new FormPhieuChiTietLuong();
                form.PutExtra(soPhieuChi, true);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một mục trong bảng để cập nhật khoản chi");
            }
        }
        private void btnXoaPhieuChi_Click(object sender, EventArgs e)
        {

            if (dgvChiTietKhoanChi.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa " + dgvChiTietKhoanChi.SelectedRows.Count + " phiếu chi?",
                    "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvChiTietKhoanChi.SelectedRows)
                    {
                        string soPhieuChi = row.Cells[0].Value.ToString();
                        DataIO.DeleteItem("tb_PhieuChi", "SoPhieuChi = '" + soPhieuChi + "'");
                    }
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng trong bảng để xóa phiếu chi ");
            }
        }
        private void RefreshData()
        {
            DataTable dt = DataIO.GetData("SELECT * FROM vw_PhieuChi");
            dgvChiTietKhoanChi.DataSource = dt;
        }
    }
}
