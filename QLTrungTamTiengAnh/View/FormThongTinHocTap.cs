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
    public partial class FormThongTinHocTap : FormInput
    {
        string maKhachHang;

        public FormThongTinHocTap()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text.Equals("Tạo mới"))
            {
                EnableInput();
                Clear();
                btnLuu.Text = "Lưu";
            }
            else if (btnLuu.Text.Equals("Sửa"))
            {
                EnableInput();
                radDangHoc.Enabled = true;
                radBaoLuu.Enabled = true;
                radKetThuc.Enabled = true;
                btnLuu.Text = "Lưu";
            }
            else if (btnLuu.Text.Equals("Lưu"))
            {
                if (CheckInput())
                {
                    var instance = CreateObject("QLTrungTamTiengAnh.Object.KhachHang");
                    KhachHang khachHang = (KhachHang)instance;
                    if (radDangHoc.Checked)
                    {
                        khachHang.TrangThai = "Đang học";
                    }
                    else if (radBaoLuu.Checked){
                        khachHang.TrangThai = "Bảo lưu";
                    }
                    else if (radKetThuc.Checked)
                    {
                        khachHang.TrangThai = "Kết thúc";
                    }
                    else
                    {
                        khachHang.TrangThai = "Chưa học";
                    }
                    DisableInput();
                    radDangHoc.Enabled = false;
                    radBaoLuu.Enabled = false;
                    radKetThuc.Enabled = false;
                    if (maKhachHang == null)
                    {
                        khachHang.MaKhachHang = null;
                        DataIO.AddItem(khachHang, "tb_KhachHang");
                        btnLuu.Text = "Sửa";
                    }
                    else
                    {
                        DataIO.UpdateItem(khachHang, "tb_KhachHang", "MaKhachHang");
                        btnLuu.Enabled = false;
                    }
                }
            }
        }

        public void PutExtra(string maKhachHang, bool editable)
        {
            this.maKhachHang = maKhachHang;
            KhachHang khachHang = (KhachHang)DataIO.GetItem("tb_KhachHang", "MaKhachHang", maKhachHang, "QLTrungTamTiengAnh.Object.KhachHang");
            BindData(khachHang);
            switch (khachHang.TrangThai)
            {
                case "Chưa học":
                    break;
                case "Đang học":
                    radDangHoc.Checked = true;
                    break;
                case "Bảo lưu":
                    radBaoLuu.Checked = true;
                    break;
                case "Kết thúc":
                    radKetThuc.Checked = true;
                    break;
            }
            if (!editable)
            {
                DisableInput();
                radDangHoc.Enabled = false;
                radBaoLuu.Enabled = false;
                radKetThuc.Enabled = false;
                btnLuu.Text = "Sửa";
            }
        }
    }
}
