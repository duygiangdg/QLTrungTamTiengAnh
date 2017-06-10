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
        string maKhachHang;

        public FormHoSoKhachHang()
        {
            InitializeComponent();
        }

        private void FormHoSoKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtTinhThanh = DataIO.GetData("SELECT DISTINCT TinhThanh FROM tb_KhachHang WHERE TinhThanh IS NOT NULL");
            cbbTinhThanh.DataSource = dtTinhThanh;
            cbbTinhThanh.DisplayMember = "TinhThanh";
            cbbTinhThanh.Text = "";

            DataTable dtQuanHuyen = DataIO.GetData("SELECT DISTINCT QuanHuyen FROM tb_KhachHang WHERE QuanHuyen IS NOT NULL");
            cbbQuanHuyen.DataSource = dtQuanHuyen;
            cbbQuanHuyen.DisplayMember = "QuanHuyen";
            cbbQuanHuyen.Text = "";

            DataTable dtXaPhuong = DataIO.GetData("SELECT DISTINCT XaPhuong FROM tb_KhachHang WHERE XaPhuong IS NOT NULL");
            cbbXaPhuong.DataSource = dtXaPhuong;
            cbbXaPhuong.DisplayMember = "XaPhuong";
            cbbXaPhuong.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text.Equals("Tạo mới")){
                EnableInput();
                Clear();
                btnLuu.Text = "Lưu";
            }
            else if (btnLuu.Text.Equals("Sửa")){
                EnableInput();
                btnLuu.Text = "Lưu";
            }
            else if (btnLuu.Text.Equals("Lưu")){
                if (CheckInput())
                {
                    var instance = CreateObject("QLTrungTamTiengAnh.Object.KhachHang");
                    KhachHang khachHang = (KhachHang)instance;
                    khachHang.GioiTinh = radNam.Checked;
                    DisableInput();
                    if (maKhachHang == null)
                    {
                        khachHang.MaKhachHang = null;
                        DataIO.AddItem(khachHang, "tb_KhachHang");
                        btnLuu.Text = "Sửa";
                    }
                    else
                    {
                        DataIO.UpdateItem(khachHang, "tb_KhachHang", "MaKhachHang");
                        btnLuu.Text = "Tạo mới";
                    }
                }
            }
        }

        public void PutExtra(string maKhachHang, bool editable)
        {
            this.maKhachHang = maKhachHang;
            KhachHang khachHang = (KhachHang)DataIO.GetItem("tb_KhachHang", "MaKhachHang = '" + maKhachHang + "'", typeof(KhachHang));
            BindData(khachHang);
            if (khachHang.GioiTinh)
            {
                radNam.Checked = true;
                radNu.Checked = false;
            }
            if (!editable)
            {
                DisableInput();
                btnLuu.Text = "Sửa";
            }
        }
    }
}
