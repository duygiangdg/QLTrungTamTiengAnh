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
            DataTable dt = new DataTable();
            cmd.CommandText = "select * from tb_KhachHang";
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