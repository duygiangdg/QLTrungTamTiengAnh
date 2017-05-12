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
    public partial class FormHoSoKhachHang : FormInput
    {
        public FormHoSoKhachHang()
        {
            InitializeComponent();
        }

        private void FormHoSoKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtTinhThanh = DataIO.GetData("SELECT DISTINCT TinhThanh FROM tb_KhachHang WHERE TinhThanh IS NOT NULL");
            cbbTinhThanh.DataSource = dtTinhThanh;
            cbbTinhThanh.DisplayMember = "TinhThanh";

            DataTable dtQuanHuyen = DataIO.GetData("SELECT DISTINCT QuanHuyen FROM tb_KhachHang WHERE QuanHuyen IS NOT NULL");
            cbbQuanHuyen.DataSource = dtQuanHuyen;
            cbbQuanHuyen.DisplayMember = "QuanHuyen";

            DataTable dtXaPhuong = DataIO.GetData("SELECT DISTINCT XaPhuong FROM tb_KhachHang WHERE XaPhuong IS NOT NULL");
            cbbXaPhuong.DataSource = dtXaPhuong;
            cbbXaPhuong.DisplayMember = "XaPhuong";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                var instance = CreateObject("QLTrungTamTiengAnh.Object.KhachHang");
                DisableInput();
                ((KhachHang)instance).MaKhachHang = null;
                DataIO.AddItem(instance, "tb_KhachHang");

                DataIO.UpdateItem(instance, "tb_KhachHang", "MaKhachHang");
            }
        }
    }
}
