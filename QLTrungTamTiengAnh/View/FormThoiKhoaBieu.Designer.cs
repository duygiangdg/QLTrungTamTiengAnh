namespace QLTrungTamTiengAnh.View
{
    partial class FormThoiKhoaBieu
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
            this.monthCalendarAdv1 = new DevComponents.Editors.DateTimeAdv.MonthCalendarAdv();
            this.SuspendLayout();
            // 
            // monthCalendarAdv1
            // 
            this.monthCalendarAdv1.AnnuallyMarkedDates = new System.DateTime[0];
            this.monthCalendarAdv1.AutoSize = true;
            // 
            // 
            // 
            this.monthCalendarAdv1.BackgroundStyle.Class = "MonthCalendarAdv";
            this.monthCalendarAdv1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.monthCalendarAdv1.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthCalendarAdv1.ContainerControlProcessDialogKey = true;
            this.monthCalendarAdv1.DaySize = new System.Drawing.Size(100, 50);
            this.monthCalendarAdv1.DisplayMonth = new System.DateTime(2017, 5, 7, 0, 0, 0, 0);
            this.monthCalendarAdv1.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.monthCalendarAdv1.Location = new System.Drawing.Point(36, 35);
            this.monthCalendarAdv1.MarkedDates = new System.DateTime[0];
            this.monthCalendarAdv1.MonthlyMarkedDates = new System.DateTime[0];
            this.monthCalendarAdv1.Name = "monthCalendarAdv1";
            // 
            // 
            // 
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.monthCalendarAdv1.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.monthCalendarAdv1.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.monthCalendarAdv1.Size = new System.Drawing.Size(702, 405);
            this.monthCalendarAdv1.TabIndex = 0;
            this.monthCalendarAdv1.Text = "monthCalendarAdv1";
            this.monthCalendarAdv1.WeeklyMarkedDays = new System.DayOfWeek[0];
            // 
            // FormThoiKhoaBieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 482);
            this.Controls.Add(this.monthCalendarAdv1);
            this.Name = "FormThoiKhoaBieu";
            this.Text = "FormThoiKhoaBieu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.Editors.DateTimeAdv.MonthCalendarAdv monthCalendarAdv1;
    }
}