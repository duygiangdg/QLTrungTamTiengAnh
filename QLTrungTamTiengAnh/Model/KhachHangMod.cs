using QLTrungTamTiengAnh.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Model
{
    public class KhachHangMod
    {
        SqlConnector con = new SqlConnector();
        SqlCommand cmd = new SqlCommand();
        public static KhachHangMod Instance = new KhachHangMod();

        private KhachHangMod() { }

        // Tra ve du lieu cua toan bo khach hang kieu DataTable, null neu that bai
        public DataTable GetData()
        {
            // Fake data
            DataTable fakeData = new DataTable();
            fakeData.Columns.Add(new DataColumn("MaKhachHang", typeof(string)));
            fakeData.Columns.Add(new DataColumn("TenKhachHang", typeof(string)));
            fakeData.Columns.Add(new DataColumn("NgaySinh", typeof(DateTime)));
            fakeData.Columns.Add(new DataColumn("DiaChi", typeof(string)));
            fakeData.Columns.Add(new DataColumn("SoDienThoai", typeof(string)));
            fakeData.Columns.Add(new DataColumn("Email", typeof(string)));
            fakeData.Columns.Add(new DataColumn("Truong", typeof(string)));
            fakeData.Columns.Add(new DataColumn("ChuyenNganh", typeof(string)));

            DataRow dr0 = fakeData.NewRow();
            dr0[0] = "KH01";
            dr0[1] = "Mai Thanh Chung";
            dr0[2] = new DateTime();
            dr0[3] = "Home";
            dr0[4] = "0123456789";
            dr0[5] = "maithanhchung@gmail.com";
            dr0[6] = "DHBKHN";
            dr0[7] = "Toan Tin Ung Dung";
            fakeData.Rows.Add(dr0);

            DataRow dr1 = fakeData.NewRow();
            dr1[0] = "KH02";
            dr1[1] = "Vu Van Bo";
            dr1[2] = new DateTime();
            dr1[3] = "Home";
            dr1[4] = "0123456789";
            dr1[5] = "vuvanbo@gmail.com";
            dr1[6] = "DHBKHN";
            dr1[7] = "Toan Tin Ung Dung";
            fakeData.Rows.Add(dr1);

            DataRow dr2 = fakeData.NewRow();
            dr2[0] = "KH03";
            dr2[1] = "Nguyen Duy Giang";
            dr2[2] = new DateTime();
            dr2[3] = "Home";
            dr2[4] = "0123456789";
            dr2[5] = "nguyenduygiang@gmail.com";
            dr2[6] = "DHBKHN";
            dr2[7] = "Toan Tin Ung Dung";
            fakeData.Rows.Add(dr2);

            return fakeData;

            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_KHACHHANG";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                con.CloseConn();
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return dt;
        }

        // Nhap vao ma khach hang, tra ve khach hang tuong ung
        public KhachHang getItem(string maKhachHang)
        {
            // ToDo: tra ve khach hang tu database, null neu khong ton tai
            return new KhachHang();
        }

        // Them mot khach hang vao database
        public bool AddItem(KhachHang khachHangObj)
        {
            cmd.CommandText = "insert into tb_KHACHHANG values ('"
                + khachHangObj.MaKhachHang + "','"
                + khachHangObj.TenKhachHang + "','"
                + khachHangObj.DiaChi + "', CONVER(DATE,'"
                + khachHangObj.NgaySinh.ToShortDateString() + "',103),'"
                + khachHangObj.SoDienThoai + "','"
                + khachHangObj.Email + "','"
                + khachHangObj.Truong + "','" 
                + khachHangObj.ChuyenNganh + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                return true;
            }
            catch (Exception ex)
            {
                string mes = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            return false;
        }

        // Cap nhat thong tin khach hang
        public bool UpdateItem(KhachHang khachHangObj)
        {
            // ToDo: chinh sua thong tin khach hang, 
            // tra ve true neu thanh cong, false neu that bai
            return false;
        }

        // Xoa khach hang khoi database
        public bool DeleteItem(string maKhachHang)
        {
            // ToDo: xoa khach hang khoi database, 
            // tra ve true neu thanh cong, false neu that bai
            return false;
        }

        // Xoa khach hang khoi database
        public bool DeleteItem(KhachHang khachHangObj)
        {
            DeleteItem(khachHangObj.MaKhachHang);
            return false;
        }
    }
}