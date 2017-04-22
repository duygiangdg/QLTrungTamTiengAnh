using QLTrungTamTiengAnh.Object;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBanHang.Model
{
    class NhanVienMod
    {
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();

        public DataTable GetData()
        {
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

        public bool AddData(KhachHangObj khachHangObj)
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
    }
}