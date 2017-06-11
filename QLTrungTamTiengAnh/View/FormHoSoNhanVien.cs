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
    public partial class FormHoSoNhanVien : FormInput
    {
        private object maNhanVien;

        public FormHoSoNhanVien()
        {
            InitializeComponent();
            DataTable dtChucVu = DataIO.GetData("SELECT MaChucVu, TenChucVu FROM tb_ChucVu");
            cbbChucVu.DataSource = dtChucVu;
            cbbChucVu.DisplayMember = "TenChucVu";
            cbbChucVu.ValueMember = "MaChucVu";
            cbbChucVu.SelectedIndex = -1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (btnLuu.Text.Equals("Tạo mới")){
                EnableInput();
                radNam.Enabled = true;
                radNu.Enabled = true;
                Clear();
                btnLuu.Text = "Lưu";
            }
            else if (btnLuu.Text.Equals("Sửa")){
                EnableInput();
                radNam.Enabled = true;
                radNu.Enabled = true;
                btnLuu.Text = "Lưu";
            }
            else if (btnLuu.Text.Equals("Lưu")){
                if (CheckInput())
                {
                    var instance = CreateObject("QLTrungTamTiengAnh.Object.NhanVien");
                    NhanVien nhanVien = (NhanVien)instance;
                    nhanVien.GioiTinh = radNam.Checked;
                    DisableInput();
                    radNam.Enabled = false;
                    radNu.Enabled = false;
                    if (maNhanVien == null)
                    {
                        nhanVien.MaNhanVien = null;
                        DataIO.AddItem(nhanVien, "tb_NhanVien");
                        btnLuu.Text = "Sửa";
                    }
                    else
                    {
                        DataIO.UpdateItem(nhanVien, "tb_NhanVien", "MaNhanVien");
                        btnLuu.Text = "Tạo mới";
                    }
                }
            }
     
        }
        public void PutExtra(string maNhanVien, bool editable)
        {
            this.maNhanVien = maNhanVien;
            NhanVien nhanVien = (NhanVien)DataIO.GetItem("tb_NhanVien", "MaNhanVien = '" + maNhanVien + "'", typeof(NhanVien));
            BindData(nhanVien);
            if (nhanVien.GioiTinh)
            {
                radNam.Checked = true;
                radNu.Checked = false;
            }
            if (!editable)
            {
                DisableInput();
                radNam.Enabled = false;
                radNu.Enabled = false;
                btnLuu.Text = "Sửa";
            }
        }

        private void FormHoSoNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtTinhThanh = DataIO.GetData("SELECT DISTINCT TinhThanh FROM tb_NhanVien WHERE TinhThanh IS NOT NULL");
            cbbTinhThanh.DataSource = dtTinhThanh;
            cbbTinhThanh.DisplayMember = "TinhThanh";
            cbbTinhThanh.Text = "";

            DataTable dtQuanHuyen = DataIO.GetData("SELECT DISTINCT QuanHuyen FROM tb_NhanVien WHERE QuanHuyen IS NOT NULL");
            cbbQuanHuyen.DataSource = dtQuanHuyen;
            cbbQuanHuyen.DisplayMember = "QuanHuyen";
            cbbQuanHuyen.Text = "";

            DataTable dtXaPhuong = DataIO.GetData("SELECT DISTINCT XaPhuong FROM tb_NhanVien WHERE XaPhuong IS NOT NULL");
            cbbXaPhuong.DataSource = dtXaPhuong;
            cbbXaPhuong.DisplayMember = "XaPhuong";
            cbbXaPhuong.Text = "";
        }
    }
}
