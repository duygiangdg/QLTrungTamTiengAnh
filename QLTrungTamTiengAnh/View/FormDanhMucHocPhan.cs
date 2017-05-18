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
    public partial class FormDanhMucHocPhan : Form
    {
        private int soHocPhan;
        public FormDanhMucHocPhan()
        {
            InitializeComponent();
        }

        private void FormDanhMucHocPhan_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            object[] cacHocPhan = DataConverter.ConvertDataToArray(
                (DataTable)dgvDSHocPhan.DataSource, "QLTrungTamTiengAnh.Object.HocPhan");
            for (int index = 0; index < cacHocPhan.Count(); index++)
            {
                HocPhan hocPhan = (HocPhan)cacHocPhan[index];
                if (index < soHocPhan)
                {
                    DataIO.UpdateItem(hocPhan, "tb_HocPhan", "MaHocPhan");
                }
                else
                {
                    hocPhan.MaHocPhan = null;
                    DataIO.AddItem(hocPhan, "tb_HocPhan");
                }
            }
            MessageBox.Show("Cập nhật thông tin học phần thành công");
            RefreshData();
        }

        private void RefreshData()
        {
            DataTable dt = DataIO.GetData("SELECT * FROM tb_HocPhan");
            dgvDSHocPhan.DataSource = dt;
            soHocPhan = dt.Rows.Count;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
