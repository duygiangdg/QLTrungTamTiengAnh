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
    public partial class FormPhieuThu : FormInput
    {
        private readonly bool editable;
        private string soPhieuThu;

        public FormPhieuThu()
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
                    var instance = CreateObject("QLTrungTamTiengAnh.Object.PhieuThu");
                    PhieuThu phieuThu = (PhieuThu)instance;                
                    if (soPhieuThu == null)
                    {
                        phieuThu.SoPhieuThu = null;
                        DataIO.AddItem(phieuThu, "tb_PhieuThu");
                        btnLuu.Text = "Sửa";
                    }
                    else
                    {
                        DataIO.UpdateItem(phieuThu, "tb_PhieuThu", "SoPhieuThu");
                        btnLuu.Text = "Tạo mới";
                    }
                }
            }
        }     
        internal void PutExtra(string soPhieuThu, bool editable)
        {
            this.soPhieuThu = soPhieuThu;
            Object.PhieuThu phieuThu = (Object.PhieuThu)DataIO.GetItem("tb_PhieuThu", "SoPhieuThu = '" + soPhieuThu + "'", typeof(PhieuThu));
            KhachHang khachHang = (KhachHang)DataIO.GetItem("tb_KhachHang", "MaKhachHang = '" + phieuThu.MaKhachHang + "'", typeof(KhachHang));
            BindData(phieuThu);
            BindData(khachHang);
                 if (!editable)
            {
                DisableInput();
                btnLuu.Text = "Sửa";
            }
        }
    }
}
