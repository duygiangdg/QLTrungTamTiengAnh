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
        bool taoMoi = true;

        public FormThongTinHocTap()
        {
            InitializeComponent();
            DataTable dtHocPhan = DataIO.GetData("SELECT MaHocPHan, TenHocPhan FROM tb_HocPhan");
            cbbHocPhan.DataSource = dtHocPhan;
            cbbHocPhan.DisplayMember = "TenHocPhan";
            cbbHocPhan.ValueMember = "MaHocPhan";
            cbbHocPhan.SelectedIndex = -1;

            DataTable dtLop = DataIO.GetData("SELECT MaLop FROM tb_Lop");
            cbbLop.DataSource = dtLop;
            cbbLop.DisplayMember = "MaLop";
            cbbLop.ValueMember = "MaLop";
            cbbLop.SelectedIndex = -1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text.Equals("Tạo mới"))
            {
                EnableInput();
                radDangHoc.Enabled = true;
                radBaoLuu.Enabled = true;
                radKetThuc.Enabled = true;
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

                    DataIO.UpdateItem(khachHang, "tb_KhachHang", "MaKhachHang");
                    btnLuu.Text = "Sửa";

                    if (taoMoi)
                    {
                        PhieuDangKy phieuDangKy = (PhieuDangKy)CreateObject("QLTrungTamTiengAnh.Object.PhieuDangKy");
                        phieuDangKy.SoDangKy = null;
                        DataIO.AddItem(phieuDangKy, "tb_PhieuDangKy");
                    }
                }
            }
        }

        public void PutExtra(string maKhachHang, bool editable)
        {
            this.maKhachHang = maKhachHang;
            KhachHang khachHang = (KhachHang)DataIO.GetItem("tb_KhachHang", "MaKhachHang = '" + maKhachHang + "'", typeof(KhachHang));
            BindData(khachHang);
            switch (khachHang.TrangThai)
            {
                case "Bảo lưu":
                    radBaoLuu.Checked = true;
                    break;
                case "Kết thúc":
                    radKetThuc.Checked = true;
                    break;
                default:
                    radDangHoc.Checked = true;
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
