﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class PhieuThu
    {
        string soPhieuThu, liDoThu, maHocVien;
        long soTien;
        DateTime ngayThu;

        public PhieuThu(string soPhieuThu, string liDoThu, string maHocVien, long soTien, DateTime ngayThu)
        {
            this.soPhieuThu = soPhieuThu;
            this.liDoThu = liDoThu;
            this.maHocVien = maHocVien;
            this.soTien = soTien;
            this.ngayThu = ngayThu;
        }
    }
}
