namespace QLTrungTamTiengAnh.View
{
    partial class FormGuiEmail
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.btnGui = new DevComponents.DotNetBar.ButtonX();
            this.txtNoiDung = new QLTrungTamTiengAnh.Component.XTextBox();
            this.txtChuDe = new QLTrungTamTiengAnh.Component.XTextBox();
            this.txtNguoiNhan = new QLTrungTamTiengAnh.Component.XTextBox();
            this.txtNguoiGui = new QLTrungTamTiengAnh.Component.XTextBox();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(22, 21);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Người gửi:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(22, 50);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Người nhận:";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(22, 79);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Chủ đề:";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(22, 108);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Nội dung:";
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(451, 328);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnGui
            // 
            this.btnGui.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnGui.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnGui.Location = new System.Drawing.Point(370, 328);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(75, 23);
            this.btnGui.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnGui.TabIndex = 2;
            this.btnGui.Text = "Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.AutoInput = false;
            // 
            // 
            // 
            this.txtNoiDung.Border.Class = "TextBoxBorder";
            this.txtNoiDung.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNoiDung.DisplayedName = null;
            this.txtNoiDung.Location = new System.Drawing.Point(91, 110);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.PropertyName = "";
            this.txtNoiDung.Required = false;
            this.txtNoiDung.Size = new System.Drawing.Size(435, 199);
            this.txtNoiDung.TabIndex = 1;
            this.txtNoiDung.Type = "Text";
            // 
            // txtChuDe
            // 
            this.txtChuDe.AutoInput = false;
            // 
            // 
            // 
            this.txtChuDe.Border.Class = "TextBoxBorder";
            this.txtChuDe.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChuDe.DisplayedName = null;
            this.txtChuDe.Location = new System.Drawing.Point(91, 81);
            this.txtChuDe.Name = "txtChuDe";
            this.txtChuDe.PropertyName = "";
            this.txtChuDe.Required = false;
            this.txtChuDe.Size = new System.Drawing.Size(435, 20);
            this.txtChuDe.TabIndex = 1;
            this.txtChuDe.Type = "Text";
            // 
            // txtNguoiNhan
            // 
            this.txtNguoiNhan.AutoInput = false;
            // 
            // 
            // 
            this.txtNguoiNhan.Border.Class = "TextBoxBorder";
            this.txtNguoiNhan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNguoiNhan.DisplayedName = null;
            this.txtNguoiNhan.Location = new System.Drawing.Point(91, 52);
            this.txtNguoiNhan.Name = "txtNguoiNhan";
            this.txtNguoiNhan.PropertyName = "";
            this.txtNguoiNhan.ReadOnly = true;
            this.txtNguoiNhan.Required = false;
            this.txtNguoiNhan.Size = new System.Drawing.Size(435, 20);
            this.txtNguoiNhan.TabIndex = 1;
            this.txtNguoiNhan.Type = "Text";
            // 
            // txtNguoiGui
            // 
            this.txtNguoiGui.AutoInput = false;
            // 
            // 
            // 
            this.txtNguoiGui.Border.Class = "TextBoxBorder";
            this.txtNguoiGui.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtNguoiGui.DisplayedName = null;
            this.txtNguoiGui.Location = new System.Drawing.Point(91, 23);
            this.txtNguoiGui.Name = "txtNguoiGui";
            this.txtNguoiGui.PropertyName = "";
            this.txtNguoiGui.ReadOnly = true;
            this.txtNguoiGui.Required = false;
            this.txtNguoiGui.Size = new System.Drawing.Size(189, 20);
            this.txtNguoiGui.TabIndex = 1;
            this.txtNguoiGui.Text = "Trung tâm Tiếng Anh Espeed";
            this.txtNguoiGui.Type = "Text";
            // 
            // FormGuiEmail
            // 
            this.ClientSize = new System.Drawing.Size(549, 363);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtChuDe);
            this.Controls.Add(this.txtNguoiNhan);
            this.Controls.Add(this.txtNguoiGui);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGuiEmail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gửi Email";
            this.Load += new System.EventHandler(this.FormGuiEmail_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private Component.XTextBox txtNguoiGui;
        private DevComponents.DotNetBar.LabelX labelX3;
        private Component.XTextBox txtNguoiNhan;
        private DevComponents.DotNetBar.LabelX labelX4;
        private Component.XTextBox txtChuDe;
        private DevComponents.DotNetBar.LabelX labelX5;
        private Component.XTextBox txtNoiDung;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.ButtonX btnGui;
    }
}