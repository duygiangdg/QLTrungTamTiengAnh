using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    class BangDiem
    {
        string maKhachHang, maHocPhan, nhanXet;
        decimal diem;

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

        public string MaHocPhan
        {
            get
            {
                return maHocPhan;
            }

            set
            {
                maHocPhan = value;
            }
        }

        public string NhanXet
        {
            get
            {
                return nhanXet;
            }

            set
            {
                nhanXet = value;
            }
        }

        public decimal Diem
        {
            get
            {
                return diem;
            }

            set
            {
                diem = value;
            }
        }
    }
}
