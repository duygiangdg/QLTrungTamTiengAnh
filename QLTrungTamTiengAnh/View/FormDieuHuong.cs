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
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            tabItem.AttachedControl.Controls.Add(form);
            tabControl.SelectedTab = tabItem;
            form.Show();
        }

        private void btnQLKhachHang_Click(object sender, EventArgs e)
        {
            CreateTab(new FormQLKhachHang());
        }

        private void btnQLHocVien_Click(object sender, EventArgs e)
        {
            CreateTab(new FormQLHocVien());
        }
    }
}
