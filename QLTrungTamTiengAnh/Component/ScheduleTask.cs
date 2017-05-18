using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTrungTamTiengAnh.Model;

namespace QLTrungTamTiengAnh.Component
{
    public partial class ScheduleTask : UserControl
    {
        private string color;
        public ScheduleTask()
        {
            InitializeComponent();
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
                switch (color)
                {
                    case "white": btnTask.BackColor = System.Drawing.Color.White; break;
                    case "yellow": btnTask.BackColor = System.Drawing.Color.Yellow; break;
                    case "red": btnTask.BackColor = System.Drawing.Color.Red; break;
                    case "blue": btnTask.BackColor = System.Drawing.Color.Blue; break;
                    case "green": btnTask.BackColor = System.Drawing.Color.Green; break;
                    case "pink": btnTask.BackColor = System.Drawing.Color.Pink; break;
                    case "purple": btnTask.BackColor = System.Drawing.Color.Purple; break;
                    case "orange": btnTask.BackColor = System.Drawing.Color.Orange; break;
                    default: btnTask.BackColor = System.Drawing.Color.Transparent; break;
                }
            }
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            DataTable dt = DataIO.GetData("SELECT MaLop FROM tb_Lop");
            DataRow row = dt.NewRow();
            row[0] = "Không chọn";
            dt.Rows.InsertAt(row, 0);
            cbbTask.DataSource = dt;
            cbbTask.DisplayMember = "MaLop";
            cbbTask.DroppedDown = true;
        }

        private void cbbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTask.Text = cbbTask.Text;
            DataTable dt = DataIO.GetData("SELECT Mau FROM tb_MauLop WHERE MaLop = '" + cbbTask.Text + "'");
            if (dt.Rows.Count > 0)
            {
                Color = dt.Rows[0].ItemArray[0].ToString();
            }
            else
            {
                Color = "transparent";
            }
        }
    }
}
