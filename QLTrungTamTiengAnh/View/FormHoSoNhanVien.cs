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
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                    var instance = CreateObject("QLTrungTamTiengAnh.Object.NhanVien");
                    NhanVien nhanVien = (NhanVien)instance;
                    nhanVien.GioiTinh = radNam.Checked;
                    DisableInput();
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
            NhanVien nhanVien = (NhanVien)DataIO.GetItem("tb_NhanVien", "MaNhanVien", maNhanVien, "QLTrungTamTiengAnh.Object.NhanVien");
            BindData(nhanVien);
            if (nhanVien.GioiTinh)
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
