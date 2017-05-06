using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.Component
{
    class InputRegion : Panel
    {
        public bool CheckInput()
        {
            return CheckInput(this);
        }

        private bool CheckInput(System.Windows.Forms.Control control)
        {
            if (control.Controls.Count == 0)
            {
                return true;
            }
            else
            {
                foreach (System.Windows.Forms.Control controlInside in control.Controls)
                {
                    if (typeof(IInput).IsAssignableFrom(controlInside.GetType()))
                    {
                        IInput iInput = (IInput)controlInside;
                        if (!iInput.CheckInput()) return false;
                    }
                    else
                    {
                        if (!CheckInput(controlInside)) return false;
                    }
                }
            }
            return true;
        }
    }
}
