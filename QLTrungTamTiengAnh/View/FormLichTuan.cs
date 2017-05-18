using DevComponents.DotNetBar.Controls;
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
    public partial class FormLichTuan : Form
    {
        string[] cacMau = { "white", "yellow", "red", "blue", "green", "pink", "purple", "orange" };
        
        public FormLichTuan()
        {
            InitializeComponent();
        }

        private void FormLichTuan_Load(object sender, EventArgs e)
        {
            DataTable dt = DataIO.GetData("SELECT MaLop, Mau FROM tb_MauLop");
            dgvMauLop.DataSource = dt;
            foreach (DataGridViewRow row in dgvMauLop.Rows)
            {
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)(row.Cells[1]);
                cell.DataSource = cacMau;
            }
        }
    }
}
