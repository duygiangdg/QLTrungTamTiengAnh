using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamTiengAnh.Component
{
    interface IInput
    {
        bool AutoInput { get; set; }
        bool Required { get; set; }
        string Type { get; set; }
        string DisplayedName { get; set; }
        string PropertyName { get; set; }
        object Value { get; set; }
        bool CheckInput();
    }
}
