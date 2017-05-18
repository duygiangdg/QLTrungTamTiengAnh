namespace QLTrungTamTiengAnh.Component
{
    partial class ScheduleTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbbTask = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbTask
            // 
            this.cbbTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbTask.DisplayMember = "Text";
            this.cbbTask.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTask.FormattingEnabled = true;
            this.cbbTask.ItemHeight = 14;
            this.cbbTask.Location = new System.Drawing.Point(0, 105);
            this.cbbTask.Name = "cbbTask";
            this.cbbTask.Size = new System.Drawing.Size(171, 20);
            this.cbbTask.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cbbTask.TabIndex = 1;
            this.cbbTask.SelectedIndexChanged += new System.EventHandler(this.cbbTask_SelectedIndexChanged);
            // 
            // btnTask
            // 
            this.btnTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTask.Location = new System.Drawing.Point(0, 0);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(171, 126);
            this.btnTask.TabIndex = 2;
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // ScheduleTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.cbbTask);
            this.Name = "ScheduleTask";
            this.Size = new System.Drawing.Size(171, 126);
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbbTask;
        private System.Windows.Forms.Button btnTask;
    }
}
