using QLTrungTamTiengAnh.Control;
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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.Close();
        }

        private void Login()
        {
            string tenDangNhap = txtNguoiDung.Text;
            string matKhau = txtMatKhau.Text;
            Filter filter = new Filter();
            filter.AddCondition("TenDangNhap = '" + tenDangNhap + "'");
            filter.AddCondition("MatKhau = '" + matKhau + "'");
            NguoiDung nguoiDung = (NguoiDung)DataIO.GetItem("tb_NguoiDung", filter.GetConditionClause(), typeof(NguoiDung));
            if (nguoiDung != null)
            {
                Setting.UserName = nguoiDung.TenDangNhap;
                if (nguoiDung.Quyen)
                {
                    Setting.Authority = Setting.ADMIN;
                }
                else
                {
                    Setting.Authority = Setting.STAFF;
                }
                Close();
            }
            else
            {
                MessageBox.Show("Sai tên đang nhập hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatKhau.Clear();
            }
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }

        private void txtNguoiDung_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Login();
            }
        }
    }
}
