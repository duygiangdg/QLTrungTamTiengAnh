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
    public partial class FormCTKhachHang : FormInput
    {
        public FormCTKhachHang()
        {
            InitializeComponent();
        }

        private void FormCTKhachHang_Load(object sender, EventArgs e)
        {
            if (extra != null)
            {
                object obj = DataIO.GetItem("tb_KhachHang", "MaKhachHang", extra, "QLTrungTamTiengAnh.Object.KhachHang");
                BindData(obj);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                var instance = CreateObject("QLTrungTamTiengAnh.Object.KhachHang");
                DisableInput();
                if (this.extra == null)
                {
                    DataIO.AddItem(instance, "tb_KhachHang");
                    this.btnLuu.Enabled = false;
                }
                else
                {
                    DataIO.UpdateItem(instance, "tb_KhachHang", "MaKhachHang");
                    this.btnLuu.Text = "Sửa";
                }
                this.mode = MODE_VIEW;
            }
        }
    }
}
