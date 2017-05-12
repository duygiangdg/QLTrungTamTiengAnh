﻿using QLTrungTamTiengAnh.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.View
{
    public partial class FormDanhSachKhachHang : Form
    {
        public FormDanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void FormDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnThemHoSo_Click(object sender, EventArgs e)
        {
            FormDieuHuong.Instance.CreateTab(new FormHoSoKhachHang());
        }

        private void btnXemHoSo_Click(object sender, EventArgs e)
        {       
            if (dgvDSKhachHang.SelectedRows.Count == 1)
            {
                string maKhachHang = dgvDSKhachHang.SelectedRows[0].Cells[0].Value.ToString();
                FormHoSoKhachHang form = new FormHoSoKhachHang();
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng trong bảng để xem hồ sơ");
            }
        }

        private void btnSuaHoSo_Click(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count == 1)
            {
                string maKhachHang = dgvDSKhachHang.SelectedRows[0].Cells[0].Value.ToString();
                FormHoSoKhachHang form = new FormHoSoKhachHang();
                FormDieuHuong.Instance.CreateTab(form);
            }
            else
            {
                MessageBox.Show("Hãy chọn một khách hàng trong bảng để cập nhật hồ sơ");
            }
        }

        private void btnXoaHoSo_Click(object sender, EventArgs e)
        {
            if (dgvDSKhachHang.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa " + dgvDSKhachHang.SelectedRows.Count + " hồ sơ khách hàng?", 
                    "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    foreach(DataGridViewRow row in dgvDSKhachHang.SelectedRows)
                    {
                        string maKhachHang = row.Cells[0].Value.ToString();
                        DataIO.DeleteItem("tb_KhachHang", "MaKhachHang", maKhachHang);
                    }
                }
                RefreshData();
            }
            else
            {
                MessageBox.Show("Hãy chọn khách hàng trong bảng để xóa hồ sơ");
            }
        }

        private void RefreshData()
        {
            DataTable dt = DataIO.GetData("SELECT * FROM vw_KhachHang");
            dgvDSKhachHang.DataSource = dt;
        }
    }
}