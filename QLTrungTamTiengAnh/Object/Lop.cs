using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class Lop
    {
        string maLop, maGiaoVien, maTroGiang, maHocPhan;
        int trangThai;

        public string MaGiaoVien
        {
            get
            {
                return maGiaoVien;
            }

            set
            {
                maGiaoVien = value;
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

        public string MaLop
        {
            get
            {
                return maLop;
            }

            set
            {
                maLop = value;
            }
        }

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

        public int TrangThai
        {
            get
            {
                return trangThai;
            }

            set
            {
                trangThai = value;
            }
        }
    }
}
