﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class PhieuThu
    {
        string soPhieuThu, liDoThu, maKhachHang,bangChu,nhomKhoanThu,ghiChu;
        decimal soTien;
        DateTime ngayThu;

        public string SoPhieuThu
        {
            get
            {
                return soPhieuThu;
            }

            set
            {
                soPhieuThu = value;
            }
        }

        public string LiDoThu
        {
            get
            {
                return liDoThu;
            }

            set
            {
                liDoThu = value;
            }
        }

        public string MaKhachHang
        {
            get
            {
                return maKhachHang;
            }

            set
            {
                maKhachHang = value;
            }
        }

        public string BangChu
        {
            get
            {
                return bangChu;
            }

            set
            {
                bangChu = value;
            }
        }

        public string NhomKhoanThu
        {
            get
            {
                return nhomKhoanThu;
            }

            set
            {
                nhomKhoanThu = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public decimal SoTien
        {
            get
            {
                return soTien;
            }

            set
            {
                soTien = value;
            }
        }

        public DateTime NgayThu
        {
            get
            {
                return ngayThu;
            }

            set
            {
                ngayThu = value;
            }
        }
    }
}
