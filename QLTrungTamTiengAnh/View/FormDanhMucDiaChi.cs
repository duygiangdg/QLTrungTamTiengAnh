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
    public partial class FormDanhMucDiaChi : Form
    {
        public FormDanhMucDiaChi()
        {
            InitializeComponent();
        }

        private void FormDanhMucDiaChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBQLTrungTamTiengAnhDataSet.tb_TinhThanh' table. You can move, or remove it, as needed.
            this.tb_TinhThanhTableAdapter.Fill(this.dBQLTrungTamTiengAnhDataSet.tb_TinhThanh);

        }
    }
}
