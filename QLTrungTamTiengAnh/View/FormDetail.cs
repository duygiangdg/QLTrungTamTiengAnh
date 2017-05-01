using QLTrungTamTiengAnh.Model;
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
        public const int MODE_VIEW = 1;
        public const int MODE_EDIT = 0;
        protected String extra;
        protected int mode = 0;
        public FormDetail()
        {
            InitializeDetailForm();
        }

        private void FormDetail_Load(object sender, EventArgs e)
        {
            if (extra != null)
            {
                if (mode == MODE_VIEW)
                {
                    this.btnLuu.Text = "Sửa";
                    DisableTextInput();
                }
            }
        }

        public FormDetail PutExtra(string extra)
        {
            this.extra = extra;
            return this;
        }

        public FormDetail SetMode(int mode)
        {
            this.mode = mode;
            return this;
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
                        if (property.GetValue(obj) != null)
                        {
                            textLabel.SetText(property.GetValue(obj).ToString());
                        }
                    }
                }
            }
        }

        protected object CreateObject(string className)
        {
            Type type = Type.GetType(className, true);
            var instance = Activator.CreateInstance(type);

            foreach (var control in this.groupPanel1.Controls)
            {
                if (control.GetType() == typeof(TextLabel))
                {
                    TextLabel textLabel = (TextLabel)control;
                    PropertyInfo property = type.GetProperty(textLabel.PropertyName);
                    if (property != null && !textLabel.GetText().Trim().Equals(""))
                    {
                        if (property.PropertyType == typeof(string))
                        {
                            property.SetValue(instance, textLabel.GetText());
                        }
                        else if (property.PropertyType == typeof(DateTime))
                        {
                            property.SetValue(instance, DateTime.ParseExact(textLabel.GetText().Trim(), "dd/MM/yyyy", null));
                        }
                    }
                }
            }

            return instance;
        }

        protected void ClearForm()
        {
            foreach (var control in this.groupPanel1.Controls)
            {
                if (control.GetType() == typeof(TextLabel))
                {
                    ((TextLabel)control).ClearText();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
