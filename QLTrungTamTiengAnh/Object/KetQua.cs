using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class KetQua
    {
        string maHocVien;
        int diemLevel1, diemLevel2, diemLevel3, xepLoai;

        public KetQua(string maHocVien, int diemLevel1, int diemLevel2, int diemLevel3, int xepLoai)
        {
            this.maHocVien = maHocVien;
            this.diemLevel1 = diemLevel1;
            this.diemLevel2 = diemLevel2;
            this.diemLevel3 = diemLevel3;
            this.xepLoai = xepLoai;
        }
    }
}
