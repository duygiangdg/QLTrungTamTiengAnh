﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.View
{
    class TextLabel : Panel
    {
        private const string CONSTRAIN_NOT_EMPTY = "NotEmpty";
        private const string CONSTRAIN_INTEGER = "Integer";
        private const string CONSTRAIN_DATETIME = "DateTime";
        private string label = "Label";
        private string constrains = "";
        private string propertyName = "";
        private DevComponents.DotNetBar.Controls.TextBoxX textBox;
        private DevComponents.DotNetBar.LabelX textLabel;

        public string Label
        {
            get
            {
                return label;
            }

            set
            {
                label = value;
                this.textLabel.Text = label;
            }
        }

        public string Constrains
        {
            get
            {
                return constrains;
            }

            set
            {
                constrains = value;
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

        public TextLabel()
        {
            this.textBox = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textLabel = new DevComponents.DotNetBar.LabelX();

            // textBox
            this.textBox.Border.Class = "TextBoxBorder";
            this.textBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textBox.Location = new System.Drawing.Point(0, 19);
            this.textBox.Name = "textBox";
            this.textBox.PreventEnterBeep = true;
            this.textBox.Size = new System.Drawing.Size(200, 20);
            this.textBox.TabIndex = 1;
            this.textBox.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                this.textLabel.Text = label;
                this.textLabel.ForeColor = System.Drawing.Color.Black;
            });

            // label
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textLabel.Location = new System.Drawing.Point(0, -3);
            this.textLabel.Name = "label";
            this.textLabel.Size = new System.Drawing.Size(200, 23);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = Label;

            // this
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textLabel);
            this.Size = new System.Drawing.Size(200, 39);
        }

        public bool ValidateInput()
        {
            string[] constrainArray = Constrains.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (constrainArray.Contains(CONSTRAIN_NOT_EMPTY) && this.textBox.Text.Trim().Equals(""))
            {
                this.textLabel.Text = label + " không được để trống";
                this.textLabel.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            if (constrainArray.Contains(CONSTRAIN_INTEGER))
            {
                try
                {
                    long.Parse(this.textBox.Text.Trim());
                }
                catch
                {
                    this.textLabel.Text = label + " không hợp lệ";
                    this.textLabel.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
            }

            if (constrainArray.Contains(CONSTRAIN_DATETIME))
            {
                try
                {
                    DateTime.ParseExact(this.textBox.Text.Trim(), "dd/MM/yyyy", null);
                }
                catch
                {
                    try
                    {
                        DateTime.ParseExact(this.textBox.Text.Trim(), "dd-MM-yyyy", null);
                    }
                    catch
                    {
                        this.textLabel.Text = label + " không hợp lệ";
                        this.textLabel.ForeColor = System.Drawing.Color.Red;
                        return false;
                    }
                }
            }

            return true;
        }

        public void SetText(String text)
        {
            string[] constrainArray = Constrains.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (constrainArray.Contains(CONSTRAIN_DATETIME))
            {
                this.textBox.Text = text.Substring(0, 10);
                return;
            }
            this.textBox.Text = text;
        }
    }
}