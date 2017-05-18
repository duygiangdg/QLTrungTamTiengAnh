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
    public partial class FormDanhSachLopHoc : Form
    {
        public FormDanhSachLopHoc()
        {
            InitializeComponent();
        }

        private void FormDanhSachLopHoc_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            DataTable dt = DataIO.GetData("SELECT * FROM vw_Lop");
            dgvDSLopHoc.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormHoSoKhachHang());
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dgvDSLopHoc.SelectedRows.Count == 1)
            {
                string maLopHoc = dgvDSLopHoc.SelectedRows[0].Cells[0].Value.ToString();
                FormThongTinLopHoc form = new FormThongTinLopHoc();
                //form.PutExtra(maLopHoc, false);
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
                //form.PutExtra(maLopHoc, true);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một lớp học trong bảng để cập nhật hồ sơ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
