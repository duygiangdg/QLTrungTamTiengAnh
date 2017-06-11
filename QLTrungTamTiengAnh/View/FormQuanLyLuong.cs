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
    public partial class FormQuanLyLuong : Form
    {
        public FormQuanLyLuong()
        {
            InitializeComponent();
        }
        private void FormQuanLyLuong_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void btnTraLuong_Click(object sender, EventArgs e)
        {
            string maNhanVien = dgvChiTietLuong.SelectedRows[0].Cells[0].Value.ToString();
            FormChiTietLuong form = new FormChiTietLuong();
            form.PutExtra (maNhanVien);
            FormDieuHuong.Instance.CreateTab(form);
        }
        private void RefreshData()
        {
            DataTable dt = DataIO.GetData("SELECT * FROM vw_Luong");
            dgvChiTietLuong.DataSource = dt;
        }
    }
}
