using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class PhieuDangKy
    {
        string soDangKy, maKhachHang, maHocPhan;
        DateTime ngayDangKy;

        public string SoDangKy
        {
            get
            {
                return soDangKy;
            }

            set
            {
                soDangKy = value;
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

        public DateTime NgayDangKy
        {
            get
            {
                return DateTime.Now;
            }

            set
            {
                ngayDangKy = value;
            }
        }
    }
}
