namespace QLTrungTamTiengAnh.View
{
    partial class FormQuanLyHocTap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDSHocVien = new QLTrungTamTiengAnh.Component.XDataGridView();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.btnLoc = new DevComponents.DotNetBar.ButtonX();
            this.btnLamMoi = new DevComponents.DotNetBar.ButtonX();
            this.dtpDangKyTu = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtpDangKyDen = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.cbbNamSinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbTruong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbXaPhuong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbQuanHuyen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbTinhThanh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbNhanVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.btnGuiEmail = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnDangKyHoc = new DevComponents.DotNetBar.ButtonItem();
            this.btnXemChiTiet = new DevComponents.DotNetBar.ButtonItem();
            this.btnSuaHoSo = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHocVien)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDangKyTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDangKyDen)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgvDSHocVien, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.expandablePanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelEx2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(845, 539);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // dgvDSHocVien
            // 
            this.dgvDSHocVien.AllowUserToAddRows = false;
            this.dgvDSHocVien.AllowUserToDeleteRows = false;
            this.dgvDSHocVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDSHocVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSHocVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSHocVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSHocVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSHocVien.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSHocVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHocVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDSHocVien.HighlightSelectedColumnHeaders = false;
            this.dgvDSHocVien.Location = new System.Drawing.Point(209, 43);
            this.dgvDSHocVien.MultiSelect = false;
            this.dgvDSHocVien.Name = "dgvDSHocVien";
            this.dgvDSHocVien.ReadOnly = true;
            this.dgvDSHocVien.RowHeadersVisible = false;
            this.dgvDSHocVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHocVien.Size = new System.Drawing.Size(633, 493);
            this.dgvDSHocVien.TabIndex = 3;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.btnLoc);
            this.expandablePanel1.Controls.Add(this.btnLamMoi);
            this.expandablePanel1.Controls.Add(this.dtpDangKyTu);
            this.expandablePanel1.Controls.Add(this.dtpDangKyDen);
            this.expandablePanel1.Controls.Add(this.radNu);
            this.expandablePanel1.Controls.Add(this.radNam);
            this.expandablePanel1.Controls.Add(this.cbbNamSinh);
            this.expandablePanel1.Controls.Add(this.cbbTruong);
            this.expandablePanel1.Controls.Add(this.cbbXaPhuong);
            this.expandablePanel1.Controls.Add(this.cbbQuanHuyen);
            this.expandablePanel1.Controls.Add(this.cbbTinhThanh);
            this.expandablePanel1.Controls.Add(this.cbbNhanVien);
            this.expandablePanel1.Controls.Add(this.labelX9);
            this.expandablePanel1.Controls.Add(this.labelX8);
            this.expandablePanel1.Controls.Add(this.labelX7);
            this.expandablePanel1.Controls.Add(this.labelX6);
            this.expandablePanel1.Controls.Add(this.labelX5);
            this.expandablePanel1.Controls.Add(this.labelX4);
            this.expandablePanel1.Controls.Add(this.labelX3);
            this.expandablePanel1.Controls.Add(this.labelX2);
            this.expandablePanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(3, 3);
            this.expandablePanel1.Name = "expandablePanel1";
            this.tableLayoutPanel1.SetRowSpan(this.expandablePanel1, 2);
            this.expandablePanel1.Size = new System.Drawing.Size(200, 533);
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
            // btnLoc
            // 
            this.btnLoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoc.Location = new System.Drawing.Point(107, 498);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(88, 23);
            this.btnLoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLoc.TabIndex = 25;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLamMoi.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLamMoi.Location = new System.Drawing.Point(7, 498);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 23);
            this.btnLamMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLamMoi.TabIndex = 24;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtpDangKyTu
            // 
            // 
            // 
            // 
            this.dtpDangKyTu.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpDangKyTu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDangKyTu.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpDangKyTu.ButtonDropDown.Visible = true;
            this.dtpDangKyTu.IsPopupCalendarOpen = false;
            this.dtpDangKyTu.Location = new System.Drawing.Point(9, 399);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpDangKyTu.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDangKyTu.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpDangKyTu.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpDangKyTu.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpDangKyTu.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpDangKyTu.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpDangKyTu.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpDangKyTu.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpDangKyTu.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpDangKyTu.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDangKyTu.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.dtpDangKyTu.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtpDangKyTu.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpDangKyTu.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpDangKyTu.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpDangKyTu.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDangKyTu.MonthCalendar.TodayButtonVisible = true;
            this.dtpDangKyTu.Name = "dtpDangKyTu";
            this.dtpDangKyTu.Size = new System.Drawing.Size(186, 20);
            this.dtpDangKyTu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpDangKyTu.TabIndex = 23;
            // 
            // dtpDangKyDen
            // 
            // 
            // 
            // 
            this.dtpDangKyDen.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpDangKyDen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDangKyDen.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpDangKyDen.ButtonDropDown.Visible = true;
            this.dtpDangKyDen.IsPopupCalendarOpen = false;
            this.dtpDangKyDen.Location = new System.Drawing.Point(9, 454);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpDangKyDen.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDangKyDen.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpDangKyDen.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpDangKyDen.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpDangKyDen.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpDangKyDen.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpDangKyDen.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpDangKyDen.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpDangKyDen.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpDangKyDen.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDangKyDen.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.dtpDangKyDen.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtpDangKyDen.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpDangKyDen.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpDangKyDen.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpDangKyDen.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpDangKyDen.MonthCalendar.TodayButtonVisible = true;
            this.dtpDangKyDen.Name = "dtpDangKyDen";
            this.dtpDangKyDen.Size = new System.Drawing.Size(186, 20);
            this.dtpDangKyDen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpDangKyDen.TabIndex = 22;
            // 
            // radNu
            // 
            this.radNu.BackColor = System.Drawing.Color.Transparent;
            this.radNu.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radNu.Location = new System.Drawing.Point(162, 315);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(33, 49);
            this.radNu.TabIndex = 21;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radNu.UseVisualStyleBackColor = false;
            // 
            // radNam
            // 
            this.radNam.BackColor = System.Drawing.Color.Transparent;
            this.radNam.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radNam.Location = new System.Drawing.Point(126, 315);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(33, 49);
            this.radNam.TabIndex = 20;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radNam.UseVisualStyleBackColor = false;
            // 
            // cbbNamSinh
            // 
            this.cbbNamSinh.DisplayMember = "Text";
            this.cbbNamSinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNamSinh.FormattingEnabled = true;
            this.cbbNamSinh.ItemHeight = 14;
            this.cbbNamSinh.Location = new System.Drawing.Point(7, 344);
            this.cbbNamSinh.Name = "cbbNamSinh";
            this.cbbNamSinh.Size = new System.Drawing.Size(94, 20);
            this.cbbNamSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbNamSinh.TabIndex = 18;
            // 
            // cbbTruong
            // 
            this.cbbTruong.DisplayMember = "Text";
            this.cbbTruong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTruong.FormattingEnabled = true;
            this.cbbTruong.ItemHeight = 14;
            this.cbbTruong.Location = new System.Drawing.Point(8, 289);
            this.cbbTruong.Name = "cbbTruong";
            this.cbbTruong.Size = new System.Drawing.Size(188, 20);
            this.cbbTruong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbTruong.TabIndex = 17;
            // 
            // cbbXaPhuong
            // 
            this.cbbXaPhuong.DisplayMember = "Text";
            this.cbbXaPhuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbXaPhuong.FormattingEnabled = true;
            this.cbbXaPhuong.ItemHeight = 14;
            this.cbbXaPhuong.Location = new System.Drawing.Point(8, 234);
            this.cbbXaPhuong.Name = "cbbXaPhuong";
            this.cbbXaPhuong.Size = new System.Drawing.Size(188, 20);
            this.cbbXaPhuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbXaPhuong.TabIndex = 19;
            // 
            // cbbQuanHuyen
            // 
            this.cbbQuanHuyen.DisplayMember = "Text";
            this.cbbQuanHuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbQuanHuyen.FormattingEnabled = true;
            this.cbbQuanHuyen.ItemHeight = 14;
            this.cbbQuanHuyen.Location = new System.Drawing.Point(8, 179);
            this.cbbQuanHuyen.Name = "cbbQuanHuyen";
            this.cbbQuanHuyen.Size = new System.Drawing.Size(188, 20);
            this.cbbQuanHuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbQuanHuyen.TabIndex = 16;
            // 
            // cbbTinhThanh
            // 
            this.cbbTinhThanh.DisplayMember = "Text";
            this.cbbTinhThanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTinhThanh.FormattingEnabled = true;
            this.cbbTinhThanh.ItemHeight = 14;
            this.cbbTinhThanh.Location = new System.Drawing.Point(7, 124);
            this.cbbTinhThanh.Name = "cbbTinhThanh";
            this.cbbTinhThanh.Size = new System.Drawing.Size(188, 20);
            this.cbbTinhThanh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbTinhThanh.TabIndex = 15;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.DisplayMember = "Text";
            this.cbbNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.ItemHeight = 14;
            this.cbbNhanVien.Location = new System.Drawing.Point(8, 69);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(188, 20);
            this.cbbNhanVien.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbNhanVien.TabIndex = 14;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(8, 370);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(188, 23);
            this.labelX9.TabIndex = 12;
            this.labelX9.Text = "Ngày đăng ký từ:";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(8, 425);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(188, 23);
            this.labelX8.TabIndex = 11;
            this.labelX8.Text = "Đến ngày:";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(7, 315);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(94, 23);
            this.labelX7.TabIndex = 10;
            this.labelX7.Text = "Năm sinh:";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(8, 260);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(188, 23);
            this.labelX6.TabIndex = 9;
            this.labelX6.Text = "Trường:";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(8, 205);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(188, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "Xã/ phường:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(8, 150);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(188, 23);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Quận/ huyện:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(7, 95);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(188, 23);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "Tình/ thành phố:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(8, 40);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(188, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Nhân viên tư vấn:";
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
            this.panelEx2.Size = new System.Drawing.Size(633, 34);
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
            this.txtSearch.Size = new System.Drawing.Size(564, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.ribbonBar2);
            this.panelEx1.Controls.Add(this.ribbonBar1);
            this.panelEx1.DisabledBackColor = System.Drawing.Color.Empty;
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(846, 90);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.SystemColors.MenuBar;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.SystemColors.Highlight;
            this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.panelEx1.Style.BorderWidth = 2;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 8;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.DragDropSupport = true;
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnGuiEmail});
            this.ribbonBar2.Location = new System.Drawing.Point(412, 1);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(78, 86);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.ribbonBar2.TabIndex = 3;
            this.ribbonBar2.Text = "Liên Lạc";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnGuiEmail
            // 
            this.btnGuiEmail.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnGuiEmail.FixedSize = new System.Drawing.Size(65, 65);
            this.btnGuiEmail.Image = global::QLTrungTamTiengAnh.Properties.Resources.gmail;
            this.btnGuiEmail.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnGuiEmail.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnGuiEmail.Name = "btnGuiEmail";
            this.btnGuiEmail.Text = "Gửi Email";
            this.btnGuiEmail.Click += new System.EventHandler(this.btnGuiEmail_Click);
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
            this.btnDangKyHoc,
            this.btnXemChiTiet,
            this.btnSuaHoSo,
            this.buttonItem4,
            this.buttonItem1,
            this.buttonItem2});
            this.ribbonBar1.Location = new System.Drawing.Point(2, 1);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(408, 86);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2010;
            this.ribbonBar1.TabIndex = 2;
            this.ribbonBar1.Text = "Tình Trạng Học Tập";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnDangKyHoc
            // 
            this.btnDangKyHoc.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnDangKyHoc.FixedSize = new System.Drawing.Size(65, 65);
            this.btnDangKyHoc.Image = global::QLTrungTamTiengAnh.Properties.Resources.register;
            this.btnDangKyHoc.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnDangKyHoc.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnDangKyHoc.Name = "btnDangKyHoc";
            this.btnDangKyHoc.Text = "Đăng Ký     Học";
            this.btnDangKyHoc.Click += new System.EventHandler(this.btnDangKyHoc_Click);
            // 
            // btnXemChiTiet
            // 
            this.btnXemChiTiet.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXemChiTiet.FixedSize = new System.Drawing.Size(65, 65);
            this.btnXemChiTiet.Image = global::QLTrungTamTiengAnh.Properties.Resources.profile;
            this.btnXemChiTiet.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnXemChiTiet.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXemChiTiet.Name = "btnXemChiTiet";
            this.btnXemChiTiet.Text = "Xem          Chi Tiết";
            this.btnXemChiTiet.Click += new System.EventHandler(this.btnXemChiTiet_Click);
            // 
            // btnSuaHoSo
            // 
            this.btnSuaHoSo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSuaHoSo.FixedSize = new System.Drawing.Size(65, 65);
            this.btnSuaHoSo.Image = global::QLTrungTamTiengAnh.Properties.Resources.edit_user;
            this.btnSuaHoSo.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSuaHoSo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSuaHoSo.Name = "btnSuaHoSo";
            this.btnSuaHoSo.Text = "Cập Nhật Trạng Thái";
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.FixedSize = new System.Drawing.Size(65, 65);
            this.buttonItem4.Image = global::QLTrungTamTiengAnh.Properties.Resources.delete_user;
            this.buttonItem4.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Text = "Hủy       Đăng Ký";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.FixedSize = new System.Drawing.Size(65, 65);
            this.buttonItem1.Image = global::QLTrungTamTiengAnh.Properties.Resources.delete_user;
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Bảo Lưu Học Tập";
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.FixedSize = new System.Drawing.Size(65, 65);
            this.buttonItem2.Image = global::QLTrungTamTiengAnh.Properties.Resources.edit_user;
            this.buttonItem2.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Kết Thúc Học Phần";
            // 
            // FormQuanLyHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 634);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelEx1);
            this.Name = "FormQuanLyHocTap";
            this.Text = "Quản Lý Học Tập";
            this.Load += new System.EventHandler(this.FormQuanLyHocTap_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHocVien)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpDangKyTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDangKyDen)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem btnGuiEmail;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnDangKyHoc;
        private DevComponents.DotNetBar.ButtonItem btnXemChiTiet;
        private DevComponents.DotNetBar.ButtonItem btnSuaHoSo;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private Component.XDataGridView dgvDSHocVien;
        private DevComponents.DotNetBar.ButtonX btnLoc;
        private DevComponents.DotNetBar.ButtonX btnLamMoi;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpDangKyTu;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpDangKyDen;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbNamSinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbTruong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbXaPhuong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbQuanHuyen;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbTinhThanh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbNhanVien;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
    }
}