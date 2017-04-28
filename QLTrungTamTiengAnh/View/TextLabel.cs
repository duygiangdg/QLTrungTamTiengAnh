using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamTiengAnh.View
{
    class TextLabel : Panel
    {
        private string label = "Label";
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
    }
}
