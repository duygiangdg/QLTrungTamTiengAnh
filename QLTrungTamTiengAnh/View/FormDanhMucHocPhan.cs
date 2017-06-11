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
    public partial class FormDanhMucHocPhan : Form, IRefreshable
    {
        public FormDanhMucHocPhan()
        {
            InitializeComponent();
        }

        private void FormDanhMucHocPhan_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            DataTable dt = DataIO.GetData("SELECT * FROM vw_HocPhan");
            dgvDSHocPhan.DataSource = dt;
        }

        private void dgvDSHocPhan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDSHocPhan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSHocPhan.SelectedRows[0];
                txtTenHocPhan.Text = row.Cells["Tên học phần"].Value.ToString();
                txtMucHocPhi.Text = row.Cells["Mức học phí"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocPhan hocPhan = new HocPhan();
            hocPhan.TenHocPhan = txtTenHocPhan.Text;
            hocPhan.MucHocPhi = Decimal.Parse(txtMucHocPhi.Text);
            DataIO.AddItem(hocPhan, "tb_HocPhan");
            MessageBox.Show("Thêm học phần thành công");
            RefreshData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvDSHocPhan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSHocPhan.SelectedRows[0];
                HocPhan hocPhan = new HocPhan();
                hocPhan.MaHocPhan = row.Cells["Mã HP"].Value.ToString();
                hocPhan.TenHocPhan = txtTenHocPhan.Text;
                hocPhan.MucHocPhi = Decimal.Parse(txtMucHocPhi.Text);
                DataIO.UpdateItem(hocPhan, "tb_HocPhan", "MaHocPhan");
                MessageBox.Show("Cập nhật thông tin học phần thành công");
                RefreshData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSHocPhan.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvDSHocPhan.SelectedRows[0];
                string maHocPhan = row.Cells["Mã HP"].Value.ToString();
                DataIO.DeleteItem("tb_HocPhan", "MaHocPhan = '" + maHocPhan + "'");
                MessageBox.Show("Xóa học phần thành công");
                RefreshData();
            }
        }
    }
}
