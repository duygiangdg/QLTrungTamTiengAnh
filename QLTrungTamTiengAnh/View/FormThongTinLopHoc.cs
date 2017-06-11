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
    public partial class FormThongTinLopHoc : FormInput
    {
        string maLop;
        public FormThongTinLopHoc()
        {
            InitializeComponent();
            DataTable dtHocPhan = DataIO.GetData("SELECT MaHocPHan, TenHocPhan FROM tb_HocPhan");
            cbbHocPhan.DataSource = dtHocPhan;
            cbbHocPhan.DisplayMember = "TenHocPhan";
            cbbHocPhan.ValueMember = "MaHocPhan";
            cbbHocPhan.SelectedIndex = -1;

            DataTable dtGiaoVien = DataIO.GetData("SELECT MaNhanVien AS MaGiaoVien, HoTen FROM tb_NhanVien WHERE MaChucVu = 'CV01'");
            cbbGiaoVien.DataSource = dtGiaoVien;
            cbbGiaoVien.DisplayMember = "HoTen";
            cbbGiaoVien.ValueMember = "MaGiaoVien";
            cbbGiaoVien.SelectedIndex = -1;

            DataTable dtTroGiang = DataIO.GetData("SELECT MaNhanVien AS MaTroGiang, HoTen FROM tb_NhanVien WHERE MaChucVu = 'CV02'");
            cbbTroGiang.DataSource = dtTroGiang;
            cbbTroGiang.DisplayMember = "HoTen";
            cbbTroGiang.ValueMember = "MaTroGiang";
            cbbTroGiang.SelectedIndex = -1;
        }

        public void PutExtra(string maLop, bool editable)
        {
            this.maLop = maLop;
            Lop lop = (Lop)DataIO.GetItem("tb_Lop", "MaLop = '" + maLop + "'", typeof(Lop));
            BindData(lop);
            radDuKien.Checked = false;
            radDangHoc.Checked = false;
            radKetThuc.Checked = false;
            switch (lop.TrangThai)
            {
                case "Dự kiến":
                    radDuKien.Checked = true;
                    break;
                case "Đang học":
                    radDangHoc.Checked = true;
                    break;
                case "Kết thúc":
                    radKetThuc.Checked = true;
                    break;
            }
            if (!editable)
            {
                DisableInput();
                radDangHoc.Enabled = false;
                radDuKien.Enabled = false;
                radKetThuc.Enabled = false;
                btnLuu.Text = "Sửa";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text.Equals("Tạo mới"))
            {
                EnableInput();
                radDangHoc.Enabled = true;
                radDuKien.Enabled = true;
                radKetThuc.Enabled = true;
                Clear();
                btnLuu.Text = "Lưu";
            }
            else if (btnLuu.Text.Equals("Sửa"))
            {
                EnableInput();
                radDangHoc.Enabled = true;
                radDuKien.Enabled = true;
                radKetThuc.Enabled = true;
                btnLuu.Text = "Lưu";
            }
            else if (btnLuu.Text.Equals("Lưu"))
            {
                if (CheckInput())
                {
                    var instance = CreateObject("QLTrungTamTiengAnh.Object.Lop");
                    Lop lop = (Lop)instance;
                    if (radDuKien.Checked)
                    {
                        lop.TrangThai = "Dự kiến";
                    } else if(radDangHoc.Checked)
                    {
                        lop.TrangThai = "Đang học";
                    } else if (radKetThuc.Checked)
                    {
                        lop.TrangThai = "Kết thúc";
                    }
                    DisableInput();
                    radDangHoc.Enabled = false;
                    radDuKien.Enabled = false;
                    radKetThuc.Enabled = false;
                    if (maLop == null)
                    {
                        lop.MaLop = null;
                        DataIO.AddItem(lop, "tb_Lop");
                        btnLuu.Text = "Sửa";
                    }
                    else
                    {
                        DataIO.UpdateItem(lop, "tb_Lop", "MaLop");
                        btnLuu.Text = "Tạo mới";
                    }
                }
            }
        }

        private void FormThongTinLopHoc_Load(object sender, EventArgs e)
        {

        }
    }
}
