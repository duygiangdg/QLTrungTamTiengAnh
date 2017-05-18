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
    public partial class FormDanhSachChucVu : FormInput
    {
        private int soChucVu;

        public FormDanhSachChucVu()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            object[] cacChucVu = DataConverter.ConvertDataToArray(
                (DataTable)dgvDSChucVu.DataSource, "QLTrungTamTiengAnh.Object.ChucVu");
            for (int index = 0; index < cacChucVu.Count(); index++)
            {
                ChucVu chucVu = (ChucVu)cacChucVu[index];
                if (index < soChucVu)
                {
                    DataIO.UpdateItem(chucVu, "tb_ChucVu", "MaChucVu");
                }
                else
                {
                    chucVu.MaChucVu = null;
                    DataIO.AddItem(chucVu, "tb_ChucVu");
                }
            }
            MessageBox.Show("Cập nhật danh sách chức vụ thành công");
            RefreshData();
        }

        private void FormDanhSachChucVu_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            DataTable dt = DataIO.GetData("SELECT * FROM tb_ChucVu");
            dgvDSChucVu.DataSource = dt;
            soChucVu = dt.Rows.Count;
        }
    }
}
