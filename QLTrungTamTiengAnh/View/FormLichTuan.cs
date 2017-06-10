using DevComponents.DotNetBar;
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
        public FormLichTuan()
        {
            InitializeComponent();
        }

        private void FormLichTuan_Load(object sender, EventArgs e)
        {
            DataTable dt = DataIO.GetData("SELECT MaLop FROM tb_Lop");
            lvDSLop.DataSource = dt;
            lvDSLop.DisplayMember = "MaLop";
            lvDSLop.ValueMember = "MaLop";
            SetTableItemDrag();
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
                Label label = new Label();
                label.Dock = DockStyle.Fill;
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label.Text = e.Data.GetData(typeof(string)) as string;
                tblLichTuan.Controls.Add(label, rowColIndex.Value.X, rowColIndex.Value.Y);
                SetTableItemDrag();
            }
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
    }
}
