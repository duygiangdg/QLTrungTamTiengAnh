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
    public partial class FormQLKhuyenMai : FormInput
    {
        public FormQLKhuyenMai()
        {
            InitializeComponent();
        }

        private void FormQLKhuyenMai_Load(object sender, EventArgs e)
        {
            DataTable dt = DataIO.GetData("SELECT * FROM tb_KhuyenMai");
            dgvDSKhuyenMai.DataSource = dt;
        }

        private void dgvDSKhuyenMai_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            KhuyenMai khuyenMai = (KhuyenMai)DataIO.AddItem(typeof(KhuyenMai), "sp_ThemKhuyenMai", "@MoTa", "MucKhuyenMai", "@DonVi", "abc", "123", "VNĐ");
            dgvDSKhuyenMai.Rows[dgvDSKhuyenMai.Rows.Count - 2].Cells[0].Value = khuyenMai.Id;
        }
    }
}
