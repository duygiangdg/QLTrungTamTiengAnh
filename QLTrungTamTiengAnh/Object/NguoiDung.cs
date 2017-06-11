using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    class NguoiDung
    {
        string maNguoiDung, tenDangNhap, matKhau;
        bool quyen;

        public string MaNguoiDung
        {
            get
            {
                return maNguoiDung;
            }

            set
            {
                maNguoiDung = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }

        public bool Quyen
        {
            get
            {
                return quyen;
            }

            set
            {
                quyen = value;
            }
        }

        public string TenDangNhap
        {
            get
            {
                return tenDangNhap;
            }

            set
            {
                tenDangNhap = value;
            }
        }
    }
}
