using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.Component
{
    class XComboBox : ComboBoxEx, IInput
    {
        bool autoInput = false;
        bool required = false;
        string type = "Text";
        string displayedName = null;
        string propertyName = "";

        public bool AutoInput
        {
            get
            {
                return autoInput;
            }

            set
            {
                autoInput = value;
                Enabled = !autoInput;
            }
        }

        public bool Required
        {
            get
            {
                return required;
            }

            set
            {
                required = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string PropertyName
        {
            get
            {
                return propertyName;
            }

            set
            {
                propertyName = value;
            }
        }

        public string DisplayedName
        {
            get
            {
                return displayedName;
            }

            set
            {
                displayedName = value;
            }
        }

        public object GetValue()
        {
            if (type.Equals("List"))
            {
                return SelectedValue;
            }
            return Text;
        }

        public void SetValue(object obj)
        {
            if (type.Equals("List"))
            {
                SelectedValue = (string)obj;
            }
            else
            {
                Text = (string)obj;
            }
        }

        public bool CheckInput()
        {
            if (Text.Trim().Equals("") && required)
            {
                MessageBox.Show(DisplayedName + " không được để trống!");
                Focus();
                return false;
            }
            return true;
        }
    }
}
