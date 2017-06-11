using QLTrungTamTiengAnh.Model;
using QLTrungTamTiengAnh.Object;
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
    public partial class FormQuanLyNguoiDung : FormInput, IRefreshable
    {
        public FormQuanLyNguoiDung()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            DataTable dt = DataIO.GetData("SELECT MaNguoiDung, TenDangNhap, Quyen FROM tb_NguoiDung");
            dgvDSNguoiDung.DataSource = dt;
        }

        private void dgvDSNguoiDung_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSNguoiDung.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSNguoiDung.SelectedRows[0];
                txtTenDangNhap.Text = row.Cells[1].Value.ToString();
                if (Boolean.Parse(row.Cells[2].Value.ToString()))
                {
                    cbbQuyen.SelectedIndex = 0;
                }
                else
                {
                    cbbQuyen.SelectedIndex = 1;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NguoiDung nguoiDung = new NguoiDung();
            nguoiDung.TenDangNhap = txtTenDangNhap.Text;
            nguoiDung.MatKhau = txtMatKhau.Text;
            if (cbbQuyen.SelectedIndex == 0) nguoiDung.Quyen = true;
            DataIO.AddItem(nguoiDung, "tb_NguoiDung");
            MessageBox.Show("Thêm người dùng thành công");
            RefreshData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSNguoiDung.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSNguoiDung.SelectedRows[0];
                NguoiDung nguoiDung = new NguoiDung();
                nguoiDung.MaNguoiDung = row.Cells[0].Value.ToString();
                nguoiDung.TenDangNhap = txtTenDangNhap.Text;
                nguoiDung.MatKhau = txtMatKhau.Text;
                if (cbbQuyen.SelectedIndex == 0) nguoiDung.Quyen = true;
                DataIO.UpdateItem(nguoiDung, "tb_NguoiDung", "MaNguoiDung");
                MessageBox.Show("Cập nhật thông tin người dùng thành công");
                RefreshData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSNguoiDung.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSNguoiDung.SelectedRows[0];
                string maNguoiDung = row.Cells[0].Value.ToString();
                DataIO.DeleteItem("tb_NguoiDung", "MaNguoiDung = '" + maNguoiDung + "'");
                MessageBox.Show("Xóa người dùng thành công");
                RefreshData();
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            txtMatKhau.Clear();
        }
    }
}
