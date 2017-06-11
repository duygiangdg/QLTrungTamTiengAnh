using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    class PhieuChi
    {
        string soPhieuChi, liDo, maNhanVien, bangChu, nhomKhoanChi, ghiChu;
        decimal soTien;
        DateTime ngayChi;

        public string SoPhieuChi
        {
            get
            {
                return soPhieuChi;
            }

            set
            {
                soPhieuChi = value;
            }
        }

        public string LiDo
        {
            get
            {
                return liDo;
            }

            set
            {
                liDo = value;
            }
        }

        public string MaNhanVien
        {
            get
            {
                return maNhanVien;
            }

            set
            {
                maNhanVien = value;
            }
        }

        public string BangChu
        {
            get
            {
                return bangChu;
            }

            set
            {
                bangChu = value;
            }
        }

        public string NhomKhoanThu
        {
            get
            {
                return nhomKhoanChi;
            }

            set
            {
                nhomKhoanChi = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChu;
            }

            set
            {
                ghiChu = value;
            }
        }

        public decimal SoTien
        {
            get
            {
                return soTien;
            }

            set
            {
                soTien = value;
            }
        }

        public DateTime NgayThu
        {
            get
            {
                return ngayChi;
            }

            set
            {
                ngayChi = value;
            }
        }
    }
}
