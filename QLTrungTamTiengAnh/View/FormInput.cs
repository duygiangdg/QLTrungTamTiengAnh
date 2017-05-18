using QLTrungTamTiengAnh.Component;
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
    public partial class FormInput : Form
    {
        protected FormInput()
        {
            InitializeFormInput();
        }

        private void FormInput_Load(object sender, EventArgs e)
        {
            panel1.Anchor = AnchorStyles.None;
        }

        protected bool CheckInput()
        {
            return CheckInput(this);
        }

        protected void EnableInput()
        {
            EnableInput(this);
        } 

        protected void DisableInput()
        {
            DisableInput(this);
        }

        protected void Clear()
        {
            Clear(this);
        }

        protected void BindData(object obj)
        {
            BindData(obj, this);
        }

        protected object CreateObject(string className)
        {
            Type type = Type.GetType(className, false);
            var instance = Activator.CreateInstance(type);

            UpdateObject(instance, this);
            return instance;
        }

        #region private Functions

        private void BindData(object obj, System.Windows.Forms.Control control)
        {
            Type type = obj.GetType();

            foreach (System.Windows.Forms.Control controlInside in control.Controls)
            {
                if (typeof(IInput).IsAssignableFrom(controlInside.GetType()))
                {
                    IInput iInput = (IInput)controlInside;
                    PropertyInfo property = type.GetProperty(iInput.PropertyName);
                    if (property != null)
                    {
                        if (property.GetValue(obj) != null)
                        {
                            iInput.SetValue(property.GetValue(obj));
                        }
                    }
                }
                else BindData(obj, controlInside);
            }
        }

        private void UpdateObject(object obj, System.Windows.Forms.Control control)
        {
            Type type = obj.GetType();
            
            foreach (System.Windows.Forms.Control controlInside in control.Controls)
            {
                if (typeof(IInput).IsAssignableFrom(controlInside.GetType()))
                {
                    IInput iInput = (IInput)controlInside;
                    PropertyInfo property = type.GetProperty(iInput.PropertyName);
                    if (property != null)
                    {
                        property.SetValue(obj, iInput.GetValue());
                    }
                }
                else UpdateObject(obj, controlInside);
            }
        }

        private bool CheckInput(System.Windows.Forms.Control control)
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
            return true;
        }

        private void EnableInput(System.Windows.Forms.Control control)
        {
            foreach (System.Windows.Forms.Control controlInside in control.Controls)
            {
                if (typeof(IInput).IsAssignableFrom(controlInside.GetType()))
                {
                    IInput iInput = (IInput)controlInside;
                    if (!iInput.AutoInput) controlInside.Enabled = true;
                }
                else
                {
                    EnableInput(controlInside);
                }
            }
        }

        private void DisableInput(System.Windows.Forms.Control control)
        {
            foreach (System.Windows.Forms.Control controlInside in control.Controls)
            {
                if (typeof(IInput).IsAssignableFrom(controlInside.GetType()))
                {
                    controlInside.Enabled = false;
                }
                else
                {
                    DisableInput(controlInside);
                }
            }
        }

        private void Clear(System.Windows.Forms.Control control)
        {
            foreach (System.Windows.Forms.Control controlInside in control.Controls)
            {
                if (typeof(IInput).IsAssignableFrom(controlInside.GetType()))
                {
                    if (controlInside.GetType()==typeof(XTextBox))
                    {
                        ((XTextBox)controlInside).Clear();
                    }
                }
                else
                {
                    Clear(controlInside);
                }
            }
        }
        #endregion

    }
}
