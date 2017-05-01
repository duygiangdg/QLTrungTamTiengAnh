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
    public partial class FormThongTinKhachHang : FormDetail
    {
        public FormThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
  
            if (this.mode == MODE_VIEW)
            {
                if (this.extra == null)
                {
                    ClearForm();
                }
                EnableTextInput();
                this.btnLuu.Text = "Lưu";
                this.mode = MODE_EDIT;
            }
            else
            {
                if (ValidateTextInput())
                {
                    var instance = CreateObject("QLTrungTamTiengAnh.Object.KhachHang");
                    DisableTextInput();
                    if (this.extra == null)
                    {
                        DatabaseService.AddItem(instance, "tb_KhachHang");
                        this.btnLuu.Text = "Tạo Mới";
                    }
                    else
                    {
                        DatabaseService.UpdateItem(instance, "tb_KhachHang", "MaKhachHang");
                        this.btnLuu.Text = "Sửa";
                    }
                    this.mode = MODE_VIEW;
                }
            }
        }

        private void FormThongTinKhachHang_Load(object sender, EventArgs e)
        {
            if (extra != null)
            {
                object obj = DatabaseService.GetItem("tb_KhachHang", "MaKhachHang", extra, "QLTrungTamTiengAnh.Object.KhachHang");
                BindData(obj);
            }
        }
    }
}
