using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    class HocPhan
    {
        string maHocPhan, tenHocPhan;
        decimal mucHocPhi;

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

        public decimal MucHocPhi
        {
            get
            {
                return mucHocPhi;
            }

            set
            {
                mucHocPhi = value;
            }
        }

        public string TenHocPhan
        {
            get
            {
                return tenHocPhan;
            }

            set
            {
                tenHocPhan = value;
            }
        }
    }
}
