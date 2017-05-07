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
    public partial class FormQLHocVien : Form
    {
        public FormQLHocVien()
        {
            InitializeComponent();
        }

        private void FormDanhSachHocVien_Load(object sender, EventArgs e)
        {
            dgvDSHocVien.BindData("vw_HocVien");
        }

        private void btnThemHoSo_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormCTHocVien());
        }

        private void btnXemHoSo_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormCTHocVien());
        }

        private void btnSuaHoSo_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormCTHocVien());
        }
    }
}
