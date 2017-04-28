﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Model
{
    class SqlConnector
    {
        #region Availible

        private SqlConnection Conn;
        private SqlCommand _cmd;

        public SqlCommand Cmd
        {
            get
            {
                return _cmd;
            }

            set
            {
                _cmd = value;
            }
        }

        public SqlConnection Connection { get { return Conn; } }

        public string Error
        {
            get
            {
                return error;
            }

            set
            {
                error = value;
            }
        }

        private string error;
        string StrCon;

        #endregion

        #region Contructor

        public SqlConnector()
        {
            StrCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLTrungTamTiengAnh;User ID=sa; Password=123";
            Conn = new SqlConnection(StrCon);
        }

        #endregion

        #region Methods

        public bool OpenConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Closed)
                    Conn.Open();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }

        public bool CloseConn()
        {
            try
            {
                if (Conn.State == ConnectionState.Open)
                    Conn.Close();
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            return true;
        }

        public DataTable getThongTin()
        {
            DataTable dt = new DataTable();
            SqlCommand Cmd = new SqlCommand();
            Cmd = new SqlCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "select * from ThongTin";
            Cmd.Connection = Conn;
            try
            {
                OpenConn();
                SqlDataAdapter sda = new SqlDataAdapter(Cmd);
                sda.Fill(dt);
                CloseConn();
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
            return dt;
        }

        #endregion
    }
}