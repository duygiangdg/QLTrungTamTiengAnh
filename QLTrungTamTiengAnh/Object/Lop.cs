using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Object
{
    public class Lop
    {
        string maLop, maTroGiang, lichHoc;
        int level;
        bool daKetThuc;

        public Lop(string maLop, string maTroGiang, string lichHoc, int level, bool daKetThuc)
        {
            this.maLop = maLop;
            this.maTroGiang = maTroGiang;
            this.lichHoc = lichHoc;
            this.level = level;
            this.daKetThuc = daKetThuc;
        }
    }
}
