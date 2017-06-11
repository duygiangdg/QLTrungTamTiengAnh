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
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string tenDangNhap = Setting.UserName;
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLai = txtNhapLai.Text;
            if (matKhauMoi.Equals(nhapLai))
            {
                Filter filter = new Filter();
                filter.AddCondition("TenDangNhap = '" + tenDangNhap + "'");
                filter.AddCondition("MatKhau = '" + matKhauCu + "'");
                NguoiDung nguoiDung = (NguoiDung)DataIO.GetItem("tb_NguoiDung", filter.GetConditionClause(), typeof(NguoiDung));
                if (nguoiDung != null)
                {
                    nguoiDung.MatKhau = matKhauMoi;
                    DataIO.UpdateItem(nguoiDung, "tb_NguoiDung", "MaNguoiDung");
                    MessageBox.Show("Thay đổi mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nhập lại mật khẩu mới không chính xác, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
