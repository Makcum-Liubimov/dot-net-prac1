using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MonthCheckBoxLibrary
{
    public class MonthCheckBoxGroup : UserControl
    {
        private CheckBox[] checkBoxes;

        public MonthCheckBoxGroup()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.checkBoxes = new CheckBox[12];
            for (int i = 0; i < 12; i++)
            {
                this.checkBoxes[i] = new CheckBox();
                this.checkBoxes[i].Text = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[i];
                this.checkBoxes[i].Location = new Point(10, 20 + i * 30);
                this.Controls.Add(this.checkBoxes[i]);
            }
        }

        [Category("Behavior"), Description("Gets or sets the checked state of the months.")]
        public bool[] CheckedMonths
        {
            get
            {
                bool[] checkedMonths = new bool[12];
                for (int i = 0; i < 12; i++)
                {
                    checkedMonths[i] = checkBoxes[i].Checked;
                }
                return checkedMonths;
            }
            set
            {
                for (int i = 0; i < 12; i++)
                {
                    checkBoxes[i].Checked = value[i];
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int spacing = this.Height / 12;
            for (int i = 0; i < 12; i++)
            {
                this.checkBoxes[i].Location = new Point(10, spacing * i);
                this.checkBoxes[i].Width = this.Width - 20;
            }
        }
    }
}
