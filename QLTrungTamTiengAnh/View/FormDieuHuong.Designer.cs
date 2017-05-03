namespace QLTrungTamTiengAnh.View
{
    partial class FormDieuHuong
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new DevComponents.DotNetBar.TabControl();
            this.tabItem1 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
            this.tabItem2 = new DevComponents.DotNetBar.TabItem(this.components);
            this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dgvDSKhachHang = new QLTrungTamTiengAnh.Component.MDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabControlPanel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelEx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AutoCloseTabs = true;
            this.tabControl1.CanReorderTabs = true;
            this.tabControl1.CloseButtonOnTabsVisible = true;
            this.tabControl1.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabControl1.CloseButtonVisible = true;
            this.tabControl1.Controls.Add(this.tabControlPanel2);
            this.tabControl1.Controls.Add(this.tabControlPanel1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.FixedTabSize = new System.Drawing.Size(0, 25);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabControl1.SelectedTabIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(817, 538);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabControl1.Tabs.Add(this.tabItem1);
            this.tabControl1.Tabs.Add(this.tabItem2);
            this.tabControl1.Text = "tabControl1";
            // 
            // tabItem1
            // 
            this.tabItem1.AttachedControl = this.tabControlPanel1;
            this.tabItem1.CloseButtonVisible = false;
            this.tabItem1.Name = "tabItem1";
            this.tabItem1.Text = "Điều Hướng";
            // 
            // tabControlPanel1
            // 
            this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel1.Location = new System.Drawing.Point(0, 31);
            this.tabControlPanel1.Name = "tabControlPanel1";
            this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel1.Size = new System.Drawing.Size(817, 507);
            this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel1.Style.GradientAngle = 90;
            this.tabControlPanel1.TabIndex = 1;
            this.tabControlPanel1.TabItem = this.tabItem1;
            // 
            // tabItem2
            // 
            this.tabItem2.AttachedControl = this.tabControlPanel2;
            this.tabItem2.Name = "tabItem2";
            this.tabItem2.Text = "Quản Lý Khách Hàng";
            // 
            // tabControlPanel2
            // 
            this.tabControlPanel2.Controls.Add(this.tableLayoutPanel1);
            this.tabControlPanel2.Controls.Add(this.panelEx1);
            this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPanel2.Location = new System.Drawing.Point(0, 31);
            this.tabControlPanel2.Name = "tabControlPanel2";
            this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
            this.tabControlPanel2.Size = new System.Drawing.Size(817, 507);
            this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
            this.tabControlPanel2.Style.GradientAngle = 90;
            this.tabControlPanel2.TabIndex = 2;
            this.tabControlPanel2.TabItem = this.tabItem2;
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx1.Controls.Add(this.ribbonBar2);
            this.panelEx1.Controls.Add(this.ribbonBar1);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx1.Location = new System.Drawing.Point(1, 1);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(815, 90);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.Color = System.Drawing.SystemColors.MenuBar;
            this.panelEx1.Style.BackColor2.Color = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.Color = System.Drawing.SystemColors.ControlDark;
            this.panelEx1.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.panelEx1.Style.BorderWidth = 2;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 4;
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
            this.ribbonBar2.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem5,
            this.buttonItem6,
            this.buttonItem7});
            this.ribbonBar2.Location = new System.Drawing.Point(278, 1);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(210, 86);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar2.TabIndex = 3;
            this.ribbonBar2.Text = "Chăm Sóc Khách Hàng";
            // 
            // 
            // 
            this.ribbonBar2.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.TitleStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonBar2.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.ribbonBar2.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar2.TitleStyleMouseOver.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonBar2.TitleStyleMouseOver.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // buttonItem5
            // 
            this.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem5.FixedSize = new System.Drawing.Size(65, 65);
            this.buttonItem5.Image = global::QLTrungTamTiengAnh.Properties.Resources.register;
            this.buttonItem5.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem5.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem5.Name = "buttonItem5";
            this.buttonItem5.Text = "Đăng Ký   Học";
            // 
            // buttonItem6
            // 
            this.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem6.FixedSize = new System.Drawing.Size(65, 65);
            this.buttonItem6.Image = global::QLTrungTamTiengAnh.Properties.Resources.profile;
            this.buttonItem6.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem6.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem6.Name = "buttonItem6";
            this.buttonItem6.Text = "Xem Nhật   Ký";
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
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2,
            this.buttonItem3,
            this.buttonItem4});
            this.ribbonBar1.Location = new System.Drawing.Point(2, 1);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Size = new System.Drawing.Size(276, 86);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBar1.TabIndex = 2;
            this.ribbonBar1.Text = "Hồ Sơ Cá Nhân";
            // 
            // 
            // 
            this.ribbonBar1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.TitleStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonBar1.TitleStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // 
            // 
            this.ribbonBar1.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBar1.TitleStyleMouseOver.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.ribbonBar1.TitleStyleMouseOver.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.FixedSize = new System.Drawing.Size(65, 65);
            this.buttonItem1.Image = global::QLTrungTamTiengAnh.Properties.Resources.add_user;
            this.buttonItem1.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Thêm Khách Hàng";
            // 
            // buttonItem2
            // 
            this.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem2.FixedSize = new System.Drawing.Size(65, 65);
            this.buttonItem2.Image = global::QLTrungTamTiengAnh.Properties.Resources.profile;
            this.buttonItem2.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Xem Hồ      Sơ";
            // 
            // buttonItem7
            // 
            this.buttonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem7.FixedSize = new System.Drawing.Size(65, 65);
            this.buttonItem7.Image = global::QLTrungTamTiengAnh.Properties.Resources.profile;
            this.buttonItem7.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem7.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem7.Name = "buttonItem7";
            this.buttonItem7.Text = "Gửi         Email";
            // 
            // buttonItem3
            // 
            this.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem3.FixedSize = new System.Drawing.Size(65, 65);
            this.buttonItem3.Image = global::QLTrungTamTiengAnh.Properties.Resources.edit_user;
            this.buttonItem3.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem3.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "Sửa Thông Tin";
            // 
            // buttonItem4
            // 
            this.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem4.FixedSize = new System.Drawing.Size(65, 65);
            this.buttonItem4.Image = global::QLTrungTamTiengAnh.Properties.Resources.delete_user;
            this.buttonItem4.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.buttonItem4.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Text = "Xóa Hồ      Sơ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.expandablePanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelEx2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvDSKhachHang, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(815, 415);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.expandablePanel1.HideControlsWhenCollapsed = true;
            this.expandablePanel1.Location = new System.Drawing.Point(3, 3);
            this.expandablePanel1.Name = "expandablePanel1";
            this.tableLayoutPanel1.SetRowSpan(this.expandablePanel1, 2);
            this.expandablePanel1.Size = new System.Drawing.Size(200, 409);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 0;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Lọc Danh Sách";
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx2.Controls.Add(this.textBoxX1);
            this.panelEx2.Controls.Add(this.labelX1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx2.Location = new System.Drawing.Point(209, 3);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(603, 34);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None;
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
            this.labelX1.Location = new System.Drawing.Point(0, 0);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(69, 34);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tìm Kiếm";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
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
            this.textBoxX1.Size = new System.Drawing.Size(534, 20);
            this.textBoxX1.TabIndex = 1;
            // 
            // dgvDSKhachHang
            // 
            this.dgvDSKhachHang.AllowUserToAddRows = false;
            this.dgvDSKhachHang.AllowUserToDeleteRows = false;
            this.dgvDSKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSKhachHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSKhachHang.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvDSKhachHang.Location = new System.Drawing.Point(209, 43);
            this.dgvDSKhachHang.MultiSelect = false;
            this.dgvDSKhachHang.Name = "dgvDSKhachHang";
            this.dgvDSKhachHang.ReadOnly = true;
            this.dgvDSKhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKhachHang.Size = new System.Drawing.Size(603, 369);
            this.dgvDSKhachHang.TabIndex = 2;
            // 
            // FormDieuHuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 538);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormDieuHuong";
            this.Text = "Phần Mềm Quản Lý Trung Tâm Tiếng Anh E-Speed";
            this.Load += new System.EventHandler(this.FormDieuHuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabControlPanel2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhachHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.TabControl tabControl1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
        private DevComponents.DotNetBar.TabItem tabItem1;
        private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
        private DevComponents.DotNetBar.ButtonItem buttonItem5;
        private DevComponents.DotNetBar.ButtonItem buttonItem6;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.TabItem tabItem2;
        private DevComponents.DotNetBar.ButtonItem buttonItem7;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private Component.MDataGridView dgvDSKhachHang;
    }
}