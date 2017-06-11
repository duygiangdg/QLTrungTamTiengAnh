namespace QLTrungTamTiengAnh.View
{
    partial class FormLichTuan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.lvDSLop = new DevComponents.DotNetBar.ListBoxAdv();
            this.tblLichTuan = new System.Windows.Forms.TableLayoutPanel();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelItem1 = new DevComponents.DotNetBar.LabelItem();
            this.cbbPhongHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tblLichTuan.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelX12);
            this.splitContainer1.Panel1.Controls.Add(this.cbbPhongHoc);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.lvDSLop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tblLichTuan);
            this.splitContainer1.Size = new System.Drawing.Size(814, 477);
            this.splitContainer1.SplitterDistance = 143;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Location = new System.Drawing.Point(34, 442);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // lvDSLop
            // 
            this.lvDSLop.AllowDrop = true;
            this.lvDSLop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvDSLop.AutoScroll = true;
            // 
            // 
            // 
            this.lvDSLop.BackgroundStyle.Class = "ListBoxAdv";
            this.lvDSLop.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lvDSLop.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.lvDSLop.CheckStateMember = null;
            this.lvDSLop.ContainerControlProcessDialogKey = true;
            this.lvDSLop.DragDropSupport = true;
            this.lvDSLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDSLop.ItemHeight = 30;
            this.lvDSLop.Location = new System.Drawing.Point(0, 0);
            this.lvDSLop.Name = "lvDSLop";
            this.lvDSLop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lvDSLop.Size = new System.Drawing.Size(143, 366);
            this.lvDSLop.TabIndex = 0;
            this.lvDSLop.Text = "listBoxAdv1";
            this.lvDSLop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lvDSLop_MouseDown);
            this.lvDSLop.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvDSLop_DragDrop);
            this.lvDSLop.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvDSLop_DragEnter);
            // 
            // tblLichTuan
            // 
            this.tblLichTuan.AllowDrop = true;
            this.tblLichTuan.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblLichTuan.ColumnCount = 7;
            this.tblLichTuan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLichTuan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLichTuan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLichTuan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLichTuan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLichTuan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLichTuan.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblLichTuan.Controls.Add(this.labelX11, 0, 4);
            this.tblLichTuan.Controls.Add(this.labelX10, 0, 3);
            this.tblLichTuan.Controls.Add(this.labelX9, 0, 2);
            this.tblLichTuan.Controls.Add(this.labelX8, 0, 1);
            this.tblLichTuan.Controls.Add(this.labelX7, 6, 0);
            this.tblLichTuan.Controls.Add(this.labelX6, 5, 0);
            this.tblLichTuan.Controls.Add(this.labelX5, 4, 0);
            this.tblLichTuan.Controls.Add(this.labelX4, 3, 0);
            this.tblLichTuan.Controls.Add(this.labelX3, 2, 0);
            this.tblLichTuan.Controls.Add(this.labelX2, 0, 5);
            this.tblLichTuan.Controls.Add(this.labelX1, 1, 0);
            this.tblLichTuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLichTuan.Location = new System.Drawing.Point(0, 0);
            this.tblLichTuan.Name = "tblLichTuan";
            this.tblLichTuan.RowCount = 6;
            this.tblLichTuan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tblLichTuan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLichTuan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLichTuan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLichTuan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLichTuan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblLichTuan.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLichTuan.Size = new System.Drawing.Size(667, 477);
            this.tblLichTuan.TabIndex = 1;
            this.tblLichTuan.DragDrop += new System.Windows.Forms.DragEventHandler(this.tblLichTuan_DragDrop);
            this.tblLichTuan.DragEnter += new System.Windows.Forms.DragEventHandler(this.tblLichTuan_DragEnter);
            // 
            // labelX11
            // 
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX11.Location = new System.Drawing.Point(4, 310);
            this.labelX11.Name = "labelX11";
            this.labelX11.Size = new System.Drawing.Size(44, 78);
            this.labelX11.TabIndex = 10;
            this.labelX11.Text = "Ca 4";
            this.labelX11.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX10
            // 
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX10.Location = new System.Drawing.Point(4, 225);
            this.labelX10.Name = "labelX10";
            this.labelX10.Size = new System.Drawing.Size(44, 78);
            this.labelX10.TabIndex = 9;
            this.labelX10.Text = "Ca 3";
            this.labelX10.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX9.Location = new System.Drawing.Point(4, 140);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(44, 78);
            this.labelX9.TabIndex = 8;
            this.labelX9.Text = "Ca 2";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX8.Location = new System.Drawing.Point(4, 55);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(44, 78);
            this.labelX8.TabIndex = 7;
            this.labelX8.Text = "Ca 1";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX7.Location = new System.Drawing.Point(565, 4);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(98, 44);
            this.labelX7.TabIndex = 6;
            this.labelX7.Text = "Thứ bảy";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(463, 4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(95, 44);
            this.labelX6.TabIndex = 5;
            this.labelX6.Text = "Thứ sáu";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(361, 4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(95, 44);
            this.labelX5.TabIndex = 4;
            this.labelX5.Text = "Thứ năm";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(259, 4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(95, 44);
            this.labelX4.TabIndex = 3;
            this.labelX4.Text = "Thứ tư";
            this.labelX4.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(157, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(95, 44);
            this.labelX3.TabIndex = 2;
            this.labelX3.Text = "Thứ ba";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(4, 395);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(44, 78);
            this.labelX2.TabIndex = 1;
            this.labelX2.Text = "Ca 5";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(55, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(95, 44);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Thứ hai";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelItem1
            // 
            this.labelItem1.GlobalItem = false;
            this.labelItem1.Name = "labelItem1";
            // 
            // cbbPhongHoc
            // 
            this.cbbPhongHoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbPhongHoc.DisplayMember = "Text";
            this.cbbPhongHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPhongHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPhongHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhongHoc.FormattingEnabled = true;
            this.cbbPhongHoc.ItemHeight = 17;
            this.cbbPhongHoc.Location = new System.Drawing.Point(3, 406);
            this.cbbPhongHoc.Name = "cbbPhongHoc";
            this.cbbPhongHoc.Size = new System.Drawing.Size(137, 23);
            this.cbbPhongHoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbPhongHoc.TabIndex = 2;
            this.cbbPhongHoc.SelectedIndexChanged += new System.EventHandler(this.cbbPhongHoc_SelectedIndexChanged);
            // 
            // labelX12
            // 
            this.labelX12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX12.Location = new System.Drawing.Point(4, 379);
            this.labelX12.Name = "labelX12";
            this.labelX12.Size = new System.Drawing.Size(75, 23);
            this.labelX12.TabIndex = 3;
            this.labelX12.Text = "Phòng học";
            // 
            // FormLichTuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 477);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormLichTuan";
            this.Text = "Thời Khóa Biểu";
            this.Load += new System.EventHandler(this.FormLichTuan_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tblLichTuan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.ListBoxAdv lvDSLop;
        private System.Windows.Forms.TableLayoutPanel tblLichTuan;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelItem labelItem1;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.LabelX labelX12;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbPhongHoc;
    }
}