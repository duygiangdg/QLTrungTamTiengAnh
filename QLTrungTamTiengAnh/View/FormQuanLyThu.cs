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
    public partial class FormQuanLyThu : Form
    {
        public FormQuanLyThu()
        {
            InitializeComponent();
        }
        private void FormQuanLyThu_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void btnThemPhieuThu_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormPhieuThu());
        }
        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvChiTietKhoanThu.SelectedRows.Count == 1)
            {
                string soPhieuThu = dgvChiTietKhoanThu.SelectedRows[0].Cells[0].Value.ToString();
                FormPhieuThu form = new FormPhieuThu();
                form.PutExtra(soPhieuThu, false);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng trong bảng để xem chi tiết khoản thu");
            }
           
        }
        private void btnSuaPhieuThu_Click(object sender, EventArgs e)
        {
            if (dgvChiTietKhoanThu.SelectedRows.Count == 1)
            {
                string soPhieuThu = dgvChiTietKhoanThu.SelectedRows[0].Cells[0].Value.ToString();
                FormPhieuThu form = new FormPhieuThu();
                form.PutExtra(soPhieuThu, true);
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng trong bảng để cập nhật khoản thu");
            }
        }
        private void btnXoaPhieuThu_Click(object sender, EventArgs e)
        {

            if (dgvChiTietKhoanThu.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa " + dgvChiTietKhoanThu.SelectedRows.Count + " phiếu thu?",
                    "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dgvChiTietKhoanThu.SelectedRows)
                    {
                        string soPhieuThu = row.Cells[0].Value.ToString();
                        DataIO.DeleteItem("tb_PhieuThu", "SoPhieuThu = '" + soPhieuThu + "'");
                    }
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng trong bảng để xóa phiếu thu ");
            }
        }       
        private void RefreshData()
        {
            DataTable dt = DataIO.GetData("SELECT * FROM vw_PhieuThu");
            dgvChiTietKhoanThu.DataSource = dt;
        }
    }
}
