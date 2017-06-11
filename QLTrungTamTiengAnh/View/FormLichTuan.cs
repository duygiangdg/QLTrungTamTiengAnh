using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Controls;
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
    public partial class FormLichTuan : Form, IRefreshable
    {
        public FormLichTuan()
        {
            InitializeComponent();
        }

        private void FormLichTuan_Load(object sender, EventArgs e)
        {
            DataTable dtPhong = DataIO.GetData("SELECT MaPhongHoc, TenPhongHoc FROM tb_PhongHoc");
            cbbPhongHoc.DataSource = dtPhong;
            cbbPhongHoc.DisplayMember = "TenPhongHoc";
            cbbPhongHoc.ValueMember = "MaPhongHoc";
            GetSchedule();
            RefreshData();
        }

        public void RefreshData()
        {
            DataTable dtLop = DataIO.GetData("SELECT MaLop FROM tb_Lop");
            lvDSLop.DataSource = dtLop;
            lvDSLop.DisplayMember = "MaLop";
            lvDSLop.ValueMember = "MaLop";
        }

        private void lvDSLop_MouseDown(object sender, MouseEventArgs e)
        {
            lvDSLop.SelectedIndex = lvDSLop.PointToClient(Cursor.Position).Y / lvDSLop.ItemHeight;
            if (lvDSLop.SelectedItems.Count == 1)
            {
                DoDragDrop(lvDSLop.SelectedItems[0].Text, DragDropEffects.Link);
            }
        }

        private void tblLichTuan_DragDrop(object sender, DragEventArgs e)
        {
            Point? rowColIndex = GetRowColIndex(tblLichTuan, tblLichTuan.PointToClient(Cursor.Position));
            if (tblLichTuan.GetControlFromPosition(rowColIndex.Value.X, rowColIndex.Value.Y) == null)
            {
                AddClass(e.Data.GetData(typeof(string)) as string, rowColIndex.Value.X, rowColIndex.Value.Y);
                SetTableItemDrag();
            }
        }

        private void AddClass(string text, int col, int row)
        {
            Label label = new Label();
            label.Dock = DockStyle.Fill;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Text = text;
            tblLichTuan.Controls.Add(label, col, row);
        }

        private void tblLichTuan_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Link;
        }

        Point? GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return null;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(col, row);
        }

        private void SetTableItemDrag()
        {
            foreach(System.Windows.Forms.Control control in tblLichTuan.Controls)
            {
                control.MouseDown += TableItem_MouseDown;
            }
        }

        private void TableItem_MouseDown(object sender, EventArgs e)
        {
            Point? rowColIndex = GetRowColIndex(tblLichTuan, tblLichTuan.PointToClient(Cursor.Position));
            var child = tblLichTuan.GetControlFromPosition(rowColIndex.Value.X, rowColIndex.Value.Y);
            if (rowColIndex.Value.X > 0 && rowColIndex.Value.Y > 0 && child != null)
            {
                DoDragDrop(child, DragDropEffects.Link);
            }
        }

        private void lvDSLop_DragDrop(object sender, DragEventArgs e)
        {
            tblLichTuan.Controls.Remove(e.Data.GetData(typeof(System.Windows.Forms.Label)) as System.Windows.Forms.Label);
            SetTableItemDrag();
        }

        private void lvDSLop_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Link) != 0 && e.Data.GetDataPresent(typeof(Label)))
                e.Effect = DragDropEffects.Link;
        }

        private void GetSchedule()
        {
            Filter filter = new Filter();
            string maPhong = cbbPhongHoc.SelectedValue.ToString();
            filter.AddCondition("MaPhong = '" + maPhong + "'");
            filter.AddCondition("MaLop IS NOT NULL");
            string selectQuery = "SELECT * FROM tb_LichTuan" + filter.GetWhereClause();
            DataTable dt = DataIO.GetData(selectQuery);
            object[] lich = DataConverter.ConvertDataToArray(dt, typeof(LichTuan));
            for (int col = 1; col < 7; col++)
            {
                for (int row = 1; row < 6; row++)
                {
                    var child = tblLichTuan.GetControlFromPosition(col, row);
                    if (child!=null)
                    {
                        tblLichTuan.Controls.Remove((Label)child);
                    }
                }
            }
            foreach (var lichTuanObj in lich)
            {
                LichTuan lichTuan = (LichTuan)lichTuanObj;
                int col = 0;
                int row = lichTuan.Ca;
                switch (lichTuan.Thu)
                {
                    case "Thứ hai":
                        col = 1;
                        break;
                    case "Thứ ba":
                        col = 2;
                        break;
                    case "Thứ tư":
                        col = 3;
                        break;
                    case "Thứ năm":
                        col = 4;
                        break;
                    case "Thứ sáu":
                        col = 5;
                        break;
                    case "Thứ bảy":
                        col = 6;
                        break;
                }
                AddClass(lichTuan.MaLop, col, row);
            }
        }

        private void SaveData()
        {
            for (int col = 1; col < 7; col++)
            {
                for (int row = 1; row < 6; row++)
                {
                    Label label = tblLichTuan.GetControlFromPosition(col, row) as Label;

                    LichTuan lichTuan = new LichTuan();
                    lichTuan.Thu = GetWeekDayFromIndex(col);
                    lichTuan.Ca = row;
                    if (label != null)
                    {
                        lichTuan.MaLop = label.Text;
                    }
                    else
                    {
                        lichTuan.MaLop = "";
                    }
                    lichTuan.MaPhong = cbbPhongHoc.SelectedValue.ToString();
                    Filter filter = new Filter();
                    filter.AddCondition("MaPhong = '" + lichTuan.MaPhong + "'");
                    filter.AddCondition("Ca = " + lichTuan.Ca);
                    filter.AddCondition("Thu = N'" + lichTuan.Thu + "'");
                    LichTuan lichCu = (LichTuan)DataIO.GetItem("tb_LichTuan", filter.GetConditionClause(), typeof(LichTuan));
                    if (lichCu == null)
                    {
                        DataIO.AddItem(lichTuan, "tb_LichTuan");
                    }
                    else
                    {
                        lichTuan.MaLich = lichCu.MaLich;
                        DataIO.UpdateItem(lichTuan, "tb_LichTuan", "MaLich");
                    }
                }
            }
        }

        private string GetWeekDayFromIndex(int colIndex)
        {
            switch (colIndex)
            {
                case 1: return "Thứ hai";
                case 2: return "Thứ ba";
                case 3: return "Thứ tư";
                case 4: return "Thứ năm";
                case 5: return "Thứ sáu";
                case 6: return "Thứ bảy";
            }
            return "Chủ nhật";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            SaveData();
            MessageBox.Show("Lưu thời khóa biểu thành công!!!");
        }

        private void cbbPhongHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSchedule();
            SetTableItemDrag();
        }
    }
}
