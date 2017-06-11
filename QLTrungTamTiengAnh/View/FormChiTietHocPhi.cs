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
    public partial class FormChiTietHocPhi : Form
    {
        public FormChiTietHocPhi()
        {
            InitializeComponent();
        }

        private void FormChiTietHocPhi_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void btnDongHocPhi_Click(object sender, EventArgs e)
        {
            string soPhieuThu = dgvCTHocPhi.SelectedRows[0].Cells[0].Value.ToString();
            FormPhieuThu form = new FormPhieuThu();
            form.PutExtra(soPhieuThu, true);
            FormDieuHuong.Instance.CreateTab(form);
        }       
        private void btnXoaHocPhi_Click(object sender, EventArgs e)
        {      
            if (dgvCTHocPhi.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa " + dgvCTHocPhi.SelectedRows.Count + " chi tiết học phí học viên?",
                    "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvCTHocPhi.SelectedRows)
                    {
                        string maHocVien = row.Cells[0].Value.ToString();
                        DataIO.DeleteItem("vw_ChiTietHocPhi", "MaHocVien = '" + maHocVien + "'");
                    }
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Hãy chọn học viên trong bảng để xóa hồ sơ");
            }
        }

        private void RefreshData()
        {
            DataTable dt = DataIO.GetData("SELECT * FROM vw_ChiTietHocPhi");
            dgvCTHocPhi.DataSource = dt;
        }
    }
}
