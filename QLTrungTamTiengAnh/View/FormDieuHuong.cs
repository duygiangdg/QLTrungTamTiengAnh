using DevComponents.DotNetBar;
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
    public partial class FormDieuHuong : Office2007Form
    {
        private static FormDieuHuong instance;
        public static FormDieuHuong Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FormDieuHuong();
                }
                return instance;
            }
        }

        private FormDieuHuong()
        {
            InitializeComponent();
        }

        private void FormDieuHuong_Load(object sender, EventArgs e)
        {
            
        }

        public void CreateTab(Form form)
        {
            TabItem tabItem = tabControl.CreateTab(form.Text);
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
            tabItem.AttachedControl.Controls.Add(form);
            tabControl.SelectedTab = tabItem;
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            CreateTab(new FormDanhSachKhachHang());
        }

        private void btnQLHocVien_Click(object sender, EventArgs e)
        {
            CreateTab(new FormQuanLyHocTap());
        }

        private void btnQLHocPhan_Click(object sender, EventArgs e)
        {
            CreateTab(new FormDanhMucHocPhan());
        }

        private void btnQLGiangVien_Click(object sender, EventArgs e)
        {
            CreateTab(new FormDanhSachNhanVien());
        }

        private void btnQLLopHoc_Click(object sender, EventArgs e)
        {
            CreateTab(new FormDanhSachLopHoc());
        }
    }
}
