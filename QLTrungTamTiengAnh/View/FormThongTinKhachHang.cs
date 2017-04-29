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
    public partial class FormThongTinKhachHang : FormDetail
    {
        public FormThongTinKhachHang()
        {
            InitializeComponent();
            DataTable khachHangTable = KhachHangMod.Instance.GetData();
            object obj = DBHelper.ConvertDataToArray(khachHangTable, "QLTrungTamTiengAnh.Object.KhachHangObj")[0];
            BindData(obj);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ValidateTextInput();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            EnableTextInput();
        }

        private void btnDangKyHoc_Click(object sender, EventArgs e)
        {
            DisableTextInput();
        }
    }
}
