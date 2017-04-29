using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.View
{
    public partial class FormDetail : DevComponents.DotNetBar.Office2007Form
    {
        public FormDetail()
        {
            InitializeComponent();
        }

        protected bool ValidateTextInput()
        {
            bool check = true;

            foreach (var control in this.groupPanel1.Controls)
            {
                if (control.GetType() == typeof(TextLabel))
                {
                    if (!((TextLabel)control).ValidateInput())
                    {
                        check = false;
                    }
                }
            }
            return check;
        }

        protected void EnableTextInput()
        {
            foreach (var control in this.groupPanel1.Controls)
            {
                if (control.GetType() == typeof(TextLabel))
                {
                    ((TextLabel)control).Enabled = true;
                }
            }
        }

        protected void DisableTextInput()
        {
            foreach (var control in this.groupPanel1.Controls)
            {
                if (control.GetType() == typeof(TextLabel))
                {
                    ((TextLabel)control).Enabled = false;
                }
            }
        }

        protected void BindData(object obj)
        {
            Type type = obj.GetType();
            foreach (var control in this.groupPanel1.Controls)
            {
                if (control.GetType() == typeof(TextLabel))
                {
                    TextLabel textLabel = (TextLabel)control;
                    PropertyInfo property = type.GetProperty(textLabel.PropertyName);
                    if (property!=null)
                    {
                        textLabel.SetText(property.GetValue(obj).ToString());
                    }
                }
            }
        }
    }
}
