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
    public partial class FormDanhSachChucVu : FormInput, IRefreshable
    {
        public FormDanhSachChucVu()
        {
            InitializeComponent();
        }

        private void FormDanhSachChucVu_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            DataTable dt = DataIO.GetData("SELECT * FROM vw_ChucVu");
            dgvDSChucVu.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ChucVu chucVu = new ChucVu();
            chucVu.TenChucVu = txtTenChucVu.Text;
            chucVu.LuongCoBan = Decimal.Parse(txtLuongCoBan.Text);
            DataIO.AddItem(chucVu, "tb_ChucVu");
            MessageBox.Show("Thêm chức vụ thành công");
            RefreshData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSChucVu.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSChucVu.SelectedRows[0];
                ChucVu chucVu = new ChucVu();
                chucVu.MaChucVu = row.Cells["Mã CV"].Value.ToString();
                chucVu.TenChucVu = txtTenChucVu.Text;
                chucVu.LuongCoBan = Decimal.Parse(txtLuongCoBan.Text);
                DataIO.UpdateItem(chucVu, "tb_ChucVu", "MaChucVu");
                MessageBox.Show("Cập nhật thông tin chức vụ thành công");
                RefreshData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSChucVu.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSChucVu.SelectedRows[0];
                string maChucVu = row.Cells["Mã CV"].Value.ToString();
                if (maChucVu.Equals("CV01") || maChucVu.Equals("CV02"))
                {
                    MessageBox.Show("Đây là chức vụ quan trọng, không thể xóa!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DataIO.DeleteItem("tb_ChucVu", "MaChucVu = '" + maChucVu + "'");
                    MessageBox.Show("Xóa chức vụ thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshData();
                }
            }
        }

        private void dgvDSChucVu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSChucVu.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSChucVu.SelectedRows[0];
                txtTenChucVu.Text = row.Cells["Tên chức vụ"].Value.ToString();
                txtLuongCoBan.Text = row.Cells["Lương cơ bản"].Value.ToString();
            }
        }
    }
}
