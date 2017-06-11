using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    class KhuyenMai
    {
        int id;
        string moTa, donVi;
        decimal mucKhuyenMai;

        public string DonVi
        {
            get
            {
                return donVi;
            }

            set
            {
                donVi = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string MoTa
        {
            get
            {
                return moTa;
            }

            set
            {
                moTa = value;
            }
        }

        public decimal MucKhuyenMai
        {
            get
            {
                return mucKhuyenMai;
            }

            set
            {
                mucKhuyenMai = value;
            }
        }
    }
}
