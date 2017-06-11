namespace QLTrungTamTiengAnh.View
{
    partial class FormQLKhuyenMai
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
            this.dgvDSKhuyenMai = new QLTrungTamTiengAnh.Component.XDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.dgvDSKhuyenMai);
            this.panel1.Dock = System.Windows.Forms.DockStyle.None;
            this.panel1.Size = new System.Drawing.Size(600, 446);
            // 
            // dgvDSKhuyenMai
            // 
            this.dgvDSKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSKhuyenMai.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSKhuyenMai.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDSKhuyenMai.Location = new System.Drawing.Point(40, 38);
            this.dgvDSKhuyenMai.Name = "dgvDSKhuyenMai";
            this.dgvDSKhuyenMai.Size = new System.Drawing.Size(518, 373);
            this.dgvDSKhuyenMai.TabIndex = 1;
            this.dgvDSKhuyenMai.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvDSKhuyenMai_UserAddedRow);
            // 
            // FormQLKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 446);
            this.Name = "FormQLKhuyenMai";
            this.Text = "Quản Lý Khuyến Mãi";
            this.Load += new System.EventHandler(this.FormQLKhuyenMai_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhuyenMai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Component.XDataGridView dgvDSKhuyenMai;
    }
}