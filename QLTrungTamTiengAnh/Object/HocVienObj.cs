using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class HocVienObj
    {
        string maHocVien, tenHocVien, diaChi, soDienThoai, email, maLop;
        DateTime ngaySinh;

        public HocVienObj(string maHocVien, string tenHocVien, string diaChi, string soDienThoai, string email, string maLop, DateTime ngaySinh)
        {
            this.maHocVien = maHocVien;
            this.tenHocVien = tenHocVien;
            this.diaChi = diaChi;
            this.soDienThoai = soDienThoai;
            this.email = email;
            this.maLop = maLop;
            this.ngaySinh = ngaySinh;
        }
    }
}
