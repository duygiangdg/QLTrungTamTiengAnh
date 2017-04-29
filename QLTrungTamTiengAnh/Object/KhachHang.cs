using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class KhachHang
    {
        string maKhachHang, tenKhachHang, diaChi, soDienThoai, email, truong, chuyenNganh;
        DateTime ngaySinh;

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

        public string TenKhachHang
        {
            get
            {
                return tenKhachHang;
            }

            set
            {
                tenKhachHang = value;
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

        public KhachHang()
        {

        }

        public KhachHang(string maKhachHang, string tenKhachHang, string diaChi, string soDienThoai, 
            string email, string truong, string chuyenNganh, DateTime ngaySinh)
        {
            this.maKhachHang = maKhachHang;
            this.tenKhachHang = tenKhachHang;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.truong = truong;
            this.chuyenNganh = chuyenNganh;
            this.ngaySinh = ngaySinh;
        }
    }
}