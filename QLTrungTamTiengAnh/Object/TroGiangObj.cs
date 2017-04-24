using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class TroGiangObj
    {
        string maTroGiang, tenTroGiang, diaChi, soDienThoai, email, truong, chuyenNganh;
        int chucVu;
        DateTime ngaySinh;

        public string MaTroGiang
        {
            get
            {
                return maTroGiang;
            }

            set
            {
                maTroGiang = value;
            }
        }

        public string TenTroGiang
        {
            get
            {
                return tenTroGiang;
            }

            set
            {
                tenTroGiang = value;
            }
        }

        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        public string SoDienThoai
        {
            get
            {
                return soDienThoai;
            }

            set
            {
                soDienThoai = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Truong
        {
            get
            {
                return truong;
            }

            set
            {
                truong = value;
            }
        }

        public string ChuyenNganh
        {
            get
            {
                return chuyenNganh;
            }

            set
            {
                chuyenNganh = value;
            }
        }

        public int ChucVu
        {
            get
            {
                return chucVu;
            }

            set
            {
                chucVu = value;
            }
        }

        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }
    }
}
