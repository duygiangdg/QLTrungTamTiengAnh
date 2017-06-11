namespace QLTrungTamTiengAnh.View
{
    partial class FormDanhSachLopHoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.radKetThuc = new System.Windows.Forms.RadioButton();
            this.radDangHoc = new System.Windows.Forms.RadioButton();
            this.radDuKien = new System.Windows.Forms.RadioButton();
            this.cbbTroGiang = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbGiangVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbHocPhan = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.btnLoc = new DevComponents.DotNetBar.ButtonX();
            this.btnLamMoi = new DevComponents.DotNetBar.ButtonX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvDSLopHoc = new QLTrungTamTiengAnh.Component.XDataGridView();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.btnThem = new DevComponents.DotNetBar.ButtonItem();
            this.btnXem = new DevComponents.DotNetBar.ButtonItem();
            this.btnSua = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLopHoc)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSearch.Location = new System.Drawing.Point(69, 8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(520, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.expandablePanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelEx2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSLopHoc, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 531);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.radKetThuc);
            this.expandablePanel1.Controls.Add(this.radDangHoc);
            this.expandablePanel1.Controls.Add(this.radDuKien);
            this.expandablePanel1.Controls.Add(this.cbbTroGiang);
            this.expandablePanel1.Controls.Add(this.cbbGiangVien);
            this.expandablePanel1.Controls.Add(this.cbbHocPhan);
            this.expandablePanel1.Controls.Add(this.labelX5);
            this.expandablePanel1.Controls.Add(this.labelX4);
            this.expandablePanel1.Controls.Add(this.labelX3);
            this.expandablePanel1.Controls.Add(this.labelX2);
            this.expandablePanel1.Controls.Add(this.btnLoc);
            this.expandablePanel1.Controls.Add(this.btnLamMoi);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(3, 3);
            this.expandablePanel1.Name = "expandablePanel1";
            this.tableLayoutPanel1.SetRowSpan(this.expandablePanel1, 2);
            this.expandablePanel1.Size = new System.Drawing.Size(200, 525);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 0;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.SystemColors.Highlight;
            this.expandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.SystemColors.GradientActiveCaption;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.BorderWidth = 2;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.expandablePanel1.TitleStyle.ForeColor.Color = System.Drawing.Color.Black;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Lọc Danh Sách";
            // 
            // radKetThuc
            // 
            this.radKetThuc.BackColor = System.Drawing.Color.Transparent;
            this.radKetThuc.Location = new System.Drawing.Point(81, 322);
            this.radKetThuc.Name = "radKetThuc";
            this.radKetThuc.Size = new System.Drawing.Size(96, 23);
            this.radKetThuc.TabIndex = 8;
            this.radKetThuc.TabStop = true;
            this.radKetThuc.Text = "Kết thúc";
            this.radKetThuc.UseVisualStyleBackColor = false;
            // 
            // radDangHoc
            // 
            this.radDangHoc.BackColor = System.Drawing.Color.Transparent;
            this.radDangHoc.Location = new System.Drawing.Point(81, 293);
            this.radDangHoc.Name = "radDangHoc";
            this.radDangHoc.Size = new System.Drawing.Size(96, 23);
            this.radDangHoc.TabIndex = 8;
            this.radDangHoc.TabStop = true;
            this.radDangHoc.Text = "Đang học";
            this.radDangHoc.UseVisualStyleBackColor = false;
            // 
            // radDuKien
            // 
            this.radDuKien.BackColor = System.Drawing.Color.Transparent;
            this.radDuKien.Location = new System.Drawing.Point(81, 264);
            this.radDuKien.Name = "radDuKien";
            this.radDuKien.Size = new System.Drawing.Size(96, 23);
            this.radDuKien.TabIndex = 8;
            this.radDuKien.TabStop = true;
            this.radDuKien.Text = "Dự kiến";
            this.radDuKien.UseVisualStyleBackColor = false;
            // 
            // cbbTroGiang
            // 
            this.cbbTroGiang.DisplayMember = "Text";
            this.cbbTroGiang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTroGiang.FormattingEnabled = true;
            this.cbbTroGiang.ItemHeight = 15;
            this.cbbTroGiang.Location = new System.Drawing.Point(8, 212);
            this.cbbTroGiang.Name = "cbbTroGiang";
            this.cbbTroGiang.Size = new System.Drawing.Size(188, 21);
            this.cbbTroGiang.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbTroGiang.TabIndex = 7;
            // 
            // cbbGiangVien
            // 
            this.cbbGiangVien.DisplayMember = "Text";
            this.cbbGiangVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbGiangVien.FormattingEnabled = true;
            this.cbbGiangVien.ItemHeight = 15;
            this.cbbGiangVien.Location = new System.Drawing.Point(9, 140);
            this.cbbGiangVien.Name = "cbbGiangVien";
            this.cbbGiangVien.Size = new System.Drawing.Size(188, 21);
            this.cbbGiangVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbGiangVien.TabIndex = 7;
            // 
            // cbbHocPhan
            // 
            this.cbbHocPhan.DisplayMember = "Text";
            this.cbbHocPhan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbHocPhan.FormattingEnabled = true;
            this.cbbHocPhan.ItemHeight = 15;
            this.cbbHocPhan.Location = new System.Drawing.Point(9, 69);
            this.cbbHocPhan.Name = "cbbHocPhan";
            this.cbbHocPhan.Size = new System.Drawing.Size(188, 21);
            this.cbbHocPhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbHocPhan.TabIndex = 7;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(9, 264);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(66, 23);
            this.labelX5.TabIndex = 6;
            this.labelX5.Text = "Trạng thái:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(8, 183);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(188, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "Trợ giảng:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(9, 111);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(188, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Giảng viên:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(9, 40);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(188, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Học phần:";
            // 
            // btnLoc
            // 
            this.btnLoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoc.Location = new System.Drawing.Point(108, 379);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(88, 23);
            this.btnLoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoc.TabIndex = 5;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLamMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLamMoi.Location = new System.Drawing.Point(8, 379);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 23);
            this.btnLamMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.txtSearch);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(209, 3);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(589, 34);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.Color = System.Drawing.SystemColors.Highlight;
            this.panelEx2.Style.BackColor2.Color = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderWidth = 2;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 1;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.ForeColor = System.Drawing.Color.Black;
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 34);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tìm Kiếm";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dgvDSLopHoc
            // 
            this.dgvDSLopHoc.AllowUserToAddRows = false;
            this.dgvDSLopHoc.AllowUserToDeleteRows = false;
            this.dgvDSLopHoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDSLopHoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSLopHoc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSLopHoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSLopHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSLopHoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSLopHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSLopHoc.EnableHeadersVisualStyles = false;
            this.dgvDSLopHoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDSLopHoc.HighlightSelectedColumnHeaders = false;
            this.dgvDSLopHoc.Location = new System.Drawing.Point(209, 43);
            this.dgvDSLopHoc.MultiSelect = false;
            this.dgvDSLopHoc.Name = "dgvDSLopHoc";
            this.dgvDSLopHoc.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSLopHoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSLopHoc.RowHeadersVisible = false;
            this.dgvDSLopHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLopHoc.Size = new System.Drawing.Size(589, 485);
            this.dgvDSLopHoc.TabIndex = 2;
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.DragDropSupport = true;
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnThem,
            this.btnXem,
            this.btnSua,
            this.btnXoa});
            this.ribbonBar1.Location = new System.Drawing.Point(2, 1);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(276, 86);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.ribbonBar1.TabIndex = 2;
            this.ribbonBar1.Text = "Quản Lý Danh Sách";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.ribbonBar1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(802, 90);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.SystemColors.MenuBar;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.SystemColors.Highlight;
            this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.panelEx1.Style.BorderWidth = 2;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThem.FixedSize = new System.Drawing.Size(65, 65);
            this.btnThem.Image = global::QLTrungTamTiengAnh.Properties.Resources.add;
            this.btnThem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnThem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThem.Name = "btnThem";
            this.btnThem.Text = "Thêm         Lớp Học";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXem.FixedSize = new System.Drawing.Size(65, 65);
            this.btnXem.Image = global::QLTrungTamTiengAnh.Properties.Resources.detail;
            this.btnXem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnXem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXem.Name = "btnXem";
            this.btnXem.Text = "Xem          Chi Tiết";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSua.FixedSize = new System.Drawing.Size(65, 65);
            this.btnSua.Image = global::QLTrungTamTiengAnh.Properties.Resources.edit;
            this.btnSua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSua.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSua.Name = "btnSua";
            this.btnSua.Text = "Sửa         Thông Tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXoa.FixedSize = new System.Drawing.Size(65, 65);
            this.btnXoa.Image = global::QLTrungTamTiengAnh.Properties.Resources.delete;
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnXoa.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa          Lớp Học";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FormDanhSachLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 626);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelEx1);
            this.Name = "FormDanhSachLopHoc";
            this.Text = "Danh Sách Lớp Học";
            this.Load += new System.EventHandler(this.FormDanhSachLopHoc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLopHoc)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.ButtonX btnLoc;
        private DevComponents.DotNetBar.ButtonX btnLamMoi;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private Component.XDataGridView dgvDSLopHoc;
        private DevComponents.DotNetBar.ButtonItem btnThem;
        private DevComponents.DotNetBar.ButtonItem btnXem;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.ButtonItem btnSua;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbHocPhan;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbTroGiang;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbGiangVien;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.RadioButton radKetThuc;
        private System.Windows.Forms.RadioButton radDangHoc;
        private System.Windows.Forms.RadioButton radDuKien;
        private DevComponents.DotNetBar.LabelX labelX5;
    }
}