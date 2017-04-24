using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class QuaTrinhObj
    {
        string maKhachHang, maNhanVien;
        DateTime ngayBatDau;
        int trinhDo;
        string mongMuon;

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

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }

        public DateTime NgayBatDau
        {
            get
            {
                return ngayBatDau;
            }

            set
            {
                ngayBatDau = value;
            }
        }

        public int TrinhDo
        {
            get
            {
                return trinhDo;
            }

            set
            {
                trinhDo = value;
            }
        }

        public string MongMuon
        {
            get
            {
                return mongMuon;
            }

            set
            {
                mongMuon = value;
            }
        }
    }
}
