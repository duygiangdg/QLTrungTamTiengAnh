using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class PhieuDangKyObj
    {
        string soDangKy, maKhachHang;
        int level, mucGiamHP;
        DateTime ngayDangKy, ngayHen;

        public PhieuDangKyObj(string soDangKy, string maKhachHang, int level, int mucGiamHP, DateTime ngayDangKy, DateTime ngayHen)
        {
            this.soDangKy = soDangKy;
            this.maKhachHang = maKhachHang;
            this.level = level;
            this.mucGiamHP = mucGiamHP;
            this.ngayDangKy = ngayDangKy;
            this.ngayHen = ngayHen;
        }
    }
}
