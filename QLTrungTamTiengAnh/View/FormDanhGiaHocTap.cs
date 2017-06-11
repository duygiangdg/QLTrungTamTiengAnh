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
    public partial class FormDanhGiaHocTap : Form
    {
        private Filter filter;
        public FormDanhGiaHocTap()
        {
            InitializeComponent();
            filter = new Filter();
        }

        private void SetFilter()
        {
            filter.Clear();
            filter.AddCondition("[Mã HV] = MaKhachHang");
            string maLop = cbbLop.SelectedValue as string;
            filter.AddCondition("MaLop = '" + maLop + "'");
        }

        private void GetFilterOptions()
        {
            DataTable dtLop = DataIO.GetData("SELECT MaLop FROM tb_Lop");
            cbbLop.DataSource = dtLop;
            cbbLop.DisplayMember = "MaLop";
            cbbLop.ValueMember = "MaLop";
        }

        private void RefreshData()
        {
            SetFilter();
            string selectClause = "SELECT vw_BangDiem.* FROM vw_BangDiem, tb_KhachHang";
            DataTable dt = DataIO.GetData(selectClause + filter.GetWhereClause());
            dgvBangDiem.DataSource = dt;
        }

        private void FormDanhGiaHocTap_Load(object sender, EventArgs e)
        {
            GetFilterOptions();
            RefreshData();
        }

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void cbbHocPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvBangDiem_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBangDiem.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBangDiem.SelectedRows[0];
                txtNhanXet.Text = row.Cells[5].Value.ToString();
                txtDiem.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dgvBangDiem.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvBangDiem.SelectedRows[0];
                string maKhachHang = row.Cells[0].Value.ToString();
                BangDiem bangDiem = new BangDiem();
                bangDiem.MaKhachHang = maKhachHang;
                bangDiem.Diem = decimal.Parse(txtDiem.Text);
                bangDiem.NhanXet = txtNhanXet.Text;
                DataIO.UpdateItem(bangDiem, "tb_BangDiem", "MaKhachHang");
                RefreshData();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text;
            dgvBangDiem.Search(query);
        }
    }
}
