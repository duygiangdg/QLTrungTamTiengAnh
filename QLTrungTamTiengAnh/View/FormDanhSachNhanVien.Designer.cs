namespace QLTrungTamTiengAnh.View
{
    partial class FormDanhSachNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnLoc = new DevComponents.DotNetBar.ButtonX();
            this.btnLamMoi = new DevComponents.DotNetBar.ButtonX();
            this.dtpNgayTaoTu = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.dtpNgayTaoDen = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.cbbNamSinh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbTruong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnThem = new DevComponents.DotNetBar.ButtonItem();
            this.btnXem = new DevComponents.DotNetBar.ButtonItem();
            this.btnSua = new DevComponents.DotNetBar.ButtonItem();
            this.btnXoa = new DevComponents.DotNetBar.ButtonItem();
            this.cbbXaPhuong = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbQuanHuyen = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cbbTinhThanh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDSNhanVien = new QLTrungTamTiengAnh.Component.XDataGridView();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTaoTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTaoDen)).BeginInit();
            this.panelEx2.SuspendLayout();
            this.expandablePanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).BeginInit();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
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
            // btnLoc
            // 
            this.btnLoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLoc.Location = new System.Drawing.Point(108, 443);
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
            this.btnLamMoi.Location = new System.Drawing.Point(8, 443);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 23);
            this.btnLamMoi.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLamMoi.TabIndex = 5;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dtpNgayTaoTu
            // 
            // 
            // 
            // 
            this.dtpNgayTaoTu.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgayTaoTu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayTaoTu.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpNgayTaoTu.ButtonDropDown.Visible = true;
            this.dtpNgayTaoTu.IsPopupCalendarOpen = false;
            this.dtpNgayTaoTu.Location = new System.Drawing.Point(10, 344);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpNgayTaoTu.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayTaoTu.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpNgayTaoTu.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpNgayTaoTu.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgayTaoTu.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayTaoTu.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgayTaoTu.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgayTaoTu.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgayTaoTu.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgayTaoTu.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayTaoTu.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.dtpNgayTaoTu.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtpNgayTaoTu.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgayTaoTu.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayTaoTu.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgayTaoTu.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayTaoTu.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgayTaoTu.Name = "dtpNgayTaoTu";
            this.dtpNgayTaoTu.Size = new System.Drawing.Size(186, 20);
            this.dtpNgayTaoTu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpNgayTaoTu.TabIndex = 4;
            // 
            // dtpNgayTaoDen
            // 
            // 
            // 
            // 
            this.dtpNgayTaoDen.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgayTaoDen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayTaoDen.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpNgayTaoDen.ButtonDropDown.Visible = true;
            this.dtpNgayTaoDen.IsPopupCalendarOpen = false;
            this.dtpNgayTaoDen.Location = new System.Drawing.Point(10, 399);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpNgayTaoDen.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayTaoDen.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpNgayTaoDen.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpNgayTaoDen.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgayTaoDen.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayTaoDen.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgayTaoDen.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgayTaoDen.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgayTaoDen.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgayTaoDen.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayTaoDen.MonthCalendar.DisplayMonth = new System.DateTime(2017, 5, 1, 0, 0, 0, 0);
            this.dtpNgayTaoDen.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.dtpNgayTaoDen.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgayTaoDen.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayTaoDen.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgayTaoDen.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayTaoDen.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgayTaoDen.Name = "dtpNgayTaoDen";
            this.dtpNgayTaoDen.Size = new System.Drawing.Size(186, 20);
            this.dtpNgayTaoDen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpNgayTaoDen.TabIndex = 4;
            // 
            // radNu
            // 
            this.radNu.BackColor = System.Drawing.Color.Transparent;
            this.radNu.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radNu.Location = new System.Drawing.Point(163, 260);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(33, 49);
            this.radNu.TabIndex = 3;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radNu.UseVisualStyleBackColor = false;
            // 
            // radNam
            // 
            this.radNam.BackColor = System.Drawing.Color.Transparent;
            this.radNam.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radNam.Location = new System.Drawing.Point(127, 260);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(33, 49);
            this.radNam.TabIndex = 3;
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
            this.cbbNamSinh.Location = new System.Drawing.Point(8, 289);
            this.cbbNamSinh.Name = "cbbNamSinh";
            this.cbbNamSinh.Size = new System.Drawing.Size(94, 20);
            this.cbbNamSinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbNamSinh.TabIndex = 2;
            // 
            // cbbTruong
            // 
            this.cbbTruong.DisplayMember = "Text";
            this.cbbTruong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTruong.FormattingEnabled = true;
            this.cbbTruong.ItemHeight = 14;
            this.cbbTruong.Location = new System.Drawing.Point(9, 234);
            this.cbbTruong.Name = "cbbTruong";
            this.cbbTruong.Size = new System.Drawing.Size(188, 20);
            this.cbbTruong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbTruong.TabIndex = 2;
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
            this.ribbonBar1.Text = "Hồ Sơ Cá Nhân";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnThem.FixedSize = new System.Drawing.Size(65, 65);
            this.btnThem.Image = global::QLTrungTamTiengAnh.Properties.Resources.add_user;
            this.btnThem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnThem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnThem.Name = "btnThem";
            this.btnThem.Text = "Thêm Nhân Viên";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXem
            // 
            this.btnXem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXem.FixedSize = new System.Drawing.Size(65, 65);
            this.btnXem.Image = global::QLTrungTamTiengAnh.Properties.Resources.profile;
            this.btnXem.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnXem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXem.Name = "btnXem";
            this.btnXem.Text = "Xem Hồ      Sơ";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSua.FixedSize = new System.Drawing.Size(65, 65);
            this.btnSua.Image = global::QLTrungTamTiengAnh.Properties.Resources.edit_user;
            this.btnSua.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnSua.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSua.Name = "btnSua";
            this.btnSua.Text = "Sửa Thông Tin";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnXoa.FixedSize = new System.Drawing.Size(65, 65);
            this.btnXoa.Image = global::QLTrungTamTiengAnh.Properties.Resources.delete_user;
            this.btnXoa.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.btnXoa.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Text = "Xóa Hồ      Sơ";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbbXaPhuong
            // 
            this.cbbXaPhuong.DisplayMember = "Text";
            this.cbbXaPhuong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbXaPhuong.FormattingEnabled = true;
            this.cbbXaPhuong.ItemHeight = 14;
            this.cbbXaPhuong.Location = new System.Drawing.Point(9, 179);
            this.cbbXaPhuong.Name = "cbbXaPhuong";
            this.cbbXaPhuong.Size = new System.Drawing.Size(188, 20);
            this.cbbXaPhuong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbXaPhuong.TabIndex = 2;
            // 
            // cbbQuanHuyen
            // 
            this.cbbQuanHuyen.DisplayMember = "Text";
            this.cbbQuanHuyen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbQuanHuyen.FormattingEnabled = true;
            this.cbbQuanHuyen.ItemHeight = 14;
            this.cbbQuanHuyen.Location = new System.Drawing.Point(9, 124);
            this.cbbQuanHuyen.Name = "cbbQuanHuyen";
            this.cbbQuanHuyen.Size = new System.Drawing.Size(188, 20);
            this.cbbQuanHuyen.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbQuanHuyen.TabIndex = 2;
            // 
            // cbbTinhThanh
            // 
            this.cbbTinhThanh.DisplayMember = "Text";
            this.cbbTinhThanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTinhThanh.FormattingEnabled = true;
            this.cbbTinhThanh.ItemHeight = 14;
            this.cbbTinhThanh.Location = new System.Drawing.Point(8, 69);
            this.cbbTinhThanh.Name = "cbbTinhThanh";
            this.cbbTinhThanh.Size = new System.Drawing.Size(188, 20);
            this.cbbTinhThanh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbTinhThanh.TabIndex = 2;
            // 
            // labelX9
            // 
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(9, 315);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(188, 23);
            this.labelX9.TabIndex = 1;
            this.labelX9.Text = "Ngày tạo từ:";
            // 
            // labelX8
            // 
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(9, 370);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(188, 23);
            this.labelX8.TabIndex = 1;
            this.labelX8.Text = "Đến ngày:";
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(8, 260);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(94, 23);
            this.labelX7.TabIndex = 1;
            this.labelX7.Text = "Năm sinh:";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.textBoxX1);
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
            // textBoxX1
            // 
            this.textBoxX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBoxX1.Location = new System.Drawing.Point(69, 8);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(520, 20);
            this.textBoxX1.TabIndex = 1;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(9, 205);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(188, 23);
            this.labelX6.TabIndex = 1;
            this.labelX6.Text = "Trường:";
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(9, 150);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(188, 23);
            this.labelX5.TabIndex = 1;
            this.labelX5.Text = "Xã/ phường:";
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(9, 95);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(188, 23);
            this.labelX4.TabIndex = 1;
            this.labelX4.Text = "Quận/ huyện:";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(8, 40);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(188, 23);
            this.labelX3.TabIndex = 1;
            this.labelX3.Text = "Tình/ thành phố:";
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.btnLoc);
            this.expandablePanel1.Controls.Add(this.btnLamMoi);
            this.expandablePanel1.Controls.Add(this.dtpNgayTaoTu);
            this.expandablePanel1.Controls.Add(this.dtpNgayTaoDen);
            this.expandablePanel1.Controls.Add(this.radNu);
            this.expandablePanel1.Controls.Add(this.radNam);
            this.expandablePanel1.Controls.Add(this.cbbNamSinh);
            this.expandablePanel1.Controls.Add(this.cbbTruong);
            this.expandablePanel1.Controls.Add(this.cbbXaPhuong);
            this.expandablePanel1.Controls.Add(this.cbbQuanHuyen);
            this.expandablePanel1.Controls.Add(this.cbbTinhThanh);
            this.expandablePanel1.Controls.Add(this.labelX9);
            this.expandablePanel1.Controls.Add(this.labelX8);
            this.expandablePanel1.Controls.Add(this.labelX7);
            this.expandablePanel1.Controls.Add(this.labelX6);
            this.expandablePanel1.Controls.Add(this.labelX5);
            this.expandablePanel1.Controls.Add(this.labelX4);
            this.expandablePanel1.Controls.Add(this.labelX3);
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
            this.tableLayoutPanel1.Controls.Add(this.dgvDSNhanVien, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(801, 531);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // dgvDSNhanVien
            // 
            this.dgvDSNhanVien.AllowUserToAddRows = false;
            this.dgvDSNhanVien.AllowUserToDeleteRows = false;
            this.dgvDSNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDSNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDSNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSNhanVien.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDSNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSNhanVien.EnableHeadersVisualStyles = false;
            this.dgvDSNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDSNhanVien.HighlightSelectedColumnHeaders = false;
            this.dgvDSNhanVien.Location = new System.Drawing.Point(209, 43);
            this.dgvDSNhanVien.Name = "dgvDSNhanVien";
            this.dgvDSNhanVien.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDSNhanVien.RowHeadersVisible = false;
            this.dgvDSNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSNhanVien.Size = new System.Drawing.Size(589, 485);
            this.dgvDSNhanVien.TabIndex = 2;
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
            this.panelEx1.TabIndex = 8;
            // 
            // FormDanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 626);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelEx1);
            this.Name = "FormDanhSachNhanVien";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.FormDanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTaoTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayTaoDen)).EndInit();
            this.panelEx2.ResumeLayout(false);
            this.expandablePanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNhanVien)).EndInit();
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnLoc;
        private DevComponents.DotNetBar.ButtonX btnLamMoi;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpNgayTaoTu;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpNgayTaoDen;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbNamSinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbTruong;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem btnThem;
        private DevComponents.DotNetBar.ButtonItem btnXem;
        private DevComponents.DotNetBar.ButtonItem btnSua;
        private DevComponents.DotNetBar.ButtonItem btnXoa;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbXaPhuong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbQuanHuyen;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbTinhThanh;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX8;
        private Component.XDataGridView dgvDSNhanVien;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
    }
}