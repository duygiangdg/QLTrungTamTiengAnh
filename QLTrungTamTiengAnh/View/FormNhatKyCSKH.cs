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
    public partial class FormNhatKyCSKH : FormInput
    {
        public FormNhatKyCSKH()
        {
            InitializeComponent();
        }

        private void FormNhatKyCSKH_Load(object sender, EventArgs e)
        {
            DataTable dt = DataIO.GetData("SELECT * FROM vw_NhatKyCSKH");
            dgvNhatKyCSKH.DataSource = dt;
        }
    }
}
