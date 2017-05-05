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
    public partial class FormQLKhachHang : Form
    {
        public FormQLKhachHang()
        {
            InitializeComponent();
        }

        private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            dgvDSKhachHang.BindData("vw_KhachHang");
        }

        private void expandablePanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
