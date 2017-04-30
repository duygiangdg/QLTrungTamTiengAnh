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
                    DBHelper.AddItem(instance, "tb_KhachHang");
                    DisableTextInput();
                    if (this.extra == null)
                    {
                        this.btnLuu.Text = "Tạo Mới";
                    }
                    else
                    {
                        this.btnLuu.Text = "Sửa";
                    }
                    this.mode = MODE_VIEW;
                }
            }
        }
    }
}
