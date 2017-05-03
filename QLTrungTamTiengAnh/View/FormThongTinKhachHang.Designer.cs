using QLTrungTamTiengAnh.Component;

namespace QLTrungTamTiengAnh.View
{
    partial class FormThongTinKhachHang
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
            this.textLabel1 = new TextLabel();
            this.textLabel2 = new TextLabel();
            this.textLabel3 = new TextLabel();
            this.textLabel4 = new TextLabel();
            this.textLabel5 = new TextLabel();
            this.textLabel6 = new TextLabel();
            this.textLabel7 = new TextLabel();
            this.textLabel8 = new TextLabel();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.TabIndex = 8;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Controls.Add(this.textLabel8);
            this.groupPanel1.Controls.Add(this.textLabel6);
            this.groupPanel1.Controls.Add(this.textLabel4);
            this.groupPanel1.Controls.Add(this.textLabel2);
            this.groupPanel1.Controls.Add(this.textLabel7);
            this.groupPanel1.Controls.Add(this.textLabel5);
            this.groupPanel1.Controls.Add(this.textLabel3);
            this.groupPanel1.Controls.Add(this.textLabel1);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // textLabel1
            // 
            this.textLabel1.Editable = false;
            this.textLabel1.BackColor = System.Drawing.Color.Transparent;
            this.textLabel1.Constrains = "";
            this.textLabel1.Label = "Mã Khách Hàng";
            this.textLabel1.Location = new System.Drawing.Point(36, 19);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.PropertyName = "MaKhachHang";
            this.textLabel1.Size = new System.Drawing.Size(200, 39);
            this.textLabel1.TabIndex = 9;
            // 
            // textLabel2
            // 
            this.textLabel2.Editable = true;
            this.textLabel2.BackColor = System.Drawing.Color.Transparent;
            this.textLabel2.Constrains = "NotEmpty";
            this.textLabel2.Label = "Tên Khách Hàng";
            this.textLabel2.Location = new System.Drawing.Point(295, 19);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.PropertyName = "TenKhachHang";
            this.textLabel2.Size = new System.Drawing.Size(200, 39);
            this.textLabel2.TabIndex = 0;
            // 
            // textLabel3
            // 
            this.textLabel3.Editable = true;
            this.textLabel3.BackColor = System.Drawing.Color.Transparent;
            this.textLabel3.Constrains = "DateTime";
            this.textLabel3.Label = "Ngày Sinh";
            this.textLabel3.Location = new System.Drawing.Point(36, 66);
            this.textLabel3.Name = "textLabel3";
            this.textLabel3.PropertyName = "NgaySinh";
            this.textLabel3.Size = new System.Drawing.Size(200, 39);
            this.textLabel3.TabIndex = 1;
            // 
            // textLabel4
            // 
            this.textLabel4.Editable = true;
            this.textLabel4.BackColor = System.Drawing.Color.Transparent;
            this.textLabel4.Constrains = "";
            this.textLabel4.Label = "Địa Chỉ";
            this.textLabel4.Location = new System.Drawing.Point(295, 66);
            this.textLabel4.Name = "textLabel4";
            this.textLabel4.PropertyName = "DiaChi";
            this.textLabel4.Size = new System.Drawing.Size(200, 39);
            this.textLabel4.TabIndex = 2;
            // 
            // textLabel5
            // 
            this.textLabel5.Editable = true;
            this.textLabel5.BackColor = System.Drawing.Color.Transparent;
            this.textLabel5.Constrains = "Integer";
            this.textLabel5.Label = "Số Điện Thoại";
            this.textLabel5.Location = new System.Drawing.Point(36, 113);
            this.textLabel5.Name = "textLabel5";
            this.textLabel5.PropertyName = "SoDienThoai";
            this.textLabel5.Size = new System.Drawing.Size(200, 39);
            this.textLabel5.TabIndex = 3;
            // 
            // textLabel6
            // 
            this.textLabel6.Editable = true;
            this.textLabel6.BackColor = System.Drawing.Color.Transparent;
            this.textLabel6.Constrains = "";
            this.textLabel6.Label = "Email";
            this.textLabel6.Location = new System.Drawing.Point(295, 113);
            this.textLabel6.Name = "textLabel6";
            this.textLabel6.PropertyName = "Email";
            this.textLabel6.Size = new System.Drawing.Size(200, 39);
            this.textLabel6.TabIndex = 4;
            // 
            // textLabel7
            // 
            this.textLabel7.Editable = true;
            this.textLabel7.BackColor = System.Drawing.Color.Transparent;
            this.textLabel7.Constrains = "";
            this.textLabel7.Label = "Trường";
            this.textLabel7.Location = new System.Drawing.Point(36, 160);
            this.textLabel7.Name = "textLabel7";
            this.textLabel7.PropertyName = "Truong";
            this.textLabel7.Size = new System.Drawing.Size(200, 39);
            this.textLabel7.TabIndex = 5;
            // 
            // textLabel8
            // 
            this.textLabel8.Editable = true;
            this.textLabel8.BackColor = System.Drawing.Color.Transparent;
            this.textLabel8.Constrains = "";
            this.textLabel8.Label = "Chuyên Ngành";
            this.textLabel8.Location = new System.Drawing.Point(295, 160);
            this.textLabel8.Name = "textLabel8";
            this.textLabel8.PropertyName = "ChuyenNganh";
            this.textLabel8.Size = new System.Drawing.Size(200, 39);
            this.textLabel8.TabIndex = 6;
            // 
            // FormThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 329);
            this.Name = "FormThongTinKhachHang";
            this.Text = "Thông Tin Khách Hàng";
            this.Load += new System.EventHandler(this.FormThongTinKhachHang_Load);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TextLabel textLabel8;
        private TextLabel textLabel6;
        private TextLabel textLabel4;
        private TextLabel textLabel2;
        private TextLabel textLabel7;
        private TextLabel textLabel5;
        private TextLabel textLabel3;
        private TextLabel textLabel1;
    }
}