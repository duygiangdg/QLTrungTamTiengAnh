using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    class ChucVu
    {
        string maChucVu, tenChucVu;
        decimal luongCoBan;

        public string MaChucVu
        {
            get
            {
                return maChucVu;
            }

            set
            {
                maChucVu = value;
            }
        }

        public string TenChucVu
        {
            get
            {
                return tenChucVu;
            }

            set
            {
                tenChucVu = value;
            }
        }

        public decimal LuongCoBan
        {
            get
            {
                return luongCoBan;
            }

            set
            {
                luongCoBan = value;
            }
        }
    }
}
