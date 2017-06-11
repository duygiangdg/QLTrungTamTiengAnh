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
    public partial class FormPhieuChiTietLuong : FormInput
    {
        private readonly bool editable;
        private string soPhieuChi;
        public FormPhieuChiTietLuong()
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
                btnLuu.Text = "Lưu";
            }
            else if (btnLuu.Text.Equals("Lưu"))
            {
                if (CheckInput())
                {
                    var instance = CreateObject("QLTrungTamTiengAnh.Object.PhieuChi");
                    PhieuChi phieuThu = (PhieuChi)instance;
                    if (soPhieuChi == null)
                    {
                        phieuThu.SoPhieuChi = null;
                        DataIO.AddItem(phieuThu, "tb_PhieuThu");
                        btnLuu.Text = "Sửa";
                    }
                    else
                    {
                        DataIO.UpdateItem(phieuThu, "tb_PhieuThu", "SoPhieuChi");
                        btnLuu.Text = "Tạo mới";
                    }
                }
            }
        }
        internal void PutExtra(string soPhieuChi, bool editable)
        {
            this.soPhieuChi = soPhieuChi;
            Object.PhieuChi phieuChi = (Object.PhieuChi)DataIO.GetItem("tb_PhieuChi", "SoPhieuChi = '" + soPhieuChi + "'", typeof(PhieuChi));
            NhanVien nhanVien = (NhanVien)DataIO.GetItem("tb_NhanVien", "MaNhanVien = '" + phieuChi.MaNhanVien + "'", typeof(NhanVien));
            BindData(phieuChi);
            BindData(nhanVien);
            if (!editable)
            {
                DisableInput();
                btnLuu.Text = "Sửa";
            }
        }
    }
}
