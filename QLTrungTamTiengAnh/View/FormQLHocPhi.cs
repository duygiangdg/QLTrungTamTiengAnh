using DevComponents.DotNetBar;
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
    public partial class FormQLHocPhi : Form
    {
        public FormQLHocPhi()
        {
            InitializeComponent();
            dgvHocPhi.BindData("vw_MucHocPhi");
            dgvKhuyenMai.BindData("vw_KhuyenMai");
        }
    }
}
