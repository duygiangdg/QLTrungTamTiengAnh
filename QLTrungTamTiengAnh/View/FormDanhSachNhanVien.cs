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
        public FormDanhSachNhanVien()
        {
            InitializeComponent();
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
                        DataIO.DeleteItem("tb_NhanVien", "MaNhanVien", maNhanVien);
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
            DataTable dt = DataIO.GetData("SELECT * FROM vw_NhanVien");
            dgvDSNhanVien.DataSource = dt;
        }

        private void FormDanhSachNhanVien_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
