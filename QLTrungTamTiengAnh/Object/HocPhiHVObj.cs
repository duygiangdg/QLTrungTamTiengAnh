using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class HocPhiHVObj
    {
        string maHocVien, soDangKy;
        long tongHocPhi, daThu, conThieu;

        public long ConThieu
        {
            get
            {
                return conThieu;
            }

            set
            {
                conThieu = value;
            }
        }

        public long DaThu
        {
            get
            {
                return daThu;
            }

            set
            {
                daThu = value;
            }
        }

        public string MaHocVien
        {
            get
            {
                return maHocVien;
            }

            set
            {
                maHocVien = value;
            }
        }

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

        public long TongHocPhi
        {
            get
            {
                return tongHocPhi;
            }

            set
            {
                tongHocPhi = value;
            }
        }
    }
}
